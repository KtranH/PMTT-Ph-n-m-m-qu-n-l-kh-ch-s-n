<?php

namespace App\Http\Controllers;

use App\Models\KhachHang;
use App\Models\LoaiPhong;
use App\Models\PhieuDatPhong;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class Booking extends Controller
{
    //
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
        return view('BookingController.SetupBooking', compact('cateRoom'));
    }
}
