<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Foundation\Auth\User as Authenticatable;
use Illuminate\Notifications\Notifiable;

class KhachHang extends Authenticatable
{
    //
    use HasFactory, Notifiable;
    protected $table = 'khachhang';
    protected $fillable = [
        'ID', 'HOTEN', 'GIOITINH', 'NGAYSINH', 'SDT', 'DIEMTINNHIEM',
        'AVATAR', 'CCCD', 'EMAIL', 'PASSWORD', 'ISDELETED', 'remember_token'
    ];
    
    public $timestamps = false;
    protected $primaryKey = 'ID';

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
    public function getAuthPassword()
    {
        return $this->PASSWORD; 
    }
    public function username()
    {
        return 'EMAIL'; 
    }
}
