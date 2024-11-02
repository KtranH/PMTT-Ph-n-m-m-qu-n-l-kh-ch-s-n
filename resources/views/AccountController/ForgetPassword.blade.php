<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Quên mật khẩu</title>
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0" name="viewport">
  
    <meta content="" name="description">
    <meta content="" name="keywords">
  
    <!-- Favicons -->
    <link href="{{ url('assets/img/favicon.png')}}" rel="icon">
    <link href="{{ url('assets/img/apple-touch-icon.png')}}" rel="apple-touch-icon">
  
    <!-- Google Fonts -->
    <link href="https://fonts.gstatic.com" rel="preconnect">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Nunito:300,300i,400,400i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,500;1,500&display=swap" rel="stylesheet">
   
    <!-- Icon -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.2/css/all.min.css">
  
    <!-- Vendor CSS Files -->
    <link href="{{ url('assets/vendor/bootstrap/css/bootstrap.min.css')}}" rel="stylesheet">
    <link href="{{ url('assets/vendor/bootstrap-icons/bootstrap-icons.css')}}" rel="stylesheet">
    <link href="{{ url('assets/vendor/boxicons/css/boxicons.min.css')}}" rel="stylesheet">
    <link href="{{ url('assets/vendor/quill/quill.snow.css')}}" rel="stylesheet">
    <link href="{{ url('assets/vendor/quill/quill.bubble.css')}}" rel="stylesheet">
    <link href="{{ url('assets/vendor/remixicon/remixicon.css')}}" rel="stylesheet">
    <link href="{{ url('assets/vendor/simple-datatables/style.css')}}" rel="stylesheet">
  
    <!-- Template Main CSS File -->
    <link href="{{ url('assets/css/style.css')}}" rel="stylesheet">
    <link href="{{ url('assets/css/khoi.css')}}" rel="stylesheet">
  
</head>
<body>
      <main>
      
          <div class="container">
    
          <section class="section register min-vh-100 d-flex flex-column align-items-center justify-content-center py-4">
            <div class="container">
              <div class="row justify-content-center">
                <div class="col-lg-5 col-md-6 d-flex flex-column align-items-center justify-content-center">
    
                  <div class="d-flex justify-content-center py-4">
                    <a href="{{ route('Home') }}" class="logo d-flex align-items-center w-auto">
                      <img src="assets/img/logo.png" alt="">
                      <span class="d-none d-lg-block">Khách sạn - GTX</span>
                    </a>
                  </div><!-- End Logo -->
    
                  <div class="card mb-3" style="border-radius:20px">
    
                    <div class="card-body">
    
                      <div class="pt-4 pb-2">
                        <h5 class="card-title text-center pb-0 fs-4" style="font-family: Montserrat, sans-serif;font-optical-sizing: auto;font-weight:600;">Quên mật khẩu</h5>
                        <p class="text-center small">Vui lòng nhập email của bạn.</p>
                      </div>
    
                      <form class="row g-3 needs-validation" novalidate method="GET" action="{{ route('AuthEmailToChangePassword') }}">
                        @csrf
                        <div class="col-12">
                          <label for="yourUsername" class="form-label">Email của bạn</label>
                          <div class="input-group has-validation">
                            <input type="email" name="email" class="form-control" id="yourUsername" required>
                            <div class="invalid-feedback">Vui lòng nhập địa chỉ email hợp lệ!</div>
                          </div>
                        </div>
                        <div class="col-12">
                          <button class="btn btn-primary w-100" style="border-radius:20px" type="submit">Tiếp tục</button>
                        </div>
                        <div class="col-12">
                          @if (Session::has('error'))
                              <p class="text-danger" role="alert">{{ Session::get('error') }}</p>
                          @endif
                        </div>
                      </form>
                    </div>
                  </div>
                </div>
              </div>
            </div>
    
          </section>
    
        </div>
      </main><!-- End #main -->
    <a href="#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>
    <!-- Vendor JS Files -->
    <script src="{{ url('assets/vendor/apexcharts/apexcharts.min.js')}}"></script>
    <script src="{{ url('assets/vendor/bootstrap/js/bootstrap.bundle.min.js')}}"></script>
    <script src="{{ url('assets/vendor/chart.js/chart.umd.js')}}"></script>
    <script src="{{ url('assets/vendor/echarts/echarts.min.js')}}"></script>
    <script src="{{ url('assets/vendor/quill/quill.min.js')}}"></script>
    <script src="{{ url('assets/vendor/simple-datatables/simple-datatables.js')}}"></script>
    <script src="{{ url('assets/vendor/tinymce/tinymce.min.js')}}"></script>
    <script src="{{ url('assets/vendor/php-email-form/validate.js')}}"></script>

    <!-- Template Main JS File -->
    <script src="{{ url('assets/js/main.js')}}"></script>
</body>
</html>