<!-- ======= Header ======= -->
<header id="header" class="header fixed-top d-flex align-items-center">

    <div class="d-flex align-items-center justify-content-between">
        <a href="{{ route("Home") }}" class="logo d-flex align-items-center">
            <img src="/assets/img/logo.png" alt="">
            <span class="d-none d-lg-block">GTX</span>
        </a>
        <i class="bi bi-list toggle-sidebar-btn"></i>
    </div><!-- End Logo -->

    <nav class="header-nav ms-auto">
        <ul class="d-flex align-items-center">
            <li style="width:110px;margin-right:30px">
                <button class="button_cart_khoi" style="width:100px;height:5px;margin-right:20px" title="Bạn đang có 0 sản phẩm trong giỏ">
                    <span style="color: #ffffff">0</span>
                    <i class="fa-solid fa-cart-shopping" style="color: #ffffff;"></i>
                </button>
            </li>
            @if (Auth::check())
            <li class="nav-item dropdown pe-3">
                <a class="nav-link nav-profile d-flex align-items-center pe-0" href="" data-bs-toggle="dropdown">
                    <img src="{{ Auth::user()->AVATAR }}" alt="Profile" class="rounded-circle">
                    <span class="d-none d-md-block dropdown-toggle ps-2"> {{ Auth::user()->HOTEN }} </span>
                </a><!-- End Profile Iamge Icon -->

                <ul class="dropdown-menu dropdown-menu-end dropdown-menu-arrow profile">
                    <li class="dropdown-header">
                        <h6>{{ Auth::user()->HOTEN }}</h6>
                        <span>Xin chào bạn trở lại</span>
                    </li>
                    <li>
                        <hr class="dropdown-divider">
                    </li>

                    <li>
                        <a class="dropdown-item d-flex align-items-center" href="">
                            <i class="bi bi-person"></i>
                            <span>Tài khoản của bạn</span>
                        </a>
                    </li>
                    <li>
                        <hr class="dropdown-divider">
                    </li>

                    <li>
                        <a class="dropdown-item d-flex align-items-center" href="">
                            <i class="bi bi-gear"></i>
                            <span>Tùy chỉnh</span>
                        </a>
                    </li>
                    <li>
                        <hr class="dropdown-divider">
                    </li>

                    <li>
                        <a class="dropdown-item d-flex align-items-center" href="">
                            <i class="bi bi-question-circle"></i>
                            <span>Cần giúp đỡ?</span>
                        </a>
                    </li>
                    <li>
                        <hr class="dropdown-divider">
                    </li>

                    <li>
                        <hr class="dropdown-divider">
                    </li>


                    <li>
                        <a class="dropdown-item d-flex align-items-center" href="{{ route("Logout") }}">
                            <i class="bi bi-box-arrow-right"></i>
                            <span>Đăng xuất</span>
                        </a>
                    </li>

                </ul><!-- End Profile Dropdown Items -->
            </li><!-- End Profile Nav -->
            @else
            <li> <a class="Button_Khoi" href="{{ route("Login") }}"> Đăng nhập </a></li>
            <li> <a class="Button_Khoi" style="background-color:#74C0FC;color:white" href="{{ route("SignUp") }}">
                    Đăng ký 
            </a></li>
            @endif
        </ul>
    </nav>
    <!-- End Icons Navigation -->

</header><!-- End Header -->