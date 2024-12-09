<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Booking Confirmation</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
        }
        .email-container {
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            border: 1px solid #ddd;
            border-radius: 8px;
            overflow: hidden;
        }
        .header {
            background-color: #007BFF;
            color: #ffffff;
            text-align: center;
            padding: 20px;
            font-size: 24px;
            font-weight: bold;
        }
        .content {
            padding: 20px;
        }
        .content p {
            margin: 0 0 10px;
        }
        .ticket-details {
            margin-top: 20px;
            border-top: 1px solid #ddd;
            padding-top: 10px;
        }
        .ticket-details table {
            width: 100%;
            border-collapse: collapse;
        }
        .ticket-details th, .ticket-details td {
            text-align: left;
            padding: 8px;
            border: 1px solid #ddd;
        }
        .footer {
            background-color: #f4f4f4;
            text-align: center;
            padding: 10px;
            font-size: 12px;
            color: #888;
        }
    </style>
</head>
<body>
    @php
        $occupant_info = null;
    @endphp
    @foreach ($bookingDetails as $detail)
        @php
            $occupant_info = $detail['occupant_info'];
            break;
        @endphp
    @endforeach
    <div class="email-container">
        <div class="header">
            Xác nhận đặt phòng
        </div>
        <div class="content">
            <p>Xin chào 
                @if ($occupant_info != null)
                    {{ $occupant_info }}
                @else
                    {{ $user->HOTEN }}
                @endif.
            </p>
            <p>Cảm ơn bạn đã đặt phòng tại khách sạn của chúng tôi.</p>
            <p>Đây là danh sách phòng bạn đã đặt:</p>
            <div class="ticket-details">
                <table>
                    <thead>
                        <tr>
                            <th>Loại phòng</th>
                            <th>Ngày nhận phòng</th>
                            <th>Ngày trả phòng</th>
                            <th>Thanh toán</th>
                            <th>Số lượng</th>
                            <th>Tình trạng</th>
                            <th>Mã pin phòng</th>
                        </tr>
                    </thead>
                    <tbody>
                        @foreach ($bookingDetails as $detail)
                            <tr>
                                <td>{{ $detail['roomType'] }}</td>
                                <td>{{ $detail['checkIn'] }}</td>
                                <td>{{ $detail['checkOut'] }}</td>
                                <td>{{ number_format($detail['payment']) }} VNĐ</td>
                                <td>{{ $detail['quantity'] }}</td>
                                <td>{{ $detail['status'] }}</td>
                                <td>{{ $detail['code'] }}
                            </tr>
                        @endforeach
                    </tbody>
                </table>
            </div>
            <p class="mt-4">Chúng tôi rất mong gặp bạn tại khách sạn! Vui lòng đến đúng ngày để nhận phòng</p>
            <p>Thời gian nhận phòng bắt đầu từ 14 giờ chiều và thời gian trả phòng sau cùng là 12 giờ trưa</p>
        </div>
        <div class="footer">
            &copy; {{ date('Y') }} KS-GTX. All rights reserved.
        </div>
    </div>
</body>
</html>
