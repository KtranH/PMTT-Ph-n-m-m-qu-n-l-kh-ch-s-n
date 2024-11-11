<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Phong extends Model
{
    //
    protected $table = 'phong';

    protected $fillable = [
        'ID', 'TENPHONG', 'VITRI', 'LOAIPHONG_ID', 'TRANGTHAI'
    ];

    public function loaiPhong()
    {
        return $this->belongsTo(LoaiPhong::class, 'LOAIPHONG_ID');
    }

    public function phieuNhanPhong()
    {
        return $this->hasMany(PhieuNhanPhong::class, 'PHONG_ID');
    }
}
