<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class PhieuNhanPhong extends Model
{
    //
    protected $table = 'phieunhanphong';

    protected $fillable = [
        'NHANVIEN_ID', 'PHIEUDATPHONG_ID', 'PHONG_ID', 'NGAYTRAPHONG', 'TINHTRANG'
    ];

    public function nhanVien()
    {
        return $this->belongsTo(NhanVien::class, 'NHANVIEN_ID');
    }

    public function phieuDatPhong()
    {
        return $this->belongsTo(PhieuDatPhong::class, 'PHIEUDATPHONG_ID');
    }

    public function phong()
    {
        return $this->belongsTo(Phong::class, 'PHONG_ID');
    }

    public function phieuTraPhong()
    {
        return $this->hasOne(PhieuTraPhong::class, 'PHIEUNHANPHONG_ID');
    }
}
