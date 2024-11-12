<?php

namespace App\Providers;

use App\Models\KhachHang;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\View;
use Illuminate\Support\ServiceProvider;

class AppServiceProvider extends ServiceProvider
{
    /**
     * Register any application services.
     */
    public function register(): void
    {
        //
    }

    /**
     * Bootstrap any application services.
     */
    public function boot(): void
    {
        view()->composer('Header', function ($view) {
            if (Auth::check()) {
                $user = KhachHang::find(Auth::user()->ID);
                if ($user) {
                    $view->with('countCart', $user->gioHang()->count());
                }
            } else {
                $view->with('countCart', 0);
            }
        });
    }
}
