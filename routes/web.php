<?php

use App\Http\Controllers\Account;
use App\Http\Controllers\CategoryRoom;
use App\Http\Controllers\Email;
use App\Http\Controllers\Home;
use App\Http\Controllers\Test;
use App\Http\Middleware\CheckResendCodeAuthEmail;
use Illuminate\Support\Facades\Route;


//---------------------------------------------------HOME CONTROLLER---------------------------------------------------//
Route::get('/', [Home::class, 'Home'])->name('Home');
//---------------------------------------------------------------------------------------------------------------------//

//---------------------------------------------------ACCOUNT CONTROLLER------------------------------------------------//

//Login
Route::get('/login', [Account::class, 'Login'])->name('Login');

//Access Login
Route::get('/accessLogin', [Account::class, 'AccessLogin'])->name('AccessLogin');

//SignUp
Route::get('/signup', [Account::class, 'SignUp'])->name('SignUp');

//Logout
Route::get('/logout', [Account::class, 'Logout'])->name('Logout');

//Login by Google
Route::get('/loginByGoogle', [Account::class, 'loginByGoogle'])->name('loginByGoogle');

//Call back Google
Route::get('/callBackGoogle', [Account::class, 'callBackGoogle'])->name('callBackGoogle');

//New Account
Route::post('/newAccount', [Account::class, 'NewAccount'])->name('NewAccount');

//Type code to auth email
Route::get('/showauth', [Account::class, 'ShowAuth'])->name('ShowAuth');

//Forget Password
Route::get('/forgetPassword', [Account::class, 'ForgetPassword'])->name('ForgetPassword');

//Auth Email To Change Password
Route::get('/authEmailToChangePassword', [Account::class, 'AuthEmailToChangePassword'])->name('AuthEmailToChangePassword');

//Show Auth Change Password
Route::get('/showAuthChangePassword', [Account::class, 'ShowAuthChangePassword'])->name('ShowAuthChangePassword');

//---------------------------------------------------------------------------------------------------------------------//

//---------------------------------------------------EMAIL CONTROLLER-------------------------------------------------//

//Send code to email
Route::get('/sendCodeAuthToEmail', [Email::class, 'SendCodeAuthToEmail'])->name('SendCodeAuthToEmail');

//Verify code
Route::get('/verifyCode', [Email::class, 'VerifyCode'])->name('VerifyCode');

//Verify code change password
Route::patch('/verifyCodeChangePassword', [Email::class, 'VerifyCodeChangePassword'])->name('VerifyCodeChangePassword');

//ReSend code
Route::get('/reSendCodeAuthToEmail', [Email::class, 'ReSendCodeAuthToEmail'])->name('ReSendCodeAuthToEmail')->middleware(CheckResendCodeAuthEmail::class . ':2,1');
//---------------------------------------------------------------------------------------------------------------------//

//---------------------------------------------------CATEGORY ROOM CONTROLLER---------------------------------------------------//

//All Category Room
Route::get('/allCategoryRoom', [CategoryRoom::class, 'AllCateRoom'])->name('AllCategoryRoom');

//Category Room has the accommodate of 1
Route::get('/cateRoom_1', [CategoryRoom::class, 'CateRoom_1'])->name('CateRoom_1');

//Category Room has the accommodate of 2
Route::get('/cateRoom_2', [CategoryRoom::class, 'CateRoom_2'])->name('CateRoom_2');

//Category Room has the accommodate of 4
Route::get('/cateRoom_4', [CategoryRoom::class, 'CateRoom_4'])->name('CateRoom_4');
//-----------------------------------------------------------------------------------------------------------------------------//

//---------------------------------------------------TEST CONTROLLER---------------------------------------------------//

//Test img
Route::get('/testImg', [Test::class, 'TestImg'])->name('TestImg');

//---------------------------------------------------------------------------------------------------------------------//

