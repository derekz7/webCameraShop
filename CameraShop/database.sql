create database csdl
go
use csdl
go
create table DanhMuc(
	MaLoai int identity(1,1) primary key,
	TenLoai ntext,
	GhiChu NTEXT,
    Anh TEXT
)
go
create table SanPham(
	MaSP int identity(1,1) primary key,
	TenSP ntext,
	MoTa ntext,
	DonGia int,
	SoLuong int,
	MaLoai int constraint fk_maloai foreign key(MaLoai) references DanhMuc(MaLoai),
	Anh ntext
)

INSERT dbo.DanhMuc(TenLoai,GhiChu,Anh) VALUES (N'Camera',N'Camera nhiếp ảnh','https://cdn.pixabay.com/photo/2020/04/16/16/14/dslr-5051265_1280.jpg')
INSERT dbo.DanhMuc(TenLoai,GhiChu,Anh) VALUES (N'Lens máy ảnh',N'Lens máy ảnh các loại','https://1.img-dpreview.com/files/p/E~C0x657S7000x3938T1200x675~articles/9162056837/2021/Lens_Lineup.jpeg')
INSERT dbo.DanhMuc(TenLoai,GhiChu,Anh) VALUES (N'Phụ kiện camera',N'Phụ kiện cho camera','https://cdn.vjshop.vn/tin-tuc/top-10-phu-kien-nhiep-anh-hang-dau-ban-nen-co/phu-kien-2.jpg')
GO
INSERT dbo.SanPham(TenSP,MoTa,DonGia,SoLuong,MaLoai,Anh)VALUES(N'Máy ảnh Nikon Z6 Body',N'Máy ảnh Nikon Z6 được trang 
bị cảm biến Full-frame BSI CMOS 24.5MP và bộ xử lý 
hình ảnh EXPEED 6 mới nhất cho hình ảnh chi tiết, khả năng khử nhiễu cực tốt ở ISO cao cho chất lượng ảnh tuyệt vời.
Bộ xử lý hình ảnh EXPEED 6 cho tốc độ xử lý nhanh chóng với khả năng chụp liên tiếp 12 ảnh/giây, đây là một con số khá 
lớn đối với một chiếc máy ảnh fullframe',
28000000,45,1,'https://cdn.vjshop.vn/may-anh/mirrorless/nikon/nikon-z6/nikon-z6-1-3-500x500.jpg')

INSERT dbo.SanPham(TenSP,MoTa,DonGia,SoLuong,MaLoai,Anh)VALUES(N'Máy ảnh Canon EOS R5 (Body Only)',N'Canon EOS R5 sở hữu cảm biến Full-frame 45MP do chính Canon thiết kế và phát triển, cung cấp hình ảnh và video với độ phân giải cao. Bộ vi xử lý DIGIC X xuất hiện trên chiếc 1DX III cũng được sử dụng cho EOS R5, đem đến khả năng đọc và xử lý dữ liệu nhanh chóng. Dải ISO 100 - 51200 (có thể mở rộng thành 100 - 102400) hỗ trợ chụp ảnh trong những điều kiện ánh sáng khác nhau. Bộ xử lý hình ảnh này giúp chiếc máy có thể chụp liên tục 12 hình/giây với màn trập cơ hoặc 20 hình/giây với màn trập điện tử, hỗ trợ người dùng bắt gọn từng khoảnh khắc, từng chuyển động.',
86000000,45,1,'https://cdn.vjshop.vn/may-anh/mirrorless/canon/canon-eos-r5/canon-eos-r5-1-500x500.jpg')

INSERT dbo.SanPham(TenSP,MoTa,DonGia,SoLuong,MaLoai,Anh)VALUES(N'
Ống kính Canon RF 28-70mm F/2 L USM',N'Ống kính Canon ngàm RF tiêu cự 28-70mm, khẩu độ F/2 
Là ống kính zoom tele góc rộng được thiết kế dành cho dòng máy ảnh mirrorless Full-frame của Canon, có khẩu độ lớn F/2, chiếc lens này cho phép lượng ánh sáng đi vào ống kính nhiều hơn, hỗ trợ chụp ảnh sáng rõ trong điều kiện môi trường thiếu sáng, đồng thời tăng cường khả năng kiểm soát độ sâu trường ảnh, làm rõ chủ thể và tách hậu cảnh rõ ràng hơn.',
79000000,45,2,'https://cdn.vjshop.vn/ong-kinh/mirrorless/canon/canon-rf-28-70mm-f2-l-usm/anh-mo-ta/ong-kinh-canon-rf-28-70mm-f2-l-usm-1.jpg')

INSERT dbo.SanPham(TenSP,MoTa,DonGia,SoLuong,MaLoai,Anh)VALUES(N'Gimbal DJI Ronin-S | Chính hãng',N'DJI Ronin-S mang đến cho các nhà làm phim độc lập khả năng ghi lại những khoảnh khắc rõ nét, mượt mà và góc quay mới mẻ. SmoothTrack trên Gimbal được áp dụng cho cả 3 trục, bạn có thể giữ nút kích hoạt phía trước để chuyển từ Chế độ Upright sang Chế độ Underslung ngay lập tức. Chế độ thể thao mới cho phép bạn chụp những cảnh chuyển động nhanh ngay lập tức mà không lo bỏ lỡ một khoảnh khắc nào.',
12450000,35,3,'https://cdn.vjshop.vn/thiet-bi-lam-video/gimbal/dji/dji-ronin-s-gimbal-chong-rung-cho-may-anh/dji-ronin-s-1.jpg')

INSERT dbo.SanPham(TenSP,MoTa,DonGia,SoLuong,MaLoai,Anh)VALUES(N'Máy ảnh Canon EOS R6 + Lens 24-105mm f/4-7.1',N'Canon EOS R6 là phiên bản rút gọn của Canon EOS R5, cũng cấp một loạt công cụ nhằm đáp ứng các nhu cầu chụp ảnh và quay video chất lượng cao. Máy ảnh Full-frame mirrorless Canon R6 được xây dựng trên nền tảng cảm biến CMOS 20MP tinh tế, bộ xử lý hình ảnh DIGIC X, cùng hệ thống ổn định hình ảnh IBIS lên tới 8 stop và một số tính năng khác. Tất cả đều được thiết kế để đem lại hiệu suất hoạt động tối ưu nhất cho chiếc máy.',
62880000,56,1,'https://cdn.vjshop.vn/may-anh/mirrorless/canon/canon-eos-r6/canon-eos-r6-with-24-105-f4-71-lens-2-500x500.jpg')