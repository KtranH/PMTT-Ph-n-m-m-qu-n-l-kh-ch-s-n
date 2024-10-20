<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class NhanVien extends Model
{
    //
    protected $table = 'nhanvien';

    protected $fillable = [
        'HOTEN', 'GIOITINH', 'NGAYSINH', 'SDT', 'EMAIL', 'PASSWORD', 'CHUCVU', 'ISDELETED'
    ];

    public function phieuNhanPhong()
    {
        return $this->hasMany(PhieuNhanPhong::class);
    }

    public function phieuTraPhong()
    {
        return $this->hasMany(PhieuTraPhong::class);
    }
}
