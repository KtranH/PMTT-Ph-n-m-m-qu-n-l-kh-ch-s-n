<?php

namespace App;

use Illuminate\Support\Facades\Storage;

trait Query
{
    //

    public function PushAvatarR2($name, $avatar)
    {
        if($avatar == "default")
        {
            $img = public_path('assets/img/default_avatar.jpg');
            $path = "User/Avatar/{$name}/default_avatar.png";
        }
        else
        {
            $img = $avatar;
            $imgName = $avatar->getClientOriginalName();
            $path = "User/Avatar/{$name}/{$avatar}.png";
        }
        Storage::disk('r2')->put($path, file_get_contents($img));
    }
}
