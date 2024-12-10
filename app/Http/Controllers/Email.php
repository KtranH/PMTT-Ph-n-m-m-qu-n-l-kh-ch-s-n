<?php

namespace App\Http\Controllers;

use App\Mail\AuthEmail;
use App\Models\KhachHang;
use App\Query;
use Carbon\Carbon;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Mail;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Cookie;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Session;

class Email extends Controller
{
    //
    use Query;
    public function SendCodeAuthToEmail()
    {
        try {
            $email = Session::get("email");
            $name = Session::get("name");

            $verificationCode = rand(100000, 999999);
            $expiresAt = Carbon::now()->addMinutes(10);

            Session::put('verification_code', $verificationCode);
            Session::put('verification_code_expires_at', $expiresAt);

            $detail = [
                'name' => $name,
                'code' => $verificationCode
            ];

            Mail::to($email)->send(new AuthEmail($detail));

            return redirect()->route("ShowAuth");
        } catch (Exception $e) {
            dd($e);
            return redirect()->route("Home");
        }
    }
    public function ReSendCodeAuthToEmail(Request $request)
    {
        try {
            $email = Session::get("email");
            $name = Session::get("name");

            $lastSentAt = Session::get('last_verification_code_sent_at');

            if ($lastSentAt && Carbon::parse($lastSentAt)->diffInMinutes(Carbon::now()) < 10) {
                return redirect()->back()->with("error", "Bạn chỉ được gửi yêu cầu mỗi 10 phút");
            }

            $verificationCode = rand(100000, 999999);
            $expiresAt = Carbon::now()->addMinutes(10);

            Session::put('verification_code', $verificationCode);
            Session::put('verification_code_expires_at', $expiresAt);
            Session::put('last_verification_code_sent_at', Carbon::now());

            $detail = [
                'name' => $name,
                'code' => $verificationCode
            ];

            Mail::to($email)->send(new AuthEmail($detail));
            if($request->has('state')) 
            {
                return response()->json([
                    'success' => true, 'message' => "Đã gửi lại mã xác nhận"
                ]);
            }
            return redirect()->back()->with("success", "Đã gửi lại mã xác nhận");
        } catch (Exception $e) {
            if($request->has('state'))
            {
                return response()->json([
                    'success' => false, 'message' => "Có lỗi xảy ra không thể gửi lại mã"
                ]);
            }
            return redirect()->route("Login");
        }
    }
    public function VerifyCode(Request $request)
    {
        $request->validate([
            'code' => 'required|max:255',
        ], [
            'code.required' => 'Vui lòng nhập mã xác nhận', 
            'code.max' => 'Mã xác nhận phải nhỏ hơn 255 ký tự',
        ]);
        $code = $request->input("code");
        $verificationCode = Session::get('verification_code');
        $expiresAt = Session::get('verification_code_expires_at');
        if ($verificationCode && $expiresAt && $verificationCode == $code && Carbon::now()->lessThanOrEqualTo($expiresAt)) {
            Session::forget('verification_code');
            Session::forget('verification_code_expires_at');
            Session::forget('last_verification_code_sent_at');

            $name = Session::get("name");
            $email = Session::get("email");
            $pass = Session::get("password");

            Session::forget('name');
            Session::forget('email');
            Session::forget('password');

            $this->PushAvatarR2($email, null);
            $url = "https://pub-c8adcbfebc8642f887468c77f77c44fe.r2.dev" . "/Avatar/{$email}/default_avatar.jpg";

            KhachHang::insert([
                "HOTEN" => $name,
                "GIOITINH" => "Chưa rõ",
                "NGAYSINH" => "2000-01-01",
                "SDT" => "Chưa rõ",
                "DIEMTINNHIEM" => 100,
                "AVATAR" => $url,
                "CCCD" => "Chưa rõ",
                "EMAIL" => $email,
                "PASSWORD" => Hash::make($pass),
                "ISDELETED" => 0
            ]);

            $cookie = Cookie::make("token_account", $email, 3600 * 24 * 30);
            Auth::attempt(["EMAIL" => $email, "password" => $pass], true);
            return redirect()->route("Home")->withCookie($cookie);
        } else {
            $errors = [];
            $errors["ExpiredCode"] = "Mã xác nhận đã hết hạn";
            return redirect()->back()->withErrors($errors)->withInput();
        }
    }
    public function SendCodeToChangePassword($user)
    {
        try
        {
            $verificationCode = rand(100000, 999999);
            $expiresAt = Carbon::now()->addMinutes(10);

            Session::put('verification_code', $verificationCode);
            Session::put('verification_code_expires_at', $expiresAt);
            Session::put('last_verification_code_sent_at', Carbon::now());

            $detail = [
                'name' => $user->HOTEN,
                'code' => $verificationCode
            ];

            Mail::to($user->EMAIL)->send(new AuthEmail($detail));
            Session::put("email", $user->EMAIL);
            Session::put("name", $user->HOTEN);

            return redirect()->route("ShowAuthChangePassword");
        } catch (Exception $e) {
            dd($e);
            return redirect()->route("Home");
        }
    }

    public function VerifyCodeChangePassword(Request $request)
    {
        $request->validate([
            'code' => 'required|max:255',
        ], [
            'code.required' => 'Vui lòng nhập mã xác nhận', 
            'code.max' => 'Mã xác nhận phải nhỏ hơn 255 ký tự',
        ]);
        $code = $request->input("code");
        if($request->input("password") != $request->input("password2"))
        {
            return redirect()->back()->with("error", "Mật khẩu không trùng khớp");
        }
        $verificationCode = Session::get('verification_code');
        $expiresAt = Session::get('verification_code_expires_at');
        if ($verificationCode && $expiresAt && $verificationCode == $code && Carbon::now()->lessThanOrEqualTo($expiresAt)) {
            Session::forget('verification_code');
            Session::forget('verification_code_expires_at');
            Session::forget('last_verification_code_sent_at');
            $email = Session::get("email");
            $name = Session::get("name");
            Session::forget('email');
            Session::forget('name');
            
            KhachHang::where("EMAIL", $email)->update(["PASSWORD" => Hash::make($request->input("password"))]);
            return redirect()->route("Login")->with("success", "Đổi mật khẩu thành công");
        } else {
            $errors = [];
            $errors["ExpiredCode"] = "Mã xác nhận đã hết hạn";
            return redirect()->back()->withErrors($errors)->withInput();
        }
    }
}
