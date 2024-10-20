<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class PhieuTraPhong extends Model
{
    //
    protected $table = 'phieutraphong';

    protected $fillable = [
        'NGAYLAP', 'TONGTIEN', 'NHANVIEN_ID', 'PHIEUNHANPHONG_ID', 'TIENPHAT', 'TINHTRANG'
    ];

    public function nhanVien()
    {
        return $this->belongsTo(NhanVien::class, 'NHANVIEN_ID');
    }

    public function phieuNhanPhong()
    {
        return $this->belongsTo(PhieuNhanPhong::class, 'PHIEUNHANPHONG_ID');
    }

    public function chiTietTraPhong()
    {
        return $this->hasMany(ChiTietTraPhong::class, 'PHIEUTRAPHONG_ID');
    }

    public function danhGia()
    {
        return $this->hasMany(DanhGia::class, 'PHIEUTRAPHONG_ID');
    }
}
