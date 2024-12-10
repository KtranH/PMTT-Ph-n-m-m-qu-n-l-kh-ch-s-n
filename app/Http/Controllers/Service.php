<?php

namespace App\Http\Controllers;

use App\Models\DichVu;
use Illuminate\Http\Request;

class Service extends Controller
{
    //
    public function AllService()
    {
        $service = DichVu::where('ISDELETED', 0)->paginate(6);
        return view('ServiceController.AllService', compact('service'));
    }
}
