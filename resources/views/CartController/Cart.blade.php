@extends('Layout')
@section('body')

@php
    $total_quantity = 0;
@endphp

<title>GTX - Giỏ hàng của bạn</title>

<link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.3.0/uicons-bold-rounded/css/uicons-bold-rounded.css'>
<link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.3.0/uicons-regular-rounded/css/uicons-regular-rounded.css'>

<main id="main" class="main">

    <div class="pagetitle">
        <h1>Giỏ hàng</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">GTX</a></li>
                <li class="breadcrumb-item active">Giỏ hàng của bạn</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->

    <section class="section dashboard" data-aos="fade-up">
        <div class="row">
          <!-- Left side columns -->
          <div class="col-lg-12">
            <div class="row">
                    <!-- Reports -->
                    <div class="col-12">
                        <div class="card" style="border-radius:20px">
                            <div class="card-body">
                                <h5 class="card-title" style="font-family: 'Montserrat', sans-serif;
                                font-optical-sizing: auto;
                                font-weight: 600;
                                font-style: normal;" data-aos="fade-right" data-aos-delay="200">Giỏ hàng<span>/Tất cả loại phòng</span></h5>
                                <div class="row bg-white" style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-between;
                                ">
                                   @if (!$selectCart->isEmpty())
                                    <table class="table table-borderless datatable" data-aos="fade-up" data-aos-delay="500">
                                        <thead>
                                        <tr>
                                            <th scope="col">Tên loại</th>
                                            <th scope="col">Sức chứa</th>
                                            <th scope="col">Giá thuê</th>
                                            <th scope="col">Tiện ích</th>
                                            <th scope="col">Số lượng</th>
                                            <th scope="col">Chức năng</th>
                                            <th scope="col">Đặt phòng</th>
                                        </tr>
                                        </thead>
                                        <tbody>
                                            @foreach ($selectCart as $item)
                                                <tr>
                                                    <th scope="row"><a href="{{ route("Overview_CateRoom", ['id' => $item->ID]) }}" class="text-primary">{{ $item->TENLOAIPHONG }}</a></th>
                                                    <td>{{ $item->SUCCHUA }}</td>
                                                    <td>{{ number_format($item->GIATHUE) }} VNĐ</td>
                                                    <td>{{ $item->TIENICH }}</td>
                                                    <td>{{ $item->pivot->SOLUONG }}</td>
                                                    <td><a href="" class="btn btn-info add_cart" style="border-radius:20%;margin-right:20px;color:white;background-color:#74C0FC" data-cart-id="{{ $item->ID }}"><i class="fa-solid fa-plus"></i></a>
                                                        <a class="btn btn-danger delete_cart" href="" style="border-radius:20%; box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;" data-cart-id="{{ $item->ID }}"><i class="fi fi-br-cross"></i></a>
                                                    </td>
                                                    <td><a href="{{ route("setupBookingManyRooms", ['id' => $item->ID]) }}" class="btn btn-success"><i class="fa-solid fa-check"></i></a></td>
                                                    @php
                                                        $total_quantity += $item->pivot->SOLUONG;
                                                    @endphp
                                                </tr>              
                                            @endforeach
                                        </tbody>
                                    </table>        
                                    <div style="width:100%;display:flex; justify-content: flex-end;" data-aos="fade-up" data-aos-delay="600">
                                        <h5 style="margin-right:20px">
                                            Tổng tiền trong giỏ: <span id="total-price" style="font-weight:bold;color:#fb5032">{{ number_format($selectCart->sum(function($item) { return $item->pivot->DONGIA; })) }} VNĐ</span>
                                        </h5>                                       
                                        <a class="button_over_khoi add_all_cart" href="" style="outline: 0;
                                        border: 0;
                                        display:flex;
                                        justify-content: center;
                                        align-items: center;
                                        background: none;
                                        border-radius: 10px;
                                        background-color: #74C0FC;
                                        box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
                                        padding: 15px;
                                        margin-top:-20px;
                                        color: white;
                                        width: 130px;
                                        font-family: 'Montserrat', sans-serif;
                                        font-optical-sizing: auto;
                                        font-weight: 600;
                                        font-style: normal;
                                        margin-right: 5px;
                                        transition: all 0.3s ease;" href="#">Xác nhận<i class="fa-solid fa-hotel" style="margin-left:5px"></i></a>
                                        <a class="button_over_khoi delete_all_cart" href="" style="outline: 0;
                                        border: 0;
                                        display:flex;
                                        justify-content: center;
                                        align-items: center;
                                        background: none;
                                        background-color: #CC0F32;
                                        border-radius: 10px;
                                        box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
                                        padding: 15px;
                                        margin-top:-20px;
                                        color: white;
                                        width: 130px;
                                        font-family: 'Montserrat', sans-serif;
                                        font-optical-sizing: auto;
                                        font-weight: 600;
                                        font-style: normal;
                                        margin-right: 5px;
                                        transition: all 0.3s ease;" href="#">Xóa <i class="fa-solid fa-trash" style="margin-left:5px"></i></a>
                                    </div>
                                    <script>
                                        $(document).ready(function() {
                                            $('.add_all_cart').click(function(e) {
                                                e.preventDefault();
                                                Swal.fire({
                                                    icon: 'warning',
                                                    title: 'Cảnh báo',
                                                    text: 'Bạn muốn đặt tất cả các phòng không?',
                                                    showCancelButton: true,
                                                    confirmButtonColor: '#3085d6',
                                                    cancelButtonColor: '#d33',
                                                    confirmButtonText: 'Đặt',
                                                    cancelButtonText: 'Hủy',
                                                }).then((result) => {
                                                        if (result.isConfirmed) {
                                                            $(this).disabled = true;
                                                            window.location.href = '{{ route("setupBookingManyRooms") }}';
                                                        }
                                                })
                                            })
                                            $('.delete_all_cart').click(function(e) {
                                                e.preventDefault();
                                                Swal.fire({
                                                    icon: 'warning',
                                                    title: 'Cảnh báo',
                                                    text: 'Bạn có muốn xóa tất cả không?',
                                                    showCancelButton: true,
                                                    confirmButtonColor: '#3085d6',
                                                    cancelButtonColor: '#d33',
                                                    confirmButtonText: 'Xóa',
                                                    cancelButtonText: 'Hủy',
                                                }).then((result) => {
                                                        if (result.isConfirmed) {
                                                            $.ajax({
                                                            url: '{{ route("deleteAllCart") }}',
                                                            type: 'DELETE',
                                                            data: {
                                                                _token: '{{ csrf_token() }}'
                                                            },
                                                            success: function(response) {
                                                                if (response.success) {
                                                                    location.reload();
                                                                    Swal.fire({
                                                                        icon: 'success',
                                                                        iconColor: 'white',
                                                                        title: 'Làm mới thành công',
                                                                        color: 'white',
                                                                        toast: true,
                                                                        position: 'bottom-left',
                                                                        showConfirmButton: false,
                                                                        timer: 3000,
                                                                        background: '#74C0FC'
                                                                    })
                                                                }
                                                            },
                                                            error: function(xhr, status, error) {
                                                                alert(error);
                                                            }
                                                        })
                                                    }
                                                })
                                            });
                                            let lastTimeDeleteCart = 0;
                                            $('.delete_cart').click(function(e) {
                                                e.preventDefault();
                                                const currentTime = new Date().getTime();
                                                if (currentTime - lastTimeDeleteCart < 5000) {
                                                    Swal.fire({
                                                        icon: 'warning',
                                                        iconColor: 'white',
                                                        title: 'Vui lòng đợi 5 giây trước khi thêm tiếp',
                                                        color: 'white',
                                                        toast: true,
                                                        position: 'bottom-left',
                                                        showConfirmButton: false,
                                                        timer: 3000,
                                                        background: '#F0D56E'
                                                    });
                                                    return;
                                                }

                                                lastTimeDeleteCart = currentTime;

                                                Swal.fire({
                                                    icon: 'warning',
                                                    title: 'Cảnh báo',
                                                    text: 'Bạn có muốn xóa lựa chọn này?',
                                                    showCancelButton: true,
                                                    confirmButtonColor: '#3085d6',
                                                    cancelButtonColor: '#d33',
                                                    confirmButtonText: 'Xóa',
                                                    cancelButtonText: 'Hủy',
                                                }).then((result) => {
                                                    if (result.isConfirmed) {
                                                        var roomID = $(this).data('cart-id');
                                                        var row = $(this).closest('tr');  
                                                        var quantityCell = $(this).closest('tr').find('td.green');

                                                            $.ajax({
                                                                url: '{{ route("deleteCart") }}',
                                                                type: 'DELETE',
                                                                data: {
                                                                    roomID: roomID,
                                                                    _token: '{{ csrf_token() }}'
                                                                },
                                                                success: function(response) {
                                                                    if (response.success) {
                                                                        if(response.delete)
                                                                        {
                                                                            console.log("check");
                                                                            $('#cart-count').text(response.countCart);
                                                                            $('#cart-icon').addClass('cart-added');
                                                                            setTimeout(function() {
                                                                                $('#cart-icon').removeClass('cart-added');
                                                                            }, 1000);

                                                                            $('#total-price').text(response.sumCart.toLocaleString('vi-VN') + " VNĐ");

                                                                            row.remove();

                                                                            Swal.fire({
                                                                                icon: 'success',
                                                                                iconColor: 'white',
                                                                                title: 'Đã xóa lựa chọn',
                                                                                color: 'white',
                                                                                toast: true,
                                                                                position: 'bottom-left',
                                                                                showConfirmButton: false,
                                                                                timer: 3000,
                                                                                background: '#73D06F'
                                                                            }) 
                                                                        }
                                                                        else
                                                                        {
                                                                            $('#cart-count').text(response.countCart);
                                                                            $('#cart-icon').addClass('cart-added');
                                                                            setTimeout(function() {
                                                                                $('#cart-icon').removeClass('cart-added');
                                                                            }, 1000);

                                                                            $('#total-price').text(response.sumCart.toLocaleString('vi-VN') + " VNĐ");

                                                                            quantityCell.slideUp(200, function() {
                                                                                quantityCell.text(response.quantity); 
                                                                                quantityCell.slideDown(200); 
                                                                            });

                                                                            Swal.fire({
                                                                                icon: 'success',
                                                                                iconColor: 'white',
                                                                                title: 'Đã xóa lựa chọn',
                                                                                color: 'white',
                                                                                toast: true,
                                                                                position: 'bottom-left',
                                                                                showConfirmButton: false,
                                                                                timer: 3000,
                                                                                background: '#73D06F'
                                                                            }) 
                                                                        }
                                                                    }
                                                                },
                                                                error: function(xhr, status, error) {
                                                                    alert(error);
                                                                }
                                                            })
                                                        }
                                                    })
                                            });
                                            let lastTimeAddCart = 0;
                                            $('.add_cart').click(function (e) {
                                                e.preventDefault();
                                                const currentTime = new Date().getTime();
                                                if (currentTime - lastTimeAddCart < 5000) {
                                                    Swal.fire({
                                                        icon: 'warning',
                                                        iconColor: 'white',
                                                        title: 'Vui lòng đợi 5 giây trước khi thêm tiếp',
                                                        color: 'white',
                                                        toast: true,
                                                        position: 'bottom-left',
                                                        showConfirmButton: false,
                                                        timer: 3000,
                                                        background: '#F0D56E'
                                                    });
                                                    return;
                                                }

                                                lastTimeAddCart = currentTime;

                                                var roomID = $(this).data('cart-id');
                                                var quantityCell = $(this).closest('tr').find('td.green');
                                                var quantityRoom = {{ $total_quantity }};
                                                console.log(quantityRoom);
                                                if(quantityRoom >= 5)
                                                {
                                                    Swal.fire({
                                                        icon: 'error',
                                                        title: 'Cảnh báo',
                                                        text: 'Bạn chỉ có thể đặt trước tối đa 5 phòng',
                                                        showCancelButton: true,
                                                        showConfirmButton: false,
                                                        cancelButtonText: 'Đồng ý',
                                                        cancelButtonColor: '#d33',
                                                    });
                                                    return;
                                                }

                                                $.ajax({
                                                    url: '{{ route("addCart") }}',
                                                    type: 'POST',
                                                    data: {
                                                        roomID: roomID,
                                                        _token: '{{ csrf_token() }}',
                                                    },
                                                    success: function (response) {
                                                        if (response.success) {
                                                           
                                                            quantityCell.slideUp(200, function() {
                                                                quantityCell.text(response.quantity); 
                                                                quantityCell.slideDown(200); 
                                                            });

                                                            $('#total-price').text(response.sumCart.toLocaleString('vi-VN') + " VNĐ");
                                                            
                                                            Swal.fire({
                                                                icon: 'success',
                                                                iconColor: 'white',
                                                                title: 'Thêm thành công',
                                                                color: 'white',
                                                                toast: true,
                                                                position: 'bottom-left',
                                                                showConfirmButton: false,
                                                                timer: 3000,
                                                                background: '#73D06F'
                                                            });
                                                        } else {
                                                            Swal.fire({
                                                                icon: 'error',
                                                                iconColor: 'white',
                                                                title: 'Có lỗi xảy ra',
                                                                text: response.message,
                                                                color: 'white',
                                                                toast: true,
                                                                position: 'bottom-left',
                                                                showConfirmButton: false,
                                                                timer: 3000,
                                                                background: '#FF6A74'
                                                            });
                                                        }
                                                    },
                                                    error: function () {
                                                        Swal.fire({
                                                            icon: 'error',
                                                            iconColor: 'white',
                                                            title: 'Lỗi',
                                                            text: 'Không thể thêm sản phẩm vào giỏ hàng',
                                                            color: 'white',
                                                            toast: true,
                                                            position: 'bottom-left',
                                                            showConfirmButton: false,
                                                            timer: 3000,
                                                            background: '#FF6A74'
                                                        });
                                                    },
                                                });
                                            });

                                        });
                                    </script>
                                   @else
                                    <div class="card_dp_khoi">
                                        <div class="header_dp_khoi">
                                        <span class="icon_dp_khoi">
                                            <svg fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                                            <path clip-rule="evenodd" d="M18 3a1 1 0 00-1.447-.894L8.763 6H5a3 3 0 000 6h.28l1.771 5.316A1 1 0 008 18h1a1 1 0 001-1v-4.382l6.553 3.276A1 1 0 0018 15V3z" fill-rule="evenodd"></path>
                                            </svg>
                                        </span>
                                        <p class="alert_dp_khoi">Thông báo!</p>
                                        </div>
                                        <img src="assets/img/night-time.png" alt="" style="max-width:168px">

                                        <p class="message_dp_khoi">
                                        <h1>Opps :( </h1>
                                        <span style="font-size:20px">Không tìm thấy phòng nào trong giỏ của bạn! Nếu bạn chưa đặt phòng hãy chọn loại phòng bạn thích và đặt ngay.</span>
                                        </p>
                                    
                                        <div class="actions_dp_khoi">
                                        <a class="read_dp_khoi" href="{{ route("AllCategoryRoom") }}">
                                            Xem các loại phòng
                                        </a>
                                    
                                        <a class="mark-as-read_dp_khoi" href="{{ route("Home") }}">
                                            Quay lại trang chủ
                                        </a>
                                        </div>
                                    </div>                                  
                                   @endif             
                                </div>
                            </div>
                        </div>
                    </div><!-- End Recent Sales -->
                    <!-- End Top Selling -->
                </div>
            </div><!-- End Left side columns -->

            <!-- Right side columns -->
            <!-- End Right side columns -->
        </div>
    </section>

</main><!-- End #main -->
@endsection