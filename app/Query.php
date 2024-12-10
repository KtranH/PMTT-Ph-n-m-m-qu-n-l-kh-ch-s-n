<?php

namespace App;

use App\Models\KhachHang;
use App\Models\Phong;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Storage;

trait Query
{
    //

    public function PushAvatarR2($email, $avatar)
    {
        if($avatar == null)
        {
            $img = public_path("assets/img/default_avatar.jpg");
            $path = "Avatar/{$email}/default_avatar.jpg";
        }
        else
        {
            $img = $avatar;
            $imgName = $avatar->getClientOriginalName();
            $path = "Avatar/{$email}/{$imgName}";
        }
        Storage::disk('r2')->put($path, file_get_contents($img));
    }
    public function CheckQuantityRoomInCart()
    {
        $user = KhachHang::find(Auth::user()->ID);
        $total_quantity = $user->gioHang()->get()->sum(function ($item) {
            return $item->pivot->SOLUONG;
        });
        if($total_quantity >= 5)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public function CheckQuantityRoomInCate($id)
    {
        $cateRoom = Phong::where('LOAIPHONG_ID', $id)->count();
        if($cateRoom == 0)
        {
            return false;
        }
        return true;
    }
    public function CheckQuantityRoomInCateEnough($id)
    {
        $cateRoom = Phong::where('LOAIPHONG_ID', $id)->count();
        if($cateRoom < 2)
        {
            return false;
        }
        return true;
    }
    public function CheckInformationUser()
    {
        if(Auth::user()->SDT == "Chưa rõ" || Auth::user()->CCCD == "Chưa rõ") {
            return false;
        }
        return true;
    }
}
