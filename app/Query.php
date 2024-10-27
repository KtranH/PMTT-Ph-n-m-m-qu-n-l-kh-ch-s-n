<?php

namespace App;

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
            $path = "Avatar/{$email}/{$imgName}.png";
        }
        Storage::disk('r2')->put($path, file_get_contents($img));
    }
}
