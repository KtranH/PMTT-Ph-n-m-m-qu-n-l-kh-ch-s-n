<?php

namespace App;

use Illuminate\Support\Facades\Storage;

trait Query
{
    //

/*************  ✨ Codeium Command 🌟  *************/
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
/******  a7235be7-5050-4b1a-9f19-0c4020667014  *******/
}
