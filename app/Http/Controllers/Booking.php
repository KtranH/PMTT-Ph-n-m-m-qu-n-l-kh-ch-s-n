<?php

namespace App\Http\Controllers;

use App\Models\KhachHang;
use App\Models\LoaiPhong;
use App\Models\PhieuDatPhong;
use App\Query;
use Illuminate\Http\Request;
use Illuminate\Support\Carbon;
use Illuminate\Support\Facades\Auth;
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
        if($this->CheckQuantityRoomInCate($id)) {
            return view('BookingController.SetupBooking', compact('cateRoom'));
        }
        Alert::toast('Loại phòng này hiện không hoạt động!', 'error')->position('top-end')->autoClose(3000);
        return redirect()->back();
    }
    public function SetupBookingManyRooms($id = null)
    {
        $user = KhachHang::find(Auth::user()->ID);  
        if($id == null) {
            $listRoom = $user->gioHang()->get();
        }
        else {
            $listRoom = $user->gioHang()->wherePivot('LOAIPHONG_ID', $id)->get();
        }
        return view('BookingController.SetupBookingManyRooms', compact('listRoom'));
    }
    public function ConfirmBooking(Request $request)
    {
        $user = KhachHang::find(Auth::user()->ID);
        if($user->phieuDatPhong()->where('TINHTRANG', 'Đã đặt phòng')->count() >= 5) {
            return response()->json(['success' => false, 'message' => 'Bạn chỉ được phép đặt trước đối đa 5 phòng!']);
        }
        try
        {
            $user->phieuDatPhong()->create([
            'LOAIPHONG_ID' => $request->roomID,
            'NGAYNHANPHONG' => $request->checkIn,
            'NGAYTRAPHONGDUKIEN' => $request->checkOut,
            'THANHTOAN' => $request->payment,
            'TINHTRANG' => 'Đã đặt phòng',
            ]);
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
            foreach ($request->listRoom as $item) {
                for ($i = 0; $i < $item['pivot']['SOLUONG']; $i++) {
                    $user->phieuDatPhong()->create([
                    'LOAIPHONG_ID' => $item['ID'],
                    'NGAYNHANPHONG' => $request->checkIn,
                    'NGAYTRAPHONGDUKIEN' => $request->checkOut,
                    'THANHTOAN' => ($item['pivot']['DONGIA'] / $item['pivot']['SOLUONG']) * $duration,
                    'TINHTRANG' => 'Đã đặt phòng',
                    ]);
                }
                $user->gioHang()->detach($item['ID']);
            }
            return response()->json(['success' => true]);
        }
        catch(\Exception $e)
        {
            return response()->json(['success' => false, 'message' => $e->getMessage()]);
        }
    }
}
