<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class ChiTietTraPhong extends Model
{
    //
    protected $table = 'chitiettraphong';

    protected $fillable = [
        'PHIEUTRAPHONG_ID', 'DICHVU_ID', 'SOLUONG', 'DONGIA'
    ];

    public function phieuTraPhong()
    {
        return $this->belongsTo(PhieuTraPhong::class, 'PHIEUTRAPHONG_ID');
    }

    public function dichVu()
    {
        return $this->belongsTo(DichVu::class, 'DICHVU_ID');
    }
}
