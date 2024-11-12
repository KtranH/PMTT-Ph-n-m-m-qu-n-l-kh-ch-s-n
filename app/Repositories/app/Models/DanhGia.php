<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class DanhGia extends Model
{
    //
    protected $table = 'danhgia';

    protected $fillable = [
        'NOIDUNG', 'SOSAO', 'PHIEUTRAPHONG_ID', 'KHACHHANG_ID', 'ISDELETED'
    ];

    public function phieuTraPhong()
    {
        return $this->belongsTo(PhieuTraPhong::class, 'PHIEUTRAPHONG_ID');
    }

    public function khachHang()
    {
        return $this->belongsTo(KhachHang::class, 'KHACHHANG_ID');
    }
}
