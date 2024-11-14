@extends('Layout')
@section('body')
<title>GTX - Chi tiết loại phòng</title>
<main id="main" class="main">

    <div class="pagetitle">
        <h1>Chi tiết</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">GTX</a></li>
                <li class="breadcrumb-item active">Chi tiết loại phòng</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->
    <style>
        /* Main container styles */
        .section.dashboard {
            max-width: 100%;
            margin: 0 auto;
            padding: 2rem;
        }

        .room-details-container {
            background: #fff;
            border-radius: 12px;
            box-shadow: 0 2px 15px rgba(0, 0, 0, 0.08);
            overflow: hidden;
        }

        /* Header styles */
        .card-header {
            height: 5px;
            background: #74C0FC;
            color: white;
        }
        /* Room content styles */
        .room-content {
            padding: 2rem;
        }

        /* Room header with heart */
        .room-header {
            display: flex;
            align-items: center;
            gap: 1rem;
            margin-bottom: 2rem;
        }

        .room-header img {
            width: 40px;
            height: 40px;
        }

        .heart_over_khoi {
            width: 24px;
            height: 24px;
            transition: all 0.3s ease;
            cursor: pointer;
        }

        .heart_over_khoi:hover {
            stroke: #ff4d4d;
            transform: scale(1.1);
        }

        /* Room title and price */
        .room-title {
            font-size: 2rem;
            color: #2c3e50;
            margin-bottom: 1rem;
        }

        .room-price {
            font-size: 1.5rem;
            color: #e74c3c;
            font-weight: 600;
            margin-bottom: 2rem;
        }

        /* Image gallery styles */
        .room-gallery {
            margin-bottom: 3rem;
        }

        .slider-for {
            margin-bottom: 1rem;
            border-radius: 12px;
            overflow: hidden;
        }

        .slider-for img {
            width: 100%;
            height: 500px;
            object-fit: cover;
        }

        .slider-nav {
            margin: 0 -0.5rem;
        }

        .slider-nav img {
            padding: 0.5rem;
            border-radius: 8px;
            height: 100px;
            object-fit: cover;
            cursor: pointer;
            transition: transform 0.3s ease;
        }

        .slider-nav img:hover {
            transform: scale(1.05);
        }

        /* Room details grid */
        .room-details {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 2rem;
            margin-bottom: 3rem;
        }

        .detail-item {
            display: flex;
            align-items: flex-start;
            gap: 1rem;
            padding: 1.5rem;
            background: #f8f9fa;
            border-radius: 10px;
            transition: transform 0.3s ease;
        }

        .detail-item:hover {
            transform: translateY(-5px);
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.05);
        }

        .detail-item i {
            font-size: 1.5rem;
            color: #3498db;
        }

        .detail-content {
            flex: 1;
        }

        .detail-title {
            font-size: 1.1rem;
            font-weight: 600;
            color: #2c3e50;
            margin-bottom: 0.5rem;
        }

        .detail-text {
            color: #666;
            line-height: 1.6;
            margin: 0;
        }

        /* Action buttons */
        .room-actions {
            display: flex;
            gap: 1rem;
            justify-content: flex-end;
        }

        .action-button {
            display: flex;
            align-items: center;
            gap: 0.5rem;
            padding: 0.8rem 1.5rem;
            border-radius: 8px;
            font-weight: 600;
            text-decoration: none;
            transition: all 0.3s ease;
        }

        .add-to-cart {
            background-color: #fff;
            color: #3498db;
            border: 2px solid #3498db;
        }

        .add-to-cart:hover {
            background-color: #3498db;
            color: #fff;
        }

        .book-now {
            background-color: #3498db;
            color: #fff;
        }

        .book-now:hover {
            background-color: #2980b9;
            transform: translateY(-2px);
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .section.dashboard {
                padding: 1rem;
            }
            
            .room-content {
                padding: 1.5rem;
            }
            
            .room-title {
                font-size: 1.5rem;
            }
            
            .slider-for img {
                height: 300px;
            }
            
            .room-actions {
                flex-direction: column;
            }
            
            .action-button {
                width: 100%;
                justify-content: center;
            }
        }

        /* Slick slider custom styles */
        /* Main container styles và các styles khác giữ nguyên... */
        /* Styles cho slider-nav */
        .slider-nav {
            margin: 0 -8px;
            padding: 0 40px;
        }

        .slider-nav .slick-slide {
            padding: 8px;
            transition: all 0.3s ease;
            position: relative;
            overflow: hidden;
            border-radius: 12px;
        }

        .slider-nav .slick-slide div {
            overflow: hidden;
            border-radius: 12px;
        }

        .slider-nav img {
            height: 100px;
            width: 100%;
            object-fit: cover;
            border-radius: 12px;
            cursor: pointer;
            transition: all 0.3s ease;
            padding: 2px;
            outline: 3px solid transparent;
        }

        .slick-dots li button:before {
            font-size: 12px;
            color: #007bff;
        }

        .slick-dots li.slick-active button:before {
            color: #0056b3;
        }

        .slider-nav .slick-current img {
            outline-color: #3498db;
            transform: scale(1.05);
            box-shadow: 0 4px 12px rgba(52, 152, 219, 0.3);
        }

        .slider-nav .slick-slide:hover img {
            transform: scale(1.05);
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.15);
        }

        .slider-nav .slide-image-container {
            position: relative;
            border-radius: 12px;
            overflow: hidden;
            background: #f8f9fa;
            border: 1px solid rgba(0, 0, 0, 0.1);
        }

        .slider-nav .slide-image-container:after {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background: rgba(52, 152, 219, 0);
            transition: all 0.3s ease;
            border-radius: 12px;
        }

        .slider-nav .slick-slide:hover .slide-image-container:after {
            background: rgba(52, 152, 219, 0.1);
        }
        #cart-icon.cart-added {
            animation: bounce 0.5s ease;
        }

        @keyframes bounce {
            0% {
                transform: scale(1);
            }
            50% {
                transform: scale(1.2);
            }
            100% {
                transform: scale(1);
            }
        }
        @media (max-width: 768px) {
            .slider-nav img {
                height: 70px;
                border-radius: 8px;
            }
            
            .slider-nav .slick-slide,
            .slider-nav .slide-image-container {
                border-radius: 8px;
            }
        }
    </style>
    <section class="section dashboard">
        <div class="room-details-container">
            <!-- Header with title -->

            <!-- Main content container -->
            <div class="room-content">
                <!-- Welcome header with heart icon -->
                <div class="room-header" data-aos="fade-down">
                    <img src="{{ url('assets/img/hotel.gif')}}" alt="Hotel icon">
                    <span>Chúng tôi hi vọng bạn thích</span>
                    <svg class="heart_over_khoi" version="1.1" viewBox="0 0 512 512" width="512px" xml:space="preserve" stroke="#727272" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                        <path d="M340.8,98.4c50.7,0,91.9,41.3,91.9,92.3c0,26.2-10.9,49.8-28.3,66.6L256,407.1L105,254.6c-15.8-16.6-25.6-39.1-25.6-63.9  c0-51,41.1-92.3,91.9-92.3c38.2,0,70.9,23.4,84.8,56.8C269.8,121.9,302.6,98.4,340.8,98.4 M340.8,83C307,83,276,98.8,256,124.8  c-20-26-51-41.8-84.8-41.8C112.1,83,64,131.3,64,190.7c0,27.9,10.6,54.4,29.9,74.6L245.1,418l10.9,11l10.9-11l148.3-149.8  c21-20.3,32.8-47.9,32.8-77.5C448,131.3,399.9,83,340.8,83L340.8,83z" stroke="#727272"/>
                    </svg>
                </div>

                <hr>
                <!-- Image gallery -->
                <div class="room-gallery" data-aos="fade-up" data-aos-delay="200">
                    <div class="slider-for">
                        @foreach ($Overview_CateRoom->hinhLoaiPhong as $img)
                            <div><img src="{{ $img->HINH }}" alt="Room view"></div>
                        @endforeach
                    </div>
                    
                    <div class="slider-nav">
                        @foreach ($Overview_CateRoom->hinhLoaiPhong as $img)
                            <div><img src="{{ $img->HINH }}" alt="Room thumbnail"></div>
                        @endforeach
                    </div>
                </div>

                <!-- Room title and price -->
                <div>
                    <h2 class="room-title action-button book-now" style="font-weight: bold; width: 100%;color: white; padding: 10px; border-radius: 10px; box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;">Loại phòng: {{ $Overview_CateRoom->TENLOAIPHONG }}</h2>
                    <div class="room-price" style="font-weight: bold;">Giá 1 đêm: {{ $Overview_CateRoom->GIATHUE }} VNĐ</div>
                </div>
    
                <!-- Room details grid -->
                <div class="room-details">
                    <div class="detail-item">
                        <i class="fa-solid fa-couch"></i>
                        <div class="detail-content">
                            <div class="detail-title">Nội thất</div>
                            <p class="detail-text">{{ $Overview_CateRoom->NOITHAT }}</p>
                        </div>
                    </div>
    
                    <div class="detail-item">
                        <i class="fa-solid fa-wand-magic-sparkles"></i>
                        <div class="detail-content">
                            <div class="detail-title">Tiện ích</div>
                            <p class="detail-text">{{ $Overview_CateRoom->TIENICH }}</p>
                        </div>
                    </div>
    
                    <div class="detail-item">
                        <i class="fa-solid fa-box"></i>
                        <div class="detail-content">
                            <div class="detail-title">Sức chứa tối đa</div>
                            <p class="detail-text">{{ $Overview_CateRoom->SUCCHUA }} người mỗi phòng</p>
                        </div>
                    </div>
    
                    <div class="detail-item">
                        <i class="fa-solid fa-ban"></i>
                        <div class="detail-content">
                            <div class="detail-title">Quy định</div>
                            <p class="detail-text">{{ $Overview_CateRoom->QUYDINH }}</p>
                        </div>
                    </div>
                </div>
    
                <!-- Action buttons -->
                <div class="room-actions">
                    <a href="#" class="action-button add-to-cart">
                        <i class="fa-solid fa-cart-shopping"></i>
                        Thêm vào danh sách!
                    </a>
                    <a href="{{ route('setupBooking', ['id' => $Overview_CateRoom->ID]) }}" class="action-button book-now">
                        <i class="fa-solid fa-receipt"></i>
                        Đặt ngay!
                    </a>
                </div>
            </div>
        </div>
    
        <!-- Slick Slider initialization -->
        <script>
            $(document).ready(function(){
                $('.slider-for').slick({
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    fade: true,
                    asNavFor: '.slider-nav'
                });
                
                $('.slider-nav').slick({
                    slidesToShow: 3,
                    slidesToScroll: 1,
                    asNavFor: '.slider-for',
                    dots: true,
                    centerMode: true,
                    focusOnSelect: true
                });
                let lastClickTime = 0;
                $('.add-to-cart').click(function(e) {
                    e.preventDefault();
                    const currentTime = new Date().getTime();
                    if (currentTime - lastClickTime < 5000) { 
                        Swal.fire({
                            icon: 'warning',
                            title: 'Vui lòng đợi 5 giây trước khi thêm tiếp',
                            toast: true,
                            position: 'bottom-left',
                            showConfirmButton: false,
                            timer: 3000
                        });
                        return;
                    }

                    lastClickTime = currentTime;
                    const $button = $(this);
                    $button.prop('disabled', true);

                    var roomID = {{ $Overview_CateRoom->ID }};
                        $.ajax({
                            url: '/addCart',
                            type: 'POST',
                            data: {
                                roomID: roomID,
                                _token: '{{ csrf_token() }}'
                            },
                            success: function(response) {
                                $('#cart-count').text(response.countCart);
                                $('#cart-icon').addClass('cart-added');
                                setTimeout(function() {
                                    $('#cart-icon').removeClass('cart-added');
                                }, 1000);
                                Swal.fire({
                                icon: 'success',
                                title: 'Thêm thành công',
                                toast: true,
                                position: 'bottom-left',
                                showConfirmButton: false,
                                timer: 3000
                                });
                            },
                            error: function(xhr, status, error) {
                                alert(error);
                                Swal.fire({
                                icon: 'error',
                                title: 'Thao tác thất bại',
                                toast: true,
                                position: 'bottom-left',
                                showConfirmButton: false,
                                timer: 3000
                                });
                            },
                            complete: function() {
                                setTimeout(function() {
                                    $button.prop('disabled', false);
                                }, 5000);
                            }
                        });
                    })
            });
        </script>
    </section>

</main><!-- End #main -->
@endsection