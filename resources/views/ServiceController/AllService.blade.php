@extends('Layout')
@section('body')
<title>GTX - Dịch vụ</title>
<main id="main" class="main">

    <div class="pagetitle">
        <h1>Dịch vụ</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">GTX</a></li>
                <li class="breadcrumb-item active">Tất cả dịch vụ</li>
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
                                <h5 class="card-title">Dịch vụ <span>/Tất cả</span></h5>
                                <div class="row bg-white" style="padding:20px;border-radius:20px;width:100%;display:flex;justify-content: space-around;">
                                    @foreach($service as $dv)
                                    @php
                                    $format_cost = number_format($dv->GIA, 0, ',', '.');
                                    @endphp
                                    <div class="col-md-6 mb-4" style="max-width:400px">
                                         <div class="Ha card my-specific-card {{ $dv->ISDELETE == 1 ? 'disabled' : '' }}">
                                            <div class="card-img">
                                                <img src="{{$dv->HINH}}" alt="" class="{{ $dv->ISDELETE == 1 ? 'grayscale' : '' }}"> 
                                            </div>
                                            <div class="card-info">
                                                <p class="text-title"> {{ $dv->TENDICHVU }}</p>
                                                <p class="card-text"><span style="font-weight:bold;">Mô tả:</span>
                                                    {{ Str::limit($dv->MOTA, 180, $end='...') }}
                                                </p>
                                            </div>
                                            @if($dv->ISDELETE == 1)
                                                <div class="card-footer" style="border-radius:20px;background-color:gray">
                                            @else
                                                <div class="card-footer" style="border-radius:20px">
                                            @endif
                                                    @if($dv->ISDELETE == 1)
                                                    <span class="text-title rend-cost">
                                                        Không còn hoạt động
                                                    </span>
                                                    @else
                                                    <span class="text-title rend-cost" style="color:white">
                                                        {{ $format_cost }}<sup>đ</sup>
                                                    </span>
                                                    @endif
                                            </div>
                                        </div>
                                    </div>
                                    @endforeach
                                    {{ $service->links("vendor.pagination.bootstrap-5") }}
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