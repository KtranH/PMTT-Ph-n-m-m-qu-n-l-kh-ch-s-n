<?php

use App\Http\Controllers\Account;
use App\Http\Controllers\Email;
use App\Http\Controllers\Home;
use App\Http\Middleware\CheckResendCodeAuthEmail;
use Illuminate\Support\Facades\Route;


Route::middleware('web')->group(function () {
    //---------------------------------------------------HOME CONTROLLER---------------------------------------------------//
    Route::get('/', [Home::class, 'Home'])->name('Home');
    //---------------------------------------------------------------------------------------------------------------------//

    //---------------------------------------------------ACCOUNT CONTROLLER------------------------------------------------//

    //Login
    Route::get('/login', [Account::class, 'Login'])->name('Login');

    //SignUp
    Route::get('/signup', [Account::class, 'SignUp'])->name('SignUp');

    //Logout
    Route::get('/logout', [Account::class, 'Logout'])->name('Logout');

    //Login by Google
    Route::get('/loginByGoogle', [Account::class, 'loginByGoogle'])->name('loginByGoogle');

    //Call back Google
    Route::get('/callBackGoogle', [Account::class, 'callBackGoogle'])->name('callBackGoogle');

    //New Account
    Route::post('/NewAccount', [Account::class, 'NewAccount'])->name('NewAccount');

    //Type code to auth email
    Route::get('/showauth', [Account::class, 'ShowAuth'])->name('ShowAuth');

    //---------------------------------------------------------------------------------------------------------------------//

    //---------------------------------------------------EMAIL CONTROLLER-------------------------------------------------//

    //Send code to email
    Route::get('/SendCodeAuthToEmail', [Email::class, 'SendCodeAuthToEmail'])->name('SendCodeAuthToEmail');

    //Verify code
    Route::post('/VerifyCode', [Email::class, 'VerifyCode'])->name('VerifyCode');

    //ReSend code
    Route::get('/ReSendCodeAuthToEmail', [Email::class, 'ReSendCodeAuthToEmail'])->name('ReSendCodeAuthToEmail')->middleware(CheckResendCodeAuthEmail::class . ':2,1');
    //---------------------------------------------------------------------------------------------------------------------//
});
