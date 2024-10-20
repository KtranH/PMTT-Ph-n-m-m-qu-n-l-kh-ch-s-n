<?php

namespace App\Http\Controllers;

use App\Models\KhachHang;
use Illuminate\Http\Request;

class Home extends Controller
{
    //
    public function Home()
    {
        $khachhang = KhachHang::all();
        return view('HomeController.Home', compact('khachhang'));
    }
}
