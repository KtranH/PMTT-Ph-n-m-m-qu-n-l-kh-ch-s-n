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
    <div class="email-container">
        <div class="header">
            Xác nhận đặt phòng
        </div>
        <div class="content">
            <p>Xin chào {{ $user->HOTEN }},</p>
            <p>Cảm ơn bạn đã đặt phòng tại khách sạn của chúng tôi. Đây là danh sách phòng bạn đã đặt:</p>
            <div class="ticket-details">
                <table>
                    <tr>
                        <th>Loại phòng</th>
                        <td>{{ $roomType }}</td>
                    </tr>
                    <tr>
                        <th>Ngày nhận phòng</th>
                        <td>{{ $checkIn }}</td>
                    </tr>
                    <tr>
                        <th>Ngày trả phòng</th>
                        <td>{{ $checkOut }}</td>
                    </tr>
                    <tr>
                        <th>Đã thanh toán</th>
                        <td>{{ $payment }}</td>
                    </tr>
                    <tr>
                        <th>Tình trạng</th>
                        <td>{{ $status }}</td>
                    </tr>
                </table>
            </div>
            <p>Chúng tôi rất mong gặp bạn tại khách sạn! Vui lòng đến đúng ngày để nhận phòng</p>
            <p>Thời gian nhận phòng bắt đầu từ 14 giờ chiều và thời gian trả phòng sau cùng là 12 giờ trưa</p>
        </div>
        <div class="footer">
            &copy; {{ date('Y') }} KS-GTX. All rights reserved.
        </div>
    </div>
</body>
</html>
