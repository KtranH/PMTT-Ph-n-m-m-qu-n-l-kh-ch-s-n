<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class LoaiPhong extends Model
{
    //
    protected $table = 'loaiphong';

    protected $fillable = [
        'ID', 'TENLOAIPHONG', 'MOTA', 'SUCCHUA', 'GIATHUE', 'QUYDINH', 'NOITHAT', 'TIENICH', 'ISDELETED'
    ];

    public function hinhLoaiPhong()
    {
        return $this->hasMany(HinhLoaiPhong::class, 'LOAIPHONG_ID', 'ID');
    }

    public function phong()
    {
        return $this->hasMany(Phong::class, 'LOAIPHONG_ID', 'ID');
    }

    public function gioHang()
    {
        return $this->belongsToMany(KhachHang::class, 'giohang', 'LOAIPHONG_ID', 'KHACHHANG_ID');
    }

    public function phieuDatPhong()
    {
        return $this->hasMany(PhieuDatPhong::class, 'LOAIPHONG_ID', 'ID');
    }
}
