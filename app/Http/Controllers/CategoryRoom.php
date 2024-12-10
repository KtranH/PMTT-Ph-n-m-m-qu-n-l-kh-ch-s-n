<?php

namespace App\Http\Controllers;

use App\Models\DanhGia;
use App\Models\LoaiPhong;
use Illuminate\Http\Request;

class CategoryRoom extends Controller
{
    //
    public function AllCateRoom()
    {
        $allCategory = LoaiPhong::where('ISDELETED', 0)->paginate(6);
        return view('CategoryRoomController.AllCategoryRoom', compact('allCategory'));
    }
    public function CateRoom_1()
    {
        $categoryroom_1 = LoaiPhong::where('SUCCHUA', 1)->where('ISDELETED', 0)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_1', compact('categoryroom_1'));
    }
    public function CateRoom_2()
    {
        $categoryroom_2 = LoaiPhong::where('SUCCHUA', 2)->where('ISDELETED', 0)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_2', compact('categoryroom_2'));
    }
    public function CateRoom_4()
    {
        $categoryroom_4 = LoaiPhong::where('SUCCHUA', 4)->where('ISDELETED', 0)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_4', compact('categoryroom_4'));
    }
    public function CateRoom_PriceHighToLow()
    {
        $categoryroom_price_hightolow = LoaiPhong::orderBy('GIATHUE', 'desc')->where('ISDELETED', 0)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_PriceHighToLow', compact('categoryroom_price_hightolow'));
    }
    public function CateRoom_PriceLowToHigh()
    {
        $categoryroom_price_lowtohigh = LoaiPhong::orderBy('GIATHUE', 'asc')->where('ISDELETED', 0)->paginate(6);
        return view('CategoryRoomController.CategoryRoom_PriceLowToHigh', compact('categoryroom_price_lowtohigh'));
    }
    public function Overview_CateRoom($id)
    {
        $Overview_CateRoom = LoaiPhong::where('ID', $id)->where('ISDELETED', 0)->first();
        $Review = DanhGia::whereHas('phieuTraPhong.phieuNhanPhong.phong.loaiPhong', function ($query) use ($id) {
            $query->where('ID', $id)->where('ISDELETED', 0);
        })->get();
        return view('CategoryRoomController.OverviewRoom', compact('Overview_CateRoom', 'Review'));
    }
}
