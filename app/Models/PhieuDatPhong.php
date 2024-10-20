<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class PhieuDatPhong extends Model
{
    //
    protected $table = 'phieudatphong';

    protected $fillable = [
        'LOAIPHONG_ID', 'NGAYNHANPHONG', 'NGAYTRAPHONGDUKIEN', 'THANHTOAN', 'TINHTRANG'
    ];

    public function loaiPhong()
    {
        return $this->belongsTo(LoaiPhong::class, 'LOAIPHONG_ID');
    }

    public function chiTietPhieuDatPhong()
    {
        return $this->hasMany(ChiTietPhieuDatPhong::class, 'PHIEUDATPHONG_ID');
    }

    public function phieuNhanPhong()
    {
        return $this->hasOne(PhieuNhanPhong::class, 'PHIEUDATPHONG_ID');
    }
}
