<?php

namespace App\Http\Controllers;

use App\Models\KhachHang;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use RealRashid\SweetAlert\Facades\Alert;

class Cart extends Controller
{
    //
    public function Cart()
    {   
        $user = KhachHang::find(Auth::user()->ID);
        $selectCart = $user->gioHang()->get();
        return view('CartController.Cart', compact('selectCart'));
    }
    public function AddCart(Request $request)
    {
        $user = KhachHang::find(Auth::user()->ID);
        if($user->gioHang()->wherePivot('LOAIPHONG_ID', $request->roomID)->exists()) {
            $currentItem = $user->gioHang()
                ->wherePivot('LOAIPHONG_ID', $request->roomID)
                ->first();
            
            $user->gioHang()->updateExistingPivot($request->roomID, [
                'SOLUONG' => $currentItem->pivot->SOLUONG + 1
            ]);
        }
        else
        {
            $user->gioHang()->attach($request->roomID);
        }
        $countCart = $user->gioHang()->count();
        return response()->json(['success' => true, 'countCart' => $countCart]);
    }
    public function DeleteCart(Request $request)
    {
        $user = KhachHang::find(Auth::user()->ID);
        $user->gioHang()->detach($request->cartID);
        $countCart = $user->gioHang()->count();
        $sumCart = $user->gioHang()->sum('GIATHUE');
        return response()->json(['success' => true, 'countCart' => $countCart , 'sumCart' => $sumCart]);
    }
    public function DeleteAllCart()
    {
        $user = KhachHang::find(Auth::user()->ID);
        $user->gioHang()->detach();
        $countCart = $user->gioHang()->count();
        return response()->json(['success' => true, 'countCart' => $countCart]);
    }
}
