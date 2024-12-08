@extends('Layout')
@section('body')
    <title>GTX - Thanh toán</title>

    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.3.0/uicons-bold-rounded/css/uicons-bold-rounded.css'>
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.3.0/uicons-regular-rounded/css/uicons-regular-rounded.css'>
    <main id="main" class="main">
        <div class="pagetitle">
            <h1>Thanh toán</h1>
            <nav>
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="{{ route('Home') }}">GTX</a></li>
                    <li class="breadcrumb-item active">Thanh toán đặt phòng</li>
                </ol>
            </nav>
        </div><!-- End Page Title -->

        <section class="section dashboard">
            <div class="row">

                <!-- Left side columns -->
                <div class="col-lg-12">
                    <div class="row">

                        <div style="display:flex;">
                            <div style="width:80%">
                                <div class="col-12" data-aos="fade-right">
                                    <div class="card" style="border-radius:20px">
                                        <div class="card-body">
                                            <h5 class="card-title"
                                                style="font-family: 'Montserrat', sans-serif;
                                        font-optical-sizing: auto;
                                        font-weight: 600;
                                        font-style: normal;" data-aos="fade-right" data-aos-delay="200">
                                                Phòng<span>/Danh sách phòng</span></h5>
                                            <div class="row bg-white"
                                                style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-between;
                                        ">

                                                <table class="table table-borderless" data-aos="fade-right" data-aos-delay="400">
                                                    <thead>
                                                        <tr>
                                                            <th scope="col">Hình ảnh</th>
                                                            <th scope="col">Tên loại</th>
                                                            <th scope="col" style="width:25%">Nội thất</th>
                                                            <th scope="col">Sức chứa</th>
                                                            <th scope="col">Giá thuê</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <th scope="row"><img
                                                                    src="{{ $cateRoom->hinhLoaiPhong[0]->HINH }}"
                                                                    style="width:50px; height:50px; border-radius:10px; box-shadow: rgba(149, 157, 165, 0.2) 0px 8px 24px; object-fit: cover;"
                                                                    alt=""></th>
                                                            <td>{{ $cateRoom->TENLOAIPHONG }}.</td>
                                                            <td>{{ $cateRoom->NOITHAT }}.</td>
                                                            <td>{{ $cateRoom->SUCCHUA }}</td>
                                                            <td>{{ number_format($cateRoom->GIATHUE) }} VNĐ</td>
                                                        </tr>
                                                    </tbody>
                                                </table>

                                            </div>
                                        </div>

                                    </div>
                                </div><!-- End Recent Sales -->
                                <div class="col-12" data-aos="fade-up">
                                    <div class="card" style="border-radius:20px">
                                        <div class="card-body">
                                            <h5 class="card-title"
                                                style="font-family: 'Montserrat', sans-serif;
                                        font-optical-sizing: auto;
                                        font-weight: 600;
                                        font-style: normal;" data-aos="fade-up" data-aos-delay="200">
                                                Phương thức thanh toán<span>/Lựa chọn thanh toán</span>
                                            </h5>
                                            <div class="row bg-white"
                                                style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-between;
                                        ">

                                                <div class="plan" data-aos="fade-up" data-aos-delay="400">
                                                    <div class="inner">
                                                        <span class="pricing">
                                                            <span id="review_price">
                                                                ...<small>/ VNĐ</small>
                                                            </span>
                                                        </span>
                                                        <p class="title">Thanh toán chuyển khoản</p>
                                                        <p class="info">Vui lòng chuyển vào tài khoản sau, chúng tôi sẽ
                                                            xác
                                                            nhận sau 2 giờ chuyển khoản.</p>
                                                        <ul class="features">
                                                            <li>
                                                                <span class="icon">
                                                                    <svg height="24" width="24" viewBox="0 0 24 24"
                                                                        xmlns="http://www.w3.org/2000/svg">
                                                                        <path d="M0 0h24v24H0z" fill="none"></path>
                                                                        <path fill="currentColor"
                                                                            d="M10 15.172l9.192-9.193 1.415 1.414L10 18l-6.364-6.364 1.414-1.414z">
                                                                        </path>
                                                                    </svg>
                                                                </span>
                                                                <span><strong>Ngân hàng:</strong> ABCDF</span>
                                                            </li>
                                                            <li>
                                                                <span class="icon">
                                                                    <svg height="24" width="24" viewBox="0 0 24 24"
                                                                        xmlns="http://www.w3.org/2000/svg">
                                                                        <path d="M0 0h24v24H0z" fill="none"></path>
                                                                        <path fill="currentColor"
                                                                            d="M10 15.172l9.192-9.193 1.415 1.414L10 18l-6.364-6.364 1.414-1.414z">
                                                                        </path>
                                                                    </svg>
                                                                </span>
                                                                <span>Số tài khoản: <strong>0999xxx7777</strong></span>
                                                            </li>
                                                            <li>
                                                                <span class="icon">
                                                                    <svg height="24" width="24" viewBox="0 0 24 24"
                                                                        xmlns="http://www.w3.org/2000/svg">
                                                                        <path d="M0 0h24v24H0z" fill="none"></path>
                                                                        <path fill="currentColor"
                                                                            d="M10 15.172l9.192-9.193 1.415 1.414L10 18l-6.364-6.364 1.414-1.414z">
                                                                        </path>
                                                                    </svg>
                                                                </span>
                                                                @php
                                                                    $currentDate = date('Ymd');
                                                                    $currentTime = date('His');
                                                                @endphp
                                                                <span>Nội dung:
                                                                    <strong>
                                                                        {{ Auth::user()->EMAIL }}_{{ $currentDate }}_{{ $currentTime }}
                                                                    </strong>
                                                                </span>
                                                            </li>
                                                            <li>
                                                                <span class="icon">
                                                                    <svg height="24" width="24" viewBox="0 0 24 24"
                                                                        xmlns="http://www.w3.org/2000/svg">
                                                                        <path d="M0 0h24v24H0z" fill="none"></path>
                                                                        <path fill="currentColor"
                                                                            d="M10 15.172l9.192-9.193 1.415 1.414L10 18l-6.364-6.364 1.414-1.414z">
                                                                        </path>
                                                                    </svg>
                                                                </span>
                                                                <span>Chuyển khoản:
                                                                    <strong id="review_content_price">
                                                                        ...
                                                                    </strong>
                                                                    <span id="payment" hidden></span>
                                                                </span>
                                                            </li>
                                                        </ul>
                                                        <div class="action">
                                                            <a id="pay" class="button confirm-button" href="">
                                                                Xác nhận
                                                            </a>
                                                        </div>
                                                        <script>
                                                            $(document).ready(function() {
                                                                $('.confirm-button').click(function(e) {
                                                                    e.preventDefault();
                                                                    var review_content_price = $('#review_content_price').text();
                                                                    if(review_content_price.includes('...')) {
                                                                        Swal.fire({
                                                                            icon: 'warning',
                                                                            title: 'Cảnh báo',
                                                                            text: 'Vui lòng xác nhận ngày nhận phòng và ngày trả phòng!',
                                                                            showConfirmButton: false,
                                                                            showCancelButton: true,
                                                                            cancelButtonText: 'Đồng ý',
                                                                            cancelButtonColor: '#d33',
                                                                        })
                                                                    }
                                                                    else
                                                                    {
                                                                        $(this).disabled = true;
                                                                        $('#calculate-days').disabled = true;
                                                                        $(window).on('beforeunload', function(event) {
                                                                            event.preventDefault();
                                                                            return '';
                                                                        })
                                                                        var checkIn = $('#dater').val();
                                                                        var checkOut = $('#datep').val();
                                                                        var roomID = {{ $cateRoom->ID}};
                                                                        var payment = $('#payment').text();

                                                                        Swal.fire({
                                                                            title: 'Đang xử lý...',
                                                                            html: '<div class="relative flex justify-center items-center"> <div class="absolute animate-ping w-8 h-8 rounded-full bg-blue-500 opacity-75"></div> <div class="relative w-8 h-8 rounded-full bg-blue-600 animate-pulse flex items-center justify-center"> <svg class="w-5 h-5 text-white animate-spin" fill="none" viewBox="0 0 24 24"> <circle class="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" stroke-width="4"></circle> <path class="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"></path> </svg> </div> </div>',
                                                                            showConfirmButton: false,
                                                                            allowOutsideClick: false,
                                                                            didOpen: () => {
                                                                                Swal.showLoading();
                                                                            }
                                                                        });

                                                                        $.ajax({
                                                                            url: "{{ route('confirmBooking') }}",
                                                                            type: "POST",
                                                                            data: {
                                                                                _token: "{{ csrf_token() }}",
                                                                                checkIn: checkIn,
                                                                                checkOut: checkOut,
                                                                                roomID: roomID,
                                                                                payment: payment
                                                                            },
                                                                            success: function(response) {
                                                                                if (response.success) {
                                                                                    window.location.href = "{{ route('listBooking') }}";
                                                                                }
                                                                                else
                                                                                {
                                                                                    Swal.fire({
                                                                                        icon: 'error',
                                                                                        title: 'Lỗi',
                                                                                        text: response.message,
                                                                                        showConfirmButton: false,
                                                                                        showCancelButton: true,
                                                                                        cancelButtonText: 'Đồng ý',
                                                                                        cancelButtonColor: '#d33',
                                                                                    });
                                                                                }
                                                                            },
                                                                            error: function(xhr, status, error) {
                                                                                alert(error);
                                                                            }
                                                                        });
                                                                    }
                                                                })
                                                            })
                                                        </script>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div><!-- End Recent Sales -->
                            </div>

                            <div style="width:40%; margin-left:30px">
                                <div class="col-12" data-aos="fade-left">
                                    <div class="card" style="border-radius:20px">
                                        <div class="card-body">
                                            <h5 class="card-title"
                                                style="font-family: 'Montserrat', sans-serif;
                                        font-optical-sizing: auto;
                                        font-weight: 600;
                                        font-style: normal;" data-aos="fade-left" data-aos-delay="200">
                                                Chú ý<span>/Lưu ý khi đặt phòng</span></h5>
                                            <div class="row bg-white"
                                                style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-between;" data-aos="fade-left" data-aos-delay="400">
                                                <p><i class="fa-solid fa-bell-concierge" style="color: #74C0FC;"></i> <span
                                                        style="font-weight:bold">Dịch vụ</span>: Đối với các dịch vụ bạn
                                                    phải đăng ký tại quầy.</li>
                                                </p>
                                                <p><i class="fa-solid fa-door-open" style="color: #74C0FC;"></i> <span
                                                        style="font-weight:bold">Nhận và trả phòng</span>: Vui lòng tới nhận phòng sau 14 giờ và trả phòng trước 12 giờ.</li>
                                                </p>
                                                <p style="color:red"><i class="fa-solid fa-ban" style="color: #74C0FC;"></i>
                                                    <span style="font-weight:bold">Hủy phòng: <br><br></span>Bạn chỉ có thể
                                                    hủy phòng bằng việc tới <span style="font-weight:bold">xác nhận</span>
                                                    tại nhân viên khách sạn của chúng tôi. <br><br>Ngoài ra khi hủy phòng bạn
                                                    sẽ<span style="font-weight:bold"> bị trừ 20 điểm tín nhiệm</span>.
                                                    Điểm tín nhiệm dưới 20 bạn không thể đặt phòng và cũng như bị khóa
                                                    tài khoản.
                                                </p>
                                            </div>
                                        </div>

                                    </div>

                                    <div class="card" style="border-radius:20px" data-aos="fade-up-left">
                                        <div class="card-body">
                                            <h5 class="card-title"
                                                style="font-family: 'Montserrat', sans-serif;
                                                font-optical-sizing: auto;
                                                font-weight: 600;
                                                font-style: normal;" data-aos="fade-up-left" data-aos-delay="200">
                                                Lựa chọn ngày<span>/nhận và trả</span></h5>
                                            <div class="row bg-white"
                                                style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-between;" data-aos="fade-up-left" data-aos-delay="400">
                                                <div class="row mb-3">
                                                    <label for="dater" class="col-sm-2 col-form-label text-end" title="Ngày nhận phòng"><i class="fa-solid fa-door-closed"></i></label>
                                                    <div class="col-sm-9">
                                                        <input type="date" class="form-control" id="dater" name="DateR" value="">
                                                    </div>
                                                </div>
                                            
                                                <div class="row mb-3">
                                                    <label for="datep" class="col-sm-2 col-form-label text-end" title="Ngày trả phòng"><i class="fa-solid fa-door-open"></i></label>
                                                    <div class="col-sm-9">
                                                        <input type="date" class="form-control" id="datep" name="DateP" value="">
                                                    </div>
                                                </div>
                                            
                                                <div class="row">
                                                    <div class="col-12">
                                                        <button type="button" id="calculate-days" 
                                                            class="btn w-100" 
                                                            style="border-radius:50px; background: linear-gradient(90deg, #74C0FC, #4A90E2); color: white; font-weight: bold; font-size: 18px; padding: 10px 20px; box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;">
                                                            <i class="fi fi-rr-file-edit"></i> Đồng ý
                                                        </button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <script>
                                        $(document).ready(function () {
                                            const today = new Date();
                                            today.setDate(today.getDate() + 1);
                                            const tomorrow = new Date(today);
                                            tomorrow.setDate(today.getDate() + 1);

                                            const formatDate = (date) => date.toISOString().split('T')[0];

                                            const roomPrice = {{ $cateRoom->GIATHUE }}; 

                                            $('#dater').val(formatDate(today));
                                            $('#datep').val(formatDate(tomorrow));

                                            $('#dater').attr('min', formatDate(today));

                                            $('#dater').on('change', function () {
                                                const checkInDate = $(this).val();
                                                $('#datep').attr('min', checkInDate); 
                                            });

                                            $('#datep').on('change', function () {
                                                const checkInDate = new Date($('#dater').val());
                                                const checkOutDate = new Date($(this).val());

                                                if (checkOutDate <= checkInDate) {
                                                    Swal.fire({
                                                        icon: 'warning',
                                                        iconColor: 'white',
                                                        title: 'Cảnh báo',
                                                        text: 'Ngày trả phòng phải lớn hơn ngày nhận phòng.',
                                                        color: 'white',
                                                        showConfirmButton: false,
                                                        timer: 3000,
                                                        background: '#F0D56E'
                                                    })
                                                    $(this).val(formatDate(tomorrow)); 
                                                }
                                            });

                                            $('#calculate-days').on('click', function () {
                                                const checkInDate = new Date($('#dater').val());
                                                const checkOutDate = new Date($('#datep').val());

                                                if (!checkInDate || !checkOutDate) {
                                                    alert('Vui lòng chọn ngày hợp lệ.');
                                                    return;
                                                }

                                                if(checkOutDate < checkInDate) {
                                                    alert('Vui lòng chọn ngày hợp lệ.');
                                                    return;
                                                }

                                                const timeDiff = Math.abs(checkOutDate - checkInDate);
                                                const daysRented = Math.ceil(timeDiff / (1000 * 60 * 60 * 24));
                                                const totalPrice = daysRented * roomPrice;

                                                $('#days-rented').text(daysRented);
                                                $('#total-price').text(new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(totalPrice));
                                                $('#review_price').text(new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(totalPrice));
                                                $('#payment').text(totalPrice);
                                                $('#review_content_price').text(new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(totalPrice));
                                            });
                                        });

                                    </script>
                                    <div class="card" style="border-radius:20px">
                                        <div class="card-body">
                                            <h5 class="card-title"
                                                style="font-family: 'Montserrat', sans-serif;
                                        font-optical-sizing: auto;
                                        font-weight: 600;
                                        font-style: normal;">
                                                Tổng tiền<span>/Tạm tính</span></h5>
                                            <div class="row bg-white"
                                                style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-between;
                                        ">

                                                <p id="result" class="mt-4" style="display:flex; justify-content: space-between; margin-bottom:30px; font-size: 18px; font-weight: bold;">
                                                    <span style="font-weight:bold">Bạn sẽ thuê trong</span><span id="days-rented">...</span> ngày.
                                                </p>
                                                <p style="display:flex; justify-content: space-between; font-size: 18px;">
                                                    <span style="font-weight:bold;">Tổng tiền:</span>
                                                    <span id="total-price" style="margin-top:-10px; color: red; font-size: 25px; font-weight: bold;">...</span>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div><!-- End Recent Sales -->
                            </div>
                        </div>
                        <!-- End Top Selling -->
                    </div>
                </div><!-- End Left side columns -->
                <!-- Right side columns -->
                <!-- End Right side columns -->
            </div>
        </section>
    </main><!-- End #main -->
@endsection
