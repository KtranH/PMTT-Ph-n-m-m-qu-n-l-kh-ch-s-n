<?php

namespace App\Models;

use Illuminate\Foundation\Auth\User as Authenticatable;

class KhachHang extends Authenticatable
{
    //
    protected $table = 'khachhang';

    protected $fillable = [
        'HOTEN', 'GIOITINH', 'NGAYSINH', 'SDT', 'DIEMTINNHIEM',
        'AVATAR', 'CCCD', 'EMAIL', 'PASSWORD', 'ISDELETED'
    ];

    public function danhGia()
    {
        return $this->hasMany(DanhGia::class);
    }

    public function gioHang()
    {
        return $this->belongsToMany(LoaiPhong::class, 'giohang', 'KHACHHANG_ID', 'LOAIPHONG_ID');
    }

    public function phieuDatPhong()
    {
        return $this->hasMany(ChiTietPhieuDatPhong::class, 'KHACHHANG_ID');
    }
    protected $hidden = [
        'PASSWORD', 'remember_token',
    ];
    public function getAuthIdentifierName()
    {
        return 'EMAIL';
    }
    public function getAuthPassword()
    {
        return $this->PASSWORD;
    }
}
