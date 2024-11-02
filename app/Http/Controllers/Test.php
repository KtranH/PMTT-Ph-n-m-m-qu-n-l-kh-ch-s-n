<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\Storage;
use Illuminate\Http\Request;

class Test extends Controller
{
    //
    public function TestImg()
    {
        $img = public_path("assets/img/default_avatar.jpg");
        $getImg = file_get_contents($img);
        $path = "Avatar/default_avatar.jpg";
        Storage::disk('r2')->put($path, $getImg);
        $img = base64_encode($img);
        return view("TestController.Test", compact("img"));
    }
}
