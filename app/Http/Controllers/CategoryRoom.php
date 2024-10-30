<?php

namespace App\Http\Controllers;

use App\Models\LoaiPhong;
use Illuminate\Http\Request;

class CategoryRoom extends Controller
{
    //
    public function AllCateRoom()
    {
        $allCategory = LoaiPhong::paginate(6);
        return view('CategoryRoomController.AllCategoryRoom', compact('allCategory'));
    }
    public function CateRoom_1()
    {
        $allCategory = LoaiPhong::where('SUCCHUA', 1)->paginate(6);
        return view('CategoryRoomController.CateRoom_1', compact('allCategory'));
    }
}
