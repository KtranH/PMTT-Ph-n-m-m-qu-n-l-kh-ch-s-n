<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class ChiTietPhieuDatPhong extends Model
{
    //
    protected $table = 'chitietphieunhanphong';

    protected $fillable = [
        'PHIEUDATPHONG_ID', 'KHACHHANG_ID'
    ];

    public function phieuDatPhong()
    {
        return $this->belongsTo(PhieuDatPhong::class, 'PHIEUDATPHONG_ID');
    }

    public function khachHang()
    {
        return $this->belongsTo(KhachHang::class, 'KHACHHANG_ID');
    }
}
