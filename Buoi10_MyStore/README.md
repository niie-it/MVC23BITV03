## Sử dụng CSDL MyEStore tạo project theo hướng Database First để thực hiện:

# A. CRUD Loại, Hàng Hóa (Lab 06)

# B. Tìm kiếm (Lab 07)

# C. Tạo thêm API kèm swagger (Lab 09)

# D. Tạo Authentication & Authorization (Lab08 phần B)
1. Mở Program.cs và thêm đoạn code sau vào trước dòng `builder.Build();`:
```csharp
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.Cookie.Name = "MyCookieAuth";
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/access-denied";
    });
builder.Services.AddAuthorization();
```
/login, /access-denied là các endpoint mà bạn sẽ tạo ra để xử lý đăng nhập và truy cập bị từ chối.

và thêm dòng lệnh sau trước ```app.UseAuthorization()```:
```
app.UseAuthentication();
```