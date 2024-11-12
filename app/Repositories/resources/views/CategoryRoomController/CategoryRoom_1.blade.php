@extends('Layout')
@section('body')
<title>GTX - Loại phòng 1 người</title>
<main id="main" class="main">

    <div class="pagetitle">
        <h1>Loại phòng 1 người</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">GTX</a></li>
                <li class="breadcrumb-item active">Loại phòng 1 người</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->

    <section class="section dashboard">
        <div class="row">
          <!-- Left side columns -->
          <div class="col-lg-12">
            <div class="row">
             <!-- Reports -->
                    <div class="col-12">
                        <div class="card" style="border-radius:20px">
                            <div class="card-body">
                                <h5 class="card-title">Loại phòng <span>/Loại 1 người</span></h5>
                                <div class="row bg-white" style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-between;">
                                @foreach($categoryroom_1 as $r)
                                @php
                                    $firstImage = $r->hinhLoaiPhong[0]->HINH;
                                    $format_cost = number_format($r->GIATHUE, 0, ',', '.');
                                @endphp
                                <div class="col-md-6 mb-4" style="max-width:800px" data-aos="fade-up">
                                    <div class="Ha card my-specific-card {{$r->ISDELETE==1 ? 'disabled':''}}">
                                        <div class="card-img">
                                            <img src="{{$firstImage}}" loading="lazy" alt="" class="{{$r->ISDELETE==1? 'grayscale':''}}">
                                        </div>
                                        <div class="card-info">
                                            <p class="text-title"> {{ $r->TENLOAIPHONG }}</p>
                                            <p class="card-text">
                      
                                            </p>
                                            @if ($r->ISDELETE==1)
                                            <p class="card-text"><i class="fa-solid fa-couch"
                                                style="color:gray;margin-right:10px;"></i><span style="font-weight:bold;">Nội thất:</span>
                                                {{ $r->NOITHAT }}
                                            </p>
                                            
                                            <p class="card-text"><i class="fa-solid fa-hotel"
                                                    style="color:gray;margin-right:10px;"></i><span style="font-weight:bold;">Diện
                                                    tích:</span>
                                                {{ $r->TIENICH }}
                                            </p>
                      
                      
                                            <p class="card-text"><i class="fa-solid fa-box" style="color:#gray;"></i><span
                                                    style="font-weight:bold;margin-left:10px;">Sức chứa tối
                                                    đa:</span> {{ $r->SUCCHUA }}</p>
                                            <p class="card-text">
                                            <p class="card-text"><i class="fa-solid fa-ban" style="color:#gray;margin-right:5px;"></i>
                                                {{ $r->QUYDINH }}
                                            </p>
                                            </p>
                      
                                        </div>
                                            <div class="card-footer" style="border-radius:20px;background-color:gray">
                                            <span class="text-title" style="color:white;">Không còn hoạt động</span>
                      
                                            @else
                                                  <p class="card-text"><i class="fa-solid fa-couch" style="color: #74C0FC;margin-right:10px"></i><span style="font-weight:bold;">Nội thất: </span>{{ $r->NOITHAT }}
                                                  </p>
                                                  <p class="card-text"><i class="fa-solid fa-hotel"
                                                          style="color:#74C0FC;margin-right:10px;"></i><span style="font-weight:bold;">Diện
                                                          tích:</span>
                                                      {{ $r->TIENICH }}
                                                  </p>
                            
                            
                                                  <p class="card-text"><i class="fa-solid fa-box" style="color:#74C0FC;"></i><span
                                                          style="font-weight:bold;margin-left:10px;">Sức chứa tối
                                                          đa:</span> {{ $r->SUCCHUA }}</p>
                                                  <p class="card-text">
                                                  <p class="card-text"><i class="fa-solid fa-ban" style="color:#74C0FC;margin-right:5px;"></i>
                                                      <span style="font-weight:bold;">Quy định:</span>
                                                      {{ $r->QUYDINH }}
                                                  </p>
                                                  </p>
                            
                                              </div>
                                            <div class="card-footer" style="border-radius:20px">
                                            <span class="text-title" style="color:white;">{{ $format_cost }}<sup>đ</sup></span>
                                            @endif
                                            <a class="card-button" href="{{ route('Overview_CateRoom', ['id' => $r->ID]) }}">
                                                <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 576 512">
                                                    <path fill="#fafafa"
                                                        d="M320 32c0-9.9-4.5-19.2-12.3-25.2S289.8-1.4 280.2 1l-179.9 45C79 51.3 64 70.5 64 92.5V448H32c-17.7 0-32 14.3-32 32s14.3 32 32 32H96 288h32V480 32zM256 256c0 17.7-10.7 32-24 32s-24-14.3-24-32s10.7-32 24-32s24 14.3 24 32zm96-128h96V480c0 17.7 14.3 32 32 32h64c17.7 0 32-14.3 32-32s-14.3-32-32-32H512V128c0-35.3-28.7-64-64-64H352v64z" />
                                                </svg>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                @endforeach
                                {{ $categoryroom_1->links("vendor.pagination.bootstrap-5") }}
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