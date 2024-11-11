
    <!-- ======= Sidebar ======= -->
    <aside id="sidebar" class="sidebar">

        <ul class="sidebar-nav" id="sidebar-nav">
    
          <li class="nav-item">
            <a class="nav-link " href="{{ route("Home") }}">
              <i class="fa-solid fa-house" style="color: #74C0FC;"></i>
              <span>Trang chủ</span>
            </a>
          </li><!-- End Dashboard Nav -->
            <li class="nav-item">
              <a class="nav-link collapsed" data-bs-target="#components-nav" data-bs-toggle="collapse" href="#">
                  <i class="fa-solid fa-door-open" style="color: #74C0FC;"></i><span>Loại phòng</span><i class="bi bi-chevron-down ms-auto"></i>
              </a>
              <ul id="components-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
                  <li>
                      <a href="{{ route("AllCategoryRoom") }}">
                          <i class="bi bi-circle"></i><span>Tất cả loại phòng</span>
                      </a>
                  </li>
                  <li>
                      <a href="{{ route("CateRoom_1") }}">
                          <i class="bi bi-circle"></i><span>Loại 1 người</span>
                      </a>
                  </li>
                  <li>
                      <a href="{{ route("CateRoom_2") }}">
                          <i class="bi bi-circle"></i><span>Loại 2 người</span>
                      </a>
                  </li>
                  <li>
                      <a href="{{ route("CateRoom_4") }}">
                          <i class="bi bi-circle"></i><span>Loại 4 người</span>
                      </a>
                  </li>
  
  
  
              </ul>
          </li><!-- End Forms Nav -->
  
          <li class="nav-item">
              <a class="nav-link collapsed" data-bs-target="#tables-nav" data-bs-toggle="collapse" href="#">
                  <i class="fa-solid fa-magnifying-glass-dollar" style="color: #74C0FC;"></i><span>Phân loại theo giá phòng</span><i class="bi bi-chevron-down ms-auto"></i>
              </a>
              <ul id="tables-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
                  <li>
                      <a href="{{ route("CateRoom_PriceHighToLow") }}">
                          <i class=" bi bi-circle"></i><span>Giá từ cao tới thấp</span>
                      </a>
                  </li>
                  <li>
                      <a href="{{ route("CateRoom_PriceLowToHigh") }}">
                          <i class="bi bi-circle"></i><span>Giá từ thấp tới cao</span>
                      </a>
                  </li>
              </ul>
          </li><!-- End Tables Nav -->
        
          <li class="nav-item"> 
              <a class="nav-link collapsed" data-bs-target="#charts-nav" data-bs-toggle="collapse" href="#">
                  <i class="fa-brands fa-servicestack" style="color: #74C0FC;"></i><span>Dịch vụ</span><i
                      class="bi bi-chevron-down ms-auto"></i>
              </a>
              <ul id="charts-nav" class="nav-content collapse " data-bs-parent="#sidebar-nav">
                  <li>
                      <a href="{{ route("AllService") }}">
                          <i class="bi bi-circle"></i><span>Tất Cả Dịch Vụ</span>
                      </a>
                  </li>
              </ul>
          </li><!-- End Charts Nav -->
  
          @if (Auth::check())
              <li class="nav-heading">Tài khoản</li>
        
              <li class="nav-item">
                <a class="nav-link collapsed" href="{{ route("homeAccount" )}}">
                  <i class="fa-solid fa-user" style="color: #74C0FC;"></i>
                  <span>Trang cá nhân</span>
                </a>
              </li><!-- End Profile Page Nav -->
        
              <li class="nav-item">
                <a class="nav-link collapsed" href="{{ route("listBooking" )}}">
                  <i class="fa-solid fa-tag" style="color: #74C0FC;"></i>
                  <span>Đặt phòng</span>
                </a>
              </li><!-- End F.A.Q Page Nav -->
        
              <li class="nav-item">
                <a class="nav-link collapsed" href="{{ route("review" ) }}">
                  <i class="fa-solid fa-star" style="color: #74C0FC;"></i>
                  <span>Đánh giá</span>
                </a>
              </li><!-- End Contact Page Nav -->
  
              <li class="nav-item">
                <a class="nav-link collapsed" href="{{ route("Contact" ) }}">
                  <i class="fa-solid fa-question" style="color: #74C0FC;"></i>
                  <span>Liên hệ</span>
                </a>
              </li><!-- End Error 404 Page Nav -->
        
              <li class="nav-item">
                <a class="nav-link collapsed" href="{{ route("Information") }}">
                  <i class="fa-solid fa-circle-info" style="color: #74C0FC;"></i>
                  <span>Thông tin</span>
                </a>
              </li><!-- End Blank Page Nav -->
          @else
              <li class="nav-item">
                <a class="nav-link collapsed" href="">
                  <i class="fa-solid fa-square-pen" style="color: #74C0FC;"></i>
                  <span>Đăng ký</span>
                </a>
              </li><!-- End Register Page Nav -->
        
              <li class="nav-item">
                <a class="nav-link collapsed" href="">
                  <i class="fa-solid fa-right-to-bracket" style="color: #74C0FC;"></i>
                  <span>Đăng nhập</span>
                </a>
              </li><!-- End Login Page Nav -->
        
              <li class="nav-item">
                <a class="nav-link collapsed" href="{{ route("Contact" ) }}">
                  <i class="fa-solid fa-question" style="color: #74C0FC;"></i>
                  <span>Liên hệ</span>
                </a>
              </li><!-- End Error 404 Page Nav -->
        
              <li class="nav-item">
                <a class="nav-link collapsed" href="{{ route("Information") }}">
                  <i class="fa-solid fa-circle-info" style="color: #74C0FC;"></i>
                  <span>Thông tin</span>
                </a>
              </li><!-- End Blank Page Nav -->
          @endif
        </ul>
    
    </aside><!-- End Sidebar-->