<?php

namespace App\Http\Controllers;

use App\Mail\ETicketMail;
use App\Mail\ETicketManyRoomMail;
use App\Models\KhachHang;
use App\Models\LoaiPhong;
use App\Models\PhieuDatPhong;
use App\Query;
use Illuminate\Http\Request;
use Illuminate\Support\Carbon;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Mail;
use RealRashid\SweetAlert\Facades\Alert;

class Booking extends Controller
{
    //
    use Query;
    public function Booking()
    {
        $user = KhachHang::find(Auth::user()->ID);
        $listBooking = $user->phieuDatPhong()->where('TINHTRANG', 'Đã đặt phòng')
        ->orWhere('TINHTRANG', 'Đã hủy')
        ->get();        
        $listCheckIn = $user->phieuDatPhong()->where('TINHTRANG', 'Đã nhận phòng')->get();
        return view('BookingController.Booking', compact('listBooking', 'listCheckIn'));
    }
    public function SetupBooking($id)
    {
        $cateRoom = LoaiPhong::find($id);
        if(!$this->CheckInformationUser())
        {
            Alert::error('Vui lòng cập nhật số điện thoại và căn cước!')->autoClose(3000);
            return redirect()->back();
        }
        else if($this->CheckQuantityRoomInCate($id)) {
            return view('BookingController.SetupBooking', compact('cateRoom'));
        }
        Alert::error('Loại phòng này hiện không hoạt động!')->autoClose(3000);
        return redirect()->back();
    }
    public function SetupBookingManyRooms($id = null)
    {
        if(!$this->CheckInformationUser())
        {
            Alert::error('Vui lòng cập nhật số điện thoại và căn cước!')->autoClose(3000);
            return redirect()->back();
        }
        $user = KhachHang::find(Auth::user()->ID);  
        if($id == null) {
            $listRoom = $user->gioHang()->get();
        }
        else {
            $listRoom = $user->gioHang()->wherePivot('LOAIPHONG_ID', $id)->get();
        }
        return view('BookingController.SetupBookingManyRooms', compact('listRoom'));
    }
    public function HashCode()
    {
        $hashCode = substr(sprintf('%04x%04x%04x', mt_rand(0, 0xffff), mt_rand(0, 0xffff), mt_rand(0, 0xffff)), 0, 12);
        return $hashCode;
    }
    public function ConfirmBooking(Request $request)
    {
        $user = KhachHang::find(Auth::user()->ID);
        if($user->phieuDatPhong()->where('TINHTRANG', 'Đã đặt phòng')->count() >= 5) {
            return response()->json(['success' => false, 'message' => 'Bạn chỉ được phép đặt trước đối đa 5 phòng!']);
        }
        try
        {
            $code = $this->HashCode();
            $user->phieuDatPhong()->create([
            'LOAIPHONG_ID' => $request->roomID,
            'NGAYNHANPHONG' => $request->checkIn,
            'NGAYTRAPHONGDUKIEN' => $request->checkOut,
            'THANHTOAN' => $request->payment,
            'TINHTRANG' => 'Đã đặt phòng',
            'MAPIN' => $code,
            'LUUTRU' => $request->occupant_info ? $request->occupant_info : null
            ]);

            $roomType = LoaiPhong::find($request->roomID)->TENLOAIPHONG;
            $status = "Đã xác nhận";

            Mail::to($user->EMAIL)->send(new ETicketMail($user, $roomType, $request->checkIn, $request->checkOut, $request->payment, $status, $request->occupant_info, $code));

            return response()->json(['success' => true]);
        }
        catch(\Exception $e)
        {
            return response()->json(['success' => false, 'message' => $e->getMessage()]);
        }
    }
    public function ConfirmBookingManyRooms(Request $request)
    {
        $user = KhachHang::find(Auth::user()->ID);
        if($user->phieuDatPhong()->where('TINHTRANG', 'Đã đặt phòng')->count() + $request->quantity > 5) {
            return response()->json(['success' => false, 'message' => 'Bạn chỉ được phép đặt trước đối đa 5 phòng!']);
        }
        try
        {
            $checkIn = Carbon::parse($request->checkIn);
            $checkOut = Carbon::parse($request->checkOut);
            $duration = $checkIn->diffInDays($checkOut);
            $bookingDetails = [];
            $code = $this->HashCode();
            foreach ($request->listRoom as $item) {
                for ($i = 0; $i < $item['pivot']['SOLUONG']; $i++) {
                    $user->phieuDatPhong()->create([
                    'LOAIPHONG_ID' => $item['ID'],
                    'NGAYNHANPHONG' => $request->checkIn,
                    'NGAYTRAPHONGDUKIEN' => $request->checkOut,
                    'THANHTOAN' => ($item['pivot']['DONGIA'] / $item['pivot']['SOLUONG']) * $duration,
                    'TINHTRANG' => 'Đã đặt phòng',
                    'MAPIN' => $code,
                    'LUUTRU' => $request->occupant_info ? $request->occupant_info : null
                    ]);
                }
                $bookingDetails[] = [
                    'roomType' => $item['TENLOAIPHONG'],
                    'checkIn' => $request->checkIn,
                    'checkOut' => $request->checkOut,
                    'payment' => $item['pivot']['DONGIA'],
                    'quantity' => $item['pivot']['SOLUONG'],
                    'status' => 'Đã đặt phòng',
                    'occupant_info' => $request->occupant_info,
                    'code' => $code
                ];
                $user->gioHang()->detach($item['ID']);
            }
            Mail::to($user->EMAIL)->send(new ETicketManyRoomMail($user, $bookingDetails));
            return response()->json(['success' => true]);
        }
        catch(\Exception $e)
        {
            return response()->json(['success' => false, 'message' => $e->getMessage()]);
        }
    }
}
