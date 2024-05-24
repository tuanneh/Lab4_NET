CREATE TABLE ThongTinNguoiDung (
    TaiKhoan NVARCHAR(50),
    MatKhau NVARCHAR(50),
    SoTien INT,
    ThoiGianSuDung TIME,
    ThoiGianConLai TIME
);


CREATE TABLE ThongTinMay (
    SoMay INT PRIMARY KEY,
    TrangThai BIT,
    TaiKhoan NVARCHAR(50)
);


INSERT INTO ThongTinNguoiDung (TaiKhoan, MatKhau, SoTien, ThoiGianSuDung, ThoiGianConLai) 
VALUES 
    ('tuan', '123', 1000000, '00:30:00', '01:45:00'),
    ('kiet', '123', 500000, '00:15:00', '02:00:00'),
    ('hoang', '123', 2000000, '01:00:00', '01:15:00');

INSERT INTO ThongTinMay (SoMay, TrangThai, TaiKhoan) 
VALUES 
    ('1', '1','kiet'),
    ('2', '1', 'tuan'),
    ('3', '0','hoang');

SELECT * FROM ThongTinNguoiDung;
SELECT * FROM ThongTinMay;


