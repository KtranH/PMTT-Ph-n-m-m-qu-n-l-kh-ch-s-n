<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class DichVu extends Model
{
    //
    protected $table = 'dichvu';

    protected $fillable = [
        'TENDICHVU', 'GIA', 'MOTA', 'HINH', 'ISDELETED'
    ];

    public function chiTietTraPhong()
    {
        return $this->hasMany(ChiTietTraPhong::class, 'DICHVU_ID');
    }
}
