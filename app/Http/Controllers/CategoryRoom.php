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
        $categoryroom_1 = LoaiPhong::where('SUCCHUA', 1)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_1', compact('categoryroom_1'));
    }
    public function CateRoom_2()
    {
        $categoryroom_2 = LoaiPhong::where('SUCCHUA', 2)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_2', compact('categoryroom_2'));
    }
    public function CateRoom_4()
    {
        $categoryroom_4 = LoaiPhong::where('SUCCHUA', 4)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_4', compact('categoryroom_4'));
    }
}
