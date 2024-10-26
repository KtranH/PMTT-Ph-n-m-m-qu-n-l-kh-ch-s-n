<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GTX Hotel - Xác thực Email</title>
    <style>
        body {
            font-family: 'Segoe UI', Arial, sans-serif;
            line-height: 1.6;
            color: #2d3748;
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #f7fafc;
        }
        .email-container {
            background-color: #ffffff;
            padding: 40px;
            border-radius: 16px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.05);
        }
        .header {
            text-align: center;
            margin-bottom: 40px;
            padding-bottom: 20px;
            border-bottom: 2px solid #f0f4f8;
        }
        .logo {
            width: 120px;
            height: auto;
            margin-bottom: 24px;
        }
        .welcome-text {
            font-size: 28px;
            color: #1a365d;
            margin: 0;
            font-weight: 600;
        }
        .content {
            margin-bottom: 35px;
            font-size: 16px;
            color: #4a5568;
            line-height: 1.8;
        }
        .verification-code {
            background-color: #EDF2F7;
            padding: 20px;
            border-radius: 12px;
            text-align: center;
            margin: 30px 0;
        }
        .code {
            font-family: 'Courier New', monospace;
            font-size: 32px;
            letter-spacing: 8px;
            color: #4199FD;
            font-weight: bold;
            background-color: white;
            padding: 15px 30px;
            border-radius: 8px;
            border: 2px solid #E2E8F0;
            display: inline-block;
        }
        .note {
            font-size: 14px;
            color: #718096;
            margin-top: 20px;
            font-style: italic;
        }
        .footer {
            text-align: center;
            margin-top: 40px;
            padding-top: 20px;
            border-top: 2px solid #f0f4f8;
            font-size: 13px;
            color: #718096;
        }
        .footer p {
            margin: 5px 0;
        }
        .hotel-name {
            color: #4199FD;
            font-weight: 600;
        }
        .divider {
            height: 1px;
            width: 50px;
            background-color: #E2E8F0;
            margin: 15px auto;
        }
    </style>
</head>
<body>
    <div class="email-container">
        <div class="header">
            <img src="https://www.logoai.com/uploads/output/2024/01/29/569e6945d915e970c13e6d9d28786ddb.jpg" alt="GTX Hotel Logo" class="logo">
            <h1 class="welcome-text">Xin chào {{ $detail['name'] }}!</h1>
        </div>
        
        <div class="content">
            <p>Cảm ơn bạn đã đăng ký tài khoản tại GTX Hotel.</p>
            <p>Để hoàn tất quá trình đăng ký, vui lòng sử dụng mã xác thực dưới đây:</p>
            
            <div class="verification-code">
                <div class="code">{{ $detail['code'] }}</div>
                <p class="note">Mã xác thực có hiệu lực trong vòng 10 phút</p>
            </div>
            
            <p>Nếu bạn không thực hiện yêu cầu này, vui lòng bỏ qua email này.</p>
        </div>
        
        <div class="footer">
            <p class="hotel-name">GTX HOTEL</p>
            <div class="divider"></div>
            <p>140 Đ. Lê Trọng Tấn, Tây Thạnh, Tân Phú</p>
            <p>Thành phố Hồ Chí Minh, Việt Nam</p>
            <div class="divider"></div>
            <p>© 2024 GTX Hotel. Mọi quyền được bảo lưu.</p>
        </div>
    </div>
</body>
</html>