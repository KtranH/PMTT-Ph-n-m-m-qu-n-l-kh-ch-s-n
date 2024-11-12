@extends('Layout')
@section('body')
  <title>GTX - Tùy chỉnh tài khoản</title>
  <main id="main" class="main">

    <div class="pagetitle">
        <h1>Cập nhật thông tin</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">Home</a></li>
                <li class="breadcrumb-item">Tài khoản người dùng</li>
                <li class="breadcrumb-item active">Cập nhật thông tin</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->
    <section class="section profile">
        <div class="row">
            <div class="col-xl-4">

                <div class="card" style="border-radius:20px;">
                    <div class="card-body profile-card pt-4 d-flex flex-column align-items-center">
                        <img src="{{ $user->AVATAR }}" alt="Profile" class="rounded-circle">
                        <h2>{{ $user->HOTEN }}</h2>
                        <h3>{{ $user->EMAIL }}</h3>
                        <div class="social-links mt-2">
                            <a href="#" class="twitter"><i class="bi bi-twitter"></i></a>
                            <a href="#" class="facebook"><i class="bi bi-facebook"></i></a>
                            <a href="#" class="instagram"><i class="bi bi-instagram"></i></a>
                            <a href="#" class="linkedin"><i class="bi bi-linkedin"></i></a>
                        </div>
                    </div>
                </div>
                <div class="card_edit_khoi">
                  <div class="card-image_edit_khoi"></div>
                  <div class="category_edit_khoi"> Thông báo quan trọng </div>
                  <div class="heading_edit_khoi"> Vui lòng bảo mật tài khoản của bạn, không để lộ thông tin quan trọng như cookie, email, số điện thoại!
                      <div class="author_edit_khoi"> Cảnh báo <span class="name_edit_khoi">Bảo mật</span></div>
                  </div>
              </div>
            </div>
            <div class="col-xl-8" style="border-radius:20px;">

                <div class="card" style="border-radius:20px;">
                    <div class="card-body pt-3">
                        <!-- Bordered Tabs -->
                        <ul class="nav nav-tabs nav-tabs-bordered">
                            <li class="nav-item">
                                <button class="nav-link active" data-bs-toggle="tab" data-bs-target="#profile-edit">Cập nhật thông tin</button>
                            </li>
                            <li class="nav-item">
                                <button class="nav-link" data-bs-toggle="tab" data-bs-target="#profile-change-password">Đổi mật khẩu</button>
                            </li>
                        </ul>
                        <div class="tab-content pt-2">

                            <div class="tab-pane fade show active profile-edit pt-3" id="profile-edit">
                          
                                <!-- Profile Edit Form -->
                                <form class="needs-validation" novalidate method="POST" enctype="multipart/form-data" action="{{ route('updateAccount') }}">
                                  @csrf
                                  @method('PUT')
                                  <div class="row mb-3">
                                      <label for="profileImage" class="col-md-4 col-lg-3 col-form-label">Ảnh đại diện</label>
                                      <div class="col-md-8 col-lg-9">
                                        <img id="avatarPreview" src="{{ $user->AVATAR}}" alt="Profile" style="max-width:120px;">
                                        <div class="mb-3">
                                          <label for="formFile" class="form-label">Tải lên ảnh đại diện</label>
                                          <input class="form-control" type="file" id="formFile" name = "avatar" accept="image/*">
                                          <div class="invalid-feedback">Vui lòng tải một ảnh hợp lệ</div>
                                        </div>
                                      </div>
                                    </div>
                                    <!-- Hiển thị ảnh demo khi người dùng tải ảnh lên -->
                                    <script>
                                      document.getElementById('formFile').addEventListener('change', function(event) {
                                          var input = event.target;
                                          if (input.files && input.files[0]) {
                                              var reader = new FileReader();
                                              reader.onload = function(e) {
                                                  var avatarPreview = document.getElementById('avatarPreview');
                                                  avatarPreview.src = e.target.result;
                                              }
                                              reader.readAsDataURL(input.files[0]);
                                          }
                                      });
                                    </script>

                                    <div class="row mb-3">
                                      <label for="fullName" class="col-md-4 col-lg-3 col-form-label">Họ và tên</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="fullName" type="text" class="form-control" id="fullName" value="{{ $user->HOTEN }}" required>
                                        <div class="invalid-feedback">Họ tên không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="about" class="col-md-4 col-lg-3 col-form-label">Ghi chú</label>
                                      <div class="col-md-8 col-lg-9">
                                        <textarea name="about" class="form-control" id="about" style="height: 100px"> Ohh. Bạn chưa có ghi chú nào! :( </textarea>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="Job" class="col-md-4 col-lg-3 col-form-label">Số điện thoại</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="phone" type="number" min = 1 minlength= 10 class="form-control" id="Job" value="{{ $user->SDT }}" required>
                                        <div class="invalid-feedback">Điện thoại không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="Country" class="col-md-4 col-lg-3 col-form-label">Căn cước công dân</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="cccd" type="number" min = 1 minlength = 10 class ="form-control" id="Country" value="{{ $user->CCCD }}" required>
                                        <div class="invalid-feedback">Căn cước công dân không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="Address" class="col-md-4 col-lg-3 col-form-label">Email</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="email" type="email" class="form-control" id="Address" value="{{ $user->EMAIL }}"  disabled>
                                        <div class="invalid-feedback">Email không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="Phone" class="col-md-4 col-lg-3 col-form-label">Ngày Sinh</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="birthday" type="date" class="form-control" id="Phone" value="{{ $user->NGAYSINH }}" required>
                                        <div class="invalid-feedback">Ngày sinh không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="Email" class="col-md-4 col-lg-3 col-form-label">Giới tính</label>
                                      <div class="col-md-8 col-lg-9">
                                        <select class="form-select" aria-label="Default select example" name="gender">
                                          @if ($user->GIOITINH == "Nam")
                                            <option selected value="Nam">Nam</option>
                                            <option value="Nữ">Nữ</option>
                                          @endif
                                          @if ($user->GIOITINH == "Nữ")
                                            <option selected value="Nữ">Nữ</option>
                                            <option value="Nam">Nam</option>
                                          @endif
                                          @if ($user->GIOITINH == "Chưa rõ")
                                          <option selected value="Chưa rõ">Lựa chọn giới tính của bạn</option>
                                          <option value="Nữ">Nữ</option>
                                          <option value="Nam">Nam</option>
                                        @endif
                                        </select>
                                        <div class="invalid-feedback">Giới tính không hợp lệ</div>
                                      </div>
                                    </div>            
                                    <div class="text-center">
                                      <button type="submit" name = "check" class="btn btn-primary" style="border-radius:20px">Lưu và thay đổi</button>
                                    </div>
                                  </form>
                                <!-- End Profile Edit Form -->
                            </div>
                            <div class="tab-pane fade pt-3" id="profile-change-password">
                                <!-- Change Password Form -->
                                <form action="{{ route("changePassword") }}" novalidate method="POST" >
                                  @csrf
                                  @method('PATCH')
                                    <div class="row mb-3">
                                      <label for="currentPassword" class="col-md-4 col-lg-3 col-form-label">Mật khẩu hiện tại</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="password" type="password" class="form-control" id="currentPassword" required>
                                        <div class="invalid-feedback">Mật khẩu không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="newPassword" class="col-md-4 col-lg-3 col-form-label">Mật khẩu mới</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="newpassword" type="password" class="form-control" id="newPassword" required>
                                        <div class="invalid-feedback">Mật khẩu không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="row mb-3">
                                      <label for="renewPassword" class="col-md-4 col-lg-3 col-form-label">Nhập lại mật khẩu</label>
                                      <div class="col-md-8 col-lg-9">
                                        <input name="renewpassword" type="password" class="form-control" id="renewPassword" required>
                                        <div class="invalid-feedback">Mật khẩu không hợp lệ</div>
                                      </div>
                                    </div>
                
                                    <div class="text-center">
                                      <button type="submit" class="btn btn-primary">Lưu và thay đổi</button>
                                    </div>
                                  </form>
                                <!-- End Change Password Form -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>
@endsection