<?php

namespace App\Http\Controllers;

use App\Models\KhachHang;
use App\Models\LoaiPhong;
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
        return view('HomeController.Home', compact('lines', 'data', 'roomFeature'));
    }
}
