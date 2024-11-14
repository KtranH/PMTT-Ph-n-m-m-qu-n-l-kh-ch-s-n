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
        return $this->hasMany(DanhGia::class, 'KHACHHANG_ID', 'ID');
    }

    public function gioHang()
    {
        return $this->belongsToMany(LoaiPhong::class, 'giohang', 'KHACHHANG_ID', 'LOAIPHONG_ID')
                    ->withPivot('SOLUONG')
                    ->withPivot('DONGIA');
    }

    public function phieuDatPhong()
    {
        return $this->hasMany(PhieuDatPhong::class, 'KHACHHANG_ID', 'ID');
    }
    public function chiTietPhieuNhanPhong()
    {
        return $this->hasMany(ChiTietPhieuNhanPhong::class, 'KHACHHANG_ID', 'ID');
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
