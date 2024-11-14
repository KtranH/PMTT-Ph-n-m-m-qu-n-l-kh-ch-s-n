<?php

use App\Http\Controllers\Account;
use App\Http\Controllers\Booking;
use App\Http\Controllers\Cart;
use App\Http\Controllers\CategoryRoom;
use App\Http\Controllers\Email;
use App\Http\Controllers\Home;
use App\Http\Controllers\Review;
use App\Http\Controllers\Service;
use App\Http\Controllers\Test;
use App\Http\Middleware\CheckLogin;
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

//Need to login
Route::middleware([CheckLogin::class])->group(function () {
    //Access Home Account
    Route::get('/homeAccount', [Account::class, 'HomeAccount'])->name('homeAccount');

    //Access Page Update Account
    Route::get('/pageUpdateAccount', [Account::class, 'PageUpdateAccount'])->name('pageUpdateAccount');

    //Update password
    Route::patch('/changePassword', [Account::class, 'ChangePassword'])->name('changePassword');

    //Update account
    Route::put('/updateAccount', [Account::class, 'UpdateAccount'])->name('updateAccount');

    //Generate Avatar Img
    Route::get('/generateAvatarImg', [Account::class, 'GenerateAvatarImg'])->name('generateAvatarImg');

    //---------------------------------------------------BOOKING CONTROLLER----------------------------------------------------------//
    
    //List Booking
    Route::get('/listBooking', [Booking::class, 'Booking'])->name('listBooking');

    //Setup Booking
    Route::get('/setupBooking/{id}', [Booking::class, 'SetupBooking'])->name('setupBooking');

    //-------------------------------------------------------------------------------------------------------------------------------//

    //---------------------------------------------------REVIEW CONTROLLER----------------------------------------------------//

    //Review
    Route::get('/review', [Review::class, 'Review'])->name('review');
    //------------------------------------------------------------------------------------------------------------------------//


    //---------------------------------------------------CART CONTROLLER---------------------------------------------------//

    //Cart
    Route::get('/cart', [Cart::class, 'Cart'])->name('cart');

    //Add Cart
    Route::post('/addCart', [Cart::class, 'AddCart'])->name('addCart');

    //Delete Cart
    Route::delete('/deleteCart', [Cart::class, 'DeleteCart'])->name('deleteCart');

    //Delete All Cart
    Route::delete('/deleteAllCart', [Cart::class, 'DeleteAllCart'])->name('deleteAllCart');

    //--------------------------------------------------------------------------------------------------------------------//
});

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

//Category Room Price High To Low
Route::get('/cateRoom_PriceHighToLow', [CategoryRoom::class, 'CateRoom_PriceHighToLow'])->name('CateRoom_PriceHighToLow');

//Category Room Price Low To High
Route::get('/cateRoom_PriceLowToHigh', [CategoryRoom::class, 'CateRoom_PriceLowToHigh'])->name('CateRoom_PriceLowToHigh');

//Overview Category Room
Route::get('/overviewCateRoom/{id}', [CategoryRoom::class, 'Overview_CateRoom'])->name('Overview_CateRoom');
//-----------------------------------------------------------------------------------------------------------------------------//

//---------------------------------------------------SERVICE CONTROLLER---------------------------------------------------//

//All Service
Route::get('/allService', [Service::class, 'AllService'])->name('AllService');
//------------------------------------------------------------------------------------------------------------------------//
//---------------------------------------------------TEST CONTROLLER---------------------------------------------------//

//Test img
Route::get('/testImg', [Test::class, 'TestImg'])->name('TestImg');

//---------------------------------------------------------------------------------------------------------------------//

//---------------------------------------------------OTHER---------------------------------------------------//

//Contact Page
Route::view('/Other/Contact', 'Other.Contact')->name('Contact');

//About Page
Route::view('/Other/Information', 'Other.Information')->name('Information');

//-----------------------------------------------------------------------------------------------------------//

