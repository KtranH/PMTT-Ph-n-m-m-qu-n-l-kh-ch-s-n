<?php

namespace App\Http\Controllers;

use App\Models\DanhGia;
use App\Models\KhachHang;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class Review extends Controller
{
    //
    public function Review()
    {
        $user = KhachHang::find(Auth::user()->ID);
        $listNeedReview = $user->phieuDatPhong()
        ->with(['phieuNhanPhong.phieuTraPhong']) 
        ->whereHas('phieuNhanPhong.phieuTraPhong', function ($query) {
            $query->where('TINHTRANG', 'Đã thanh toán');
        })
        ->get();
        $listReview = DanhGia::where('KHACHHANG_ID', $user->ID)->where('ISDELETED', 0)->get();
        return view('ReviewController.Review', compact('listReview', 'listNeedReview'));
    }
}
