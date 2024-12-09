<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class PhieuDatPhong extends Model
{
    //
    protected $table = 'phieudatphong';

    protected $fillable = [
        'LOAIPHONG_ID', 'NGAYNHANPHONG', 'NGAYTRAPHONGDUKIEN', 'THANHTOAN', 'TINHTRANG', 'KHACHHANG_ID', 'MAPIN', 'LUUTRU'
    ];
    public $timestamps = false;
    public function loaiPhong()
    {
        return $this->belongsTo(LoaiPhong::class, 'LOAIPHONG_ID');
    }
    public function phieuNhanPhong()
    {
        return $this->hasOne(PhieuNhanPhong::class, 'PHIEUDATPHONG_ID');
    }
    public function khachDatPhong()
    {
        return $this->belongsTo(KhachHang::class, 'KHACHHANG_ID');
    }

}
