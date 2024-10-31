<?php

namespace App\Http\Controllers;

use App\Models\DichVu;
use Illuminate\Http\Request;

class Service extends Controller
{
    //
    public function AllService()
    {
        $service = DichVu::paginate(6);
        return view('ServiceController.AllService', compact('service'));
    }
}
