<?php

namespace App\Http\Controllers;

use App\Models\DanhGia;
use App\Models\KhachHang;
use App\Models\LoaiPhong;
use App\Models\Phong;
use Exception;
use Illuminate\Support\Facades\Auth;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Cookie;

class Home extends Controller
{
    //
    public function Home()
    {
        $lines = file(storage_path('Files/activity.txt'));
        $fileJson = file_get_contents(storage_path('Files/news.json'));
        $data = json_decode($fileJson, true);
        $roomFeature = LoaiPhong::inRandomOrder()->limit(4)->get();
        $countCustomer = KhachHang::count();    
        $countRoom = Phong::where('TRANGTHAI', 'Trống')->count();
        $countReview = DanhGia::count();    
        $listCateRoom = LoaiPhong::where('ISDELETED', 0)->inRandomOrder()->limit(3)->get();
        return view('HomeController.Home', compact('lines', 'data', 'roomFeature', 'countCustomer', 'countRoom', 'countReview', 'listCateRoom'));
    }
}
