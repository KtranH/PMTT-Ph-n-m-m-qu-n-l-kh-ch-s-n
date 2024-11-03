<?php

namespace App\Http\Controllers;

use App\Models\KhachHang;
use App\Query;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Cookie;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Session;
use Laravel\Socialite\Facades\Socialite;
use App\Http\Controllers\Email;
use RealRashid\SweetAlert\Facades\Alert;

class Account extends Controller
{
    //
    use Query;
    public function Login(){
        return view('AccountController.Login');
    }
    public function SignUp(){
        return view('AccountController.SignUp');
    }
    public function loginByGoogle()
    {
        return Socialite::driver("google")->redirect();
    }
    public function Logout()
    {
        Auth::logout();
        Cookie::forget("token_account");
        Session::flush();
        return redirect()->back();
    }
    public function callBackGoogle()
    {
        try {
            $user = Socialite::driver("google")->user();
            $email = $user->getEmail();
            $name = $user->getName();
            $avatar = $user->getAvatar();

            $existingUser = KhachHang::where("EMAIL", $email)->first();
            if (!$existingUser) {
                KhachHang::insert([
                    "HOTEN" => $name,
                    "GIOITINH" => "Chưa rõ",
                    "NGAYSINH" => "2000-01-01",
                    "SDT" => "Chưa rõ",
                    "DIEMTINNHIEM" => 100,
                    "AVATAR" => $avatar,
                    "CCCD" => "Chưa rõ",
                    "EMAIL" => $email,
                    "PASSWORD" => Hash::make("20012158840792030230440707349054"),
                    "ISDELETED" => 0
                ]);
            }
            $cookie = Cookie::make("token_account", $email, 3600 * 24 * 30);
            Auth::attempt(["EMAIL" => $email, "password" => "20012158840792030230440707349054"], true);
            return redirect()->route("Home")->withCookie($cookie);
        } catch (Exception $e) {
            return redirect()->route("Login");
        }
    }
    public function NewAccount(Request $request)
    {
        $request->validate([
            'name' => 'required|string|max:255|min:6',
            'email' => 'required|string|email|max:255|unique:khachhang,EMAIL',
            'password' => 'required|string|min:6',
            'password2' => 'required|string|min:6',
        ], [
            'name.required' => 'Vui lòng nhập tên người dùng',
            'name.max' => 'Tên người dùng phải nhỏ hơn 255 ký tự',
            'name.min' => 'Tên người dùng phải nhiều hơn 6 ký tự',
            'email.required' => 'Vui lòng nhập email',
            'email.email' => 'Email phải là email',
            'email.max' => 'Email phải nhỏ hơn 255 ký tự',
            'email.unique' => 'Email đã tồn tại',
            'password.required' => 'Vui lòng nhập Password',
            'password.min' => 'Password phải nhiều hơn 6 ký tự',
            'password2.required' => 'Vui lòng nhập lại Password',
            'password2.min' => 'Password phải nhiều hơn 6 ký tự',
        ]);
        $name = $request->input("name");
        $email = $request->input("email");
        $password = $request->input("password");
        $password2 = $request->input("password2");

        $errorEmail = KhachHang::where("EMAIL", $email)->exists();
        
        $errors = [];

        if ($errorEmail) {
            $errors['email'] = 'Email đã được sử dụng.';
        }

        if ($password != $password2) {
            $errors['password'] = 'Mật khẩu không khớp.';
        }
        if (!empty($errors)) {
            return redirect()->back()->withErrors($errors)->withInput();
        }       
        
        Session::put("name", $name);
        Session::put("email", $email);
        Session::put("password", $password);
        return redirect()->route("SendCodeAuthToEmail");
    }
    public function ShowAuth()
    {
        return view('AccountController.ShowAuth');
    }
    public function AccessLogin(Request $request)
    {
        $request->validate([
            'email' => 'email|max:255',
            'password' => 'min:6',
        ], [
            'email.email' => 'Email phải là email',
            'email.max' => 'Email phải nhỏ hơn 255 ký tự',
            'password.min' => 'Password phải nhiều hơn 6 ký tự',
        ]);
        $email = $request->input("email");
        $password = $request->input("password");

        $user = KhachHang::where("EMAIL", $email)->first();
        if ($user && Hash::check($password, $user->PASSWORD)) {
            if($request->has("remember")) {
                $cookie = Cookie::make("token_account", $email, 43200);
                Auth::attempt(["EMAIL" => $email, "password" => $password], true);
            }
            $cookie = Cookie::make("token_account", $email, 0);
            Auth::attempt(["EMAIL" => $email, "password" => $password], false);
            return redirect()->route("Home")->withCookie($cookie);
        }
        return redirect()->back()->with('error', 'Email hoặc mật khẩu không khớp');
    }
    public function ForgetPassword()
    {
        return view('AccountController.ForgetPassword');
    }
    public function AuthEmailToChangePassword(Request $request)
    {
        $request->validate([
            'email' => 'max:255',
        ], [
            'email.max' => 'Email phải nhỏ hơn 255 ký tự',
        ]);
        $email = $request->input("email");
        $user = KhachHang::where("EMAIL", $email)->first();
        if (!$user) {
            return redirect()->back()->with('error', 'Email không tìm thấy cho bất kì tài khoản nào');
        }
        $sendEmail = new Email();
        return $sendEmail->SendCodeToChangePassword($user);
    }
    public function ShowAuthChangePassword()
    {
        return view('AccountController.ShowAuthChangePassword');
    }
    public function HomeAccount()
    {
        $user = Auth::user();
        return view('AccountController.HomeAccount', compact('user'));
    }
    public function PageUpdateAccount()
    {
        $user = Auth::user();
        return view('AccountController.ShowUpdateAccount', compact('user'));
    }
    public function UpdateAccount(Request $request)
    {  
        $name = $request->input("fullName");
        $phone = $request->input("phone");
        $cccd = $request->input("cccd");
        $birthday = $request->input("birthday");
        $gender = $request->input("gender");
        $user = KhachHang::where("EMAIL", Auth::user()->EMAIL)->firstOrFail();
        $user->HOTEN = $name;
        $user->SDT = $phone;
        $user->CCCD = $cccd;
        $user->NGAYSINH = $birthday;
        $user->GIOITINH = $gender;
        try
        {
            if($request->hasFile('avatar')) {
                $this->PushAvatarR2(Auth::user()->EMAIL, $request->file('avatar'));
            }
        }
        catch (Exception $e)
        {
            Alert::toast('Cập nhật thất bại', 'error')->position('bottom-left')->autoClose(3000);
            return redirect()->back();
        }
        $user->save();
        Alert::toast('Cập nhật thành cảnh công', 'success')->position('bottom-left')->autoClose(3000);
        return redirect()->back();
    }
    public function ChangePassword(Request $request)
    {
        $request->validate([
            'password' => 'min:6',
            'newpassword' => 'min:6',
            'renewpassword' => 'min:6',
        ], [
            'password.min' => 'Password phải nhiều hơn 6 ký tự',
            'newpassword.min' => 'Password phải nhiều hơn 6 ký tự',
            'renewpassword.min' => 'Password phải nhiều hơn 6 ký tự',
        ]);
        $currentPassword = $request->input("password");
        if(!Hash::check($currentPassword, Auth::user()->PASSWORD)) {
            Alert::toast('Mật khẩu hiện tại không chính xác', 'error')->position('top-left')->autoClose(3000);
            return redirect()->back();
        }
        $password = $request->input("newpassword");
        $password2 = $request->input("renewpassword");
        $user = KhachHang::where("EMAIL", Auth::user()->EMAIL)->firstOrFail();
        if ($password != $password2) {
            Alert::toast('Mật khẩu không khớp với nhau', 'error')->position('top-left')->autoClose(3000);
            return redirect()->back();
        }
        $user->PASSWORD = Hash::make($password);
        $user->save();
        Alert::toast('Đổi mật khẩu thành cảnh công', 'success')->position('top-left')->autoClose(3000);
        return $this->Logout();
    }
}
