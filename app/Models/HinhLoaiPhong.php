<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class HinhLoaiPhong extends Model
{
    //
    protected $table = 'hinhloaiphong';

    protected $fillable = ['LOAIPHONG_ID', 'HINH'];

    public function loaiPhong()
    {
        return $this->belongsTo(LoaiPhong::class, 'LOAIPHONG_ID');
    }
}
