<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class ChiTietPhieuNhanPhong extends Model
{
    //
    protected $table = 'chitietphieunhanphong';

    protected $fillable = [
        'PHIEUNHANPHONG_ID', 'KHACHHANG_ID'
    ];

    public function phieuNhanPhong()
    {
        return $this->belongsTo(PhieuNhanPhong::class, 'PHIEUNHANPHONG_ID');
    }

    public function khachHang()
    {
        return $this->belongsTo(KhachHang::class, 'KHACHHANG_ID');
    }
}
