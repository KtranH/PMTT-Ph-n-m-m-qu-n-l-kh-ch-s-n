@extends('Layout')
@section('body')
  <title>GTX - Liên hệ</title>
  <main id="main" class="main">

    <div class="pagetitle">
        <h1>Liên hệ</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">Home</a></li>
                <li class="breadcrumb-item active">Liên hệ</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->

    <section class="section contact">

        <div class="row gy-12">

            <div class="col-xl-12">

                <div class="row">
                    <div class="col-lg-6" data-aos="fade-up" data-aos-delay="100">
                        <div class="info-box card" style="border-radius:20px">
                            <i class="bi bi-geo-alt"></i>
                            <h3>Địa chỉ</h3>
                            <p>Phường Tây Thạnh,<br> Quận Tân Phú, TP.HCM</p>
                        </div>
                    </div>
                    <div class="col-lg-6" data-aos="fade-up" data-aos-delay="100">
                        <div class="info-box card" style="border-radius:20px">
                            <i class="bi bi-telephone"></i>
                            <h3>Số điện thoại</h3>
                            <p>+1 5589 55488 55<br>+1 6678 254445 41</p>
                        </div>
                    </div>
                    <div class="col-lg-6" data-aos="fade-up" data-aos-delay="500">
                        <div class="info-box card" style="border-radius:20px">
                            <i class="bi bi-envelope"></i>
                            <h3>Email liên hệ</h3>
                            <p>info@example.com<br>contact@example.com</p>
                        </div>
                    </div>
                    <div class="col-lg-6" data-aos="fade-up" data-aos-delay="500">
                        <div class="info-box card" style="border-radius:20px">
                            <i class="bi bi-clock"></i>
                            <h3>Hỗ trợ</h3>
                            <p>Từ thứ 2 đến thứ 7<br> Từ 9:00AM - 05:00PM</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>

</main><!-- End #main -->
@endsection