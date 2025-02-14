@extends('Layout')
@section('body')
  <title>GTX - Thông tin</title>
  <main id="main" class="main">

    <div class="pagetitle">
        <h1>Thông tin</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">Home</a></li>
                <li class="breadcrumb-item">Thông tin</li>
                <li class="breadcrumb-item active">Về chúng tôi</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->

    <section class="section faq">
        <div class="row">
            <div class="col-lg-6">

                <div class="card basic" style="border-radius: 20px" data-aos="fade-right">
                    <div class="card-body">
                        <h5 class="card-title">Thông tin cơ bản</h5>

                        <div data-aos="fade-up" data-aos-delay="500">
                            <h6>Ai là nhóm trưởng trong nhóm?</h6>
                            <p>Trần Hoàng Anh Khôi - 2001215884 (Nhóm trưởng)</p>
                        </div>

                        <div class="pt-2" data-aos="fade-up" data-aos-delay="600">
                            <h6>Những thành viên trong nhóm?</h6>
                            <p>Nguyễn Thành Trung - 2001210742 </p>
                        </div>

                        <div class="pt-2" data-aos="fade-up" data-aos-delay="700">
                            <h6>Những thành viên trong nhóm?</h6>
                            <p>Nguyễn Đoàn Anh Thư- 2001216198</p>
                        </div>

                    </div>
                </div>

                <!-- F.A.Q Group 1 -->
                <div class="card" style="border-radius:20px" data-aos="fade-right">
                    <div class="card-body">
                        <h5 class="card-title">Mô tả chức năng</h5>

                        <div class="accordion accordion-flush" id="faq-group-1">

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="500">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsOne-1" type="button" data-bs-toggle="collapse">
                                        Xây dựng Trang User (Home):
                                    </button>
                                </h2>
                                <div id="faqsOne-1" class="accordion-collapse collapse" data-bs-parent="#faq-group-1">
                                    <div class="accordion-body">
                                        Trang User gồm có trang hiển thị tất cả các sản phẩm, phân trang các sản phẩm.
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="600">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsOne-2" type="button" data-bs-toggle="collapse">
                                        Tương tác trong việc tìm sản phẩm:
                                    </button>
                                </h2>
                                <div id="faqsOne-2" class="accordion-collapse collapse" data-bs-parent="#faq-group-1">
                                    <div class="accordion-body">
                                        Tìm kiếm sản phẩm theo tên trong thanh Search, tìm kiếm sản phẩm theo hãng, tìm kiếm sản phẩm theo loại và sản phẩm theo giá.
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="700">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsOne-3" type="button" data-bs-toggle="collapse">
                                        Xem chi tiết sản phẩm và đặt mua:
                                    </button>
                                </h2>
                                <div id="faqsOne-3" class="accordion-collapse collapse" data-bs-parent="#faq-group-1">
                                    <div class="accordion-body">
                                        Khi người dùng nhìn thấy sản phẩm ở Home và nhấp vào sẽ chuyển hướng người dùng đến trang chi tiết sản phẩm đó và nút thêm vào giỏ hàng.
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="800">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsOne-4" type="button" data-bs-toggle="collapse">
                                        Trang tài khoản User và đơn hàng:
                                    </button>
                                </h2>
                                <div id="faqsOne-4" class="accordion-collapse collapse" data-bs-parent="#faq-group-1">
                                    <div class="accordion-body">
                                        Trang tài khoản của User chứa tất cả các thông tin của User và cho phép User sửa thông tin của chính mình,đổi mật khẩu, xem đơn hàng.
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="900">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsOne-5" type="button" data-bs-toggle="collapse">
                                        Trang đăng ký, đăng nhập, Admin (Winform):
                                    </button>
                                </h2>
                                <div id="faqsOne-5" class="accordion-collapse collapse" data-bs-parent="#faq-group-1">
                                    <div class="accordion-body">
                                        Thực hiện tạo tài khoản cho User và đăng nhập tài khoản User và Admin. Admin chuyển hướng vào trang riêng của Admin cho phép tùy chỉnh dữ liệu trên web.
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div><!-- End F.A.Q Group 1 -->

            </div>

            <div class="col-lg-6">

                <!-- F.A.Q Group 2 -->
                <div class="card" style="border-radius:20px" data-aos="fade-left">
                    <div class="card-body">
                        <h5 class="card-title">Phân công công việc</h5>

                        <div class="accordion accordion-flush" id="faq-group-2">

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="500">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsTwo-1" type="button" data-bs-toggle="collapse">
                                        Trang User và tương tác dữ liệu:
                                    </button>
                                </h2>
                                <div id="faqsTwo-1" class="accordion-collapse collapse" data-bs-parent="#faq-group-2">
                                    <div class="accordion-body">
                                        Trần Hoàng Anh Khôi
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="600">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsTwo-2" type="button" data-bs-toggle="collapse">
                                        Trang tài khoản User và tạo tài khoản User:
                                    </button>
                                </h2>
                                <div id="faqsTwo-2" class="accordion-collapse collapse" data-bs-parent="#faq-group-2">
                                    <div class="accordion-body">
                                        Trần Hoàng Anh Khôi
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="700">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsTwo-3" type="button" data-bs-toggle="collapse">
                                        Trang giỏ hàng:
                                    </button>
                                </h2>
                                <div id="faqsTwo-3" class="accordion-collapse collapse" data-bs-parent="#faq-group-2">
                                    <div class="accordion-body">
                                        Nguyễn Đoàn Anh Thư
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="800">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsTwo-4" type="button" data-bs-toggle="collapse">
                                        Trang Admin và chức năng của Admin (Winform):
                                    </button>
                                </h2>
                                <div id="faqsTwo-4" class="accordion-collapse collapse" data-bs-parent="#faq-group-2">
                                    <div class="accordion-body">
                                        Nguyễn Thành Trung và Nguyễn Đoàn Anh Thư
                                    </div>
                                </div>
                            </div>

                            <div class="accordion-item" data-aos="fade-up" data-aos-delay="900">
                                <h2 class="accordion-header">
                                    <button class="accordion-button collapsed" data-bs-target="#faqsTwo-5" type="button" data-bs-toggle="collapse">
                                        Báo cáo đồ án:
                                    </button>
                                </h2>
                                <div id="faqsTwo-5" class="accordion-collapse collapse" data-bs-parent="#faq-group-2">
                                    <div class="accordion-body">
                                        Trần Hoàng Anh Khôi, Nguyễn Đoàn Anh Thư, Nguyễn Thành Trung
                                    </div>
                                </div>
                            </div>

                        </div>

                    </div>
                </div><!-- End F.A.Q Group 2 -->
            </div>
        </div>
    </section>

</main><!-- End #main -->

@endsection