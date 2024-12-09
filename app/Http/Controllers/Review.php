<?php

namespace App\Http\Controllers;

use App\Models\DanhGia;
use App\Models\KhachHang;
use App\Models\PhieuTraPhong;
use App\Models\Phong;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use RealRashid\SweetAlert\Facades\Alert;

class Review extends Controller
{
    //
    public function Review()
    {
        $user = KhachHang::find(Auth::user()->ID);
        $listNeedReview = PhieuTraPhong::whereHas('phieuNhanPhong.phieuDatPhong.khachDatPhong', function ($query) {
            $query->where('ID', Auth::user()->ID);
        })
        ->whereDoesntHave('danhGia')
        ->get();
        $listReview = DanhGia::where('KHACHHANG_ID', $user->ID)->where('ISDELETED', 0)->get();
        return view('ReviewController.Review', compact('listReview', 'listNeedReview'));
    }
    public function WriteReview($id, $checkout_id)
    {
        $phong = Phong::findOrFail($id);
        $checkout = PhieuTraPhong::findOrFail($checkout_id);
        return view('ReviewController.WriteReview', compact('phong', 'checkout'));
    }
    public function AddReview(Request $request)
    {
        DanhGia::create ([
           "NOIDUNG" => $request->input("content"),
           "SOSAO" =>  $request->input("star"),
           "PHIEUTRAPHONG_ID" => $request->input("checkout_id"),
           "KHACHHANG_ID" => Auth::user()->ID,
           "ISDELETED" => true
        ]);

        Alert::success("Thông báo", "Thêm bình luận thành công")->autoClose(3000);
        return redirect()->route('review');
    }
}
