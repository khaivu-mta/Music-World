using ASPMVC_WebNgheNhac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPMVC_WebNgheNhac
{
    public enum DbTable
    {
        BANNHAC,
        DANHSACHNHAC,
        DANHSACHNHAC_BANNHAC,
        NGUOIDUNG,
        NGUOIDUNG_DANHSACHNHAC,
        QUYENTRUYCAP,
        THELOAI,
        THELOAI_BANNHAC,
    }
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DbMusicWebsite db = new DbMusicWebsite();
            if (db.Database.CreateIfNotExists())
            {
                db.Database.ExecuteSqlCommand(@"CREATE PROCEDURE PROC_CreateDefaultRecord AS BEGIN
SET IDENTITY_INSERT [dbo].[THELOAI] ON 

INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (1, N'Pop')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (2, N'Rock')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (3, N'Jazz')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (4, N'Blues')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (5, N'Hip hop')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (6, N'R&B/Soul')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (7, N'Nhạc đồng quê')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (8, N'Nhạc điện tử')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (9, N'Folk đương đại')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (10, N'Nhạc dance')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (11, N'Avant-Garde')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (12, N'Nhạc dễ nghe')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (13, N'Mỹ Latinh')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (14, N'Brasil')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (15, N'Caribe')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (16, N'Châu Phi')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (17, N'Châu Á')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (18, N'EDM')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (19, N'Epic')
SET IDENTITY_INSERT [dbo].[THELOAI] OFF
SET IDENTITY_INSERT [dbo].[BANNHAC] ON 

INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (1, N'Nắng Ấm Xa Dần', N'Sơn tùng', 4, 4, 48000, N'mp3', 2012, N'/Assets/files/Dynasty - MIIA.mp3', N'/Assets/images/1.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (2, N'Thái Bình Mồ Hôi Rơi', N'Sơn tùng', 6, 6, 48000, N'mp3', 2012, N'/Assets/files/Falling Apart - Michael Schulte.mp3', N'/Assets/images/1.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (3, N'Âm Thầm Bên Em', N'Sơn tùng', 7, 3, 48000, N'mp3', 2014, N'/Assets/files/I Miss You - Czarina.mp3', N'/Assets/images/2.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (4, N'Không Phải Dạng Vừa Đâu', N'Sơn tùng', 6, 11, 48000, N'mp3', 2014, N'/Assets/files/In The End - Linkin Park (Mellen Gi & Tommee Profitt Remix).mp3', N'/Assets/images/3.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (5, N'Em Của Ngày Hôm Qua', N'Sơn tùng', 4, 3, 48000, N'mp3', 2012, N'/Assets/files/Right Now (Na Na Na) - Am1r (cover).mp3', N'/Assets/images/4.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (6, N'Buông Đôi Tay Nhau Ra', N'Sơn tùng', 5, 7, 36000, N'mp3', 2014, N'/Assets/files/Runnin'' - Adam Lambert.mp3', N'/Assets/images/5.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (7, N'Như Ngày Hôm Qua', N'Sơn tùng', 7, 7, 36000, N'mp3', 2016, N'/Assets/files/Thanh Xuân - Da LAB.mp3', N'/Assets/images/6.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (8, N'Anh Ơi Ở Lại', N'Chi Pu', 4, 9, 12000, N'mp3', 2012, N'/Assets/files/The anser - Fang Yu Jie (Đáp án - Phương Vũ Kiệt).mp3', N'/Assets/images/7.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (9, N'Người Nào Hay', N'Chi Pu', 5, 12, 12000, N'mp3', 2012, N'/Assets/files/Never Give Up On Your Dreams - Two Steps From Hell.mp3', N'/Assets/images/8.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (10, N'Tiểu Thư Cá Tính', N'Chi Pu', 7, 8, 36000, N'mp3', 2012, N'/Assets/files/Protectors Of The Earth Cinematic - Two Steps From Hell.mp3', N'/Assets/images/9.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (11, N'Vườn Cây Của Ba', N'Xuân Mai', 4, 11, 12000, N'mp3', 2014, N'/Assets/files/Two Steps From Hell - Heart Of Courage.mp3', N'/Assets/images/10.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (12, N'Gió Mùa Xuân Tới', N'Xuân Mai', 4, 11, 48000, N'mp3', 2016, N'/Assets/files/Victory - Two Steps From Hell.mp3', N'/Assets/images/10.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (13, N'Quả Gì', N'Xuân Mai', 4, 12, 12000, N'mp3', 2014, N'/Assets/files/Symphony-RobinHustin-Remix.mp3', N'/Assets/images/10.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (14, N'Rửa Mặt Như Mèo', N'Xuân Mai', 7, 11, 48000, N'mp3', 2016, N'/Assets/files/Dancin - Aaron Smith (KRONO Remix).mp3', N'/Assets/images/10.jpg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [TacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh]) VALUES (15, N'Never Give Up On Your Dreams', N'Two Steps From Hell', 5501, 320, 48000, N'mp3', 2014, N'/Assets/files/NeverGiveUpOnYourDreams-TwoStepsFromHell.mp3', N'/Assets/images/10.jpg')
SET IDENTITY_INSERT [dbo].[BANNHAC] OFF
SET IDENTITY_INSERT [dbo].[DANHSACHNHAC] ON 

INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (1, N'Con nòng nọc', CAST(0x0000AA4B00000000 AS DateTime), N'/Assets/images/stay_close_by_softyrider62-dami1hw.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (2, N'Con thằn lằn', CAST(0x0000AA4C00000000 AS DateTime), N'/Assets/images/surface-planet-galaxy-22522-.jpeg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (3, N'Con bìm bịp', CAST(0x0000AA4D00000000 AS DateTime), N'/Assets/images/anime-girl-school-uniform-back-view-clouds-buildings-sunlight.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (4, N'Con kiến', CAST(0x0000AA4E00000000 AS DateTime), N'/Assets/images/35749742_840863186110638_3992857900534988800_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (5, N'Con thạch sùng', CAST(0x0000AA4F00000000 AS DateTime), N'/Assets/images/index.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (6, N'Con châu chấu', CAST(0x0000AA5000000000 AS DateTime), N'/Assets/images/36632325_2112581568812386_3206334493967253504_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (7, N'Con bọ ngựa', CAST(0x0000AA5100000000 AS DateTime), N'/Assets/images/index.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (8, N'Con muỗi', CAST(0x0000AA5200000000 AS DateTime), N'/Assets/images/36632325_2112581568812386_3206334493967253504_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (9, N'Con dế', CAST(0x0000AA5300000000 AS DateTime), N'/Assets/images/35749742_840863186110638_3992857900534988800_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (10, N'Con ong', CAST(0x0000AA5400000000 AS DateTime), N'/Assets/images/city_skyscrapers_clouds_rain_road_cars_lights_58563_3840x2160.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (11, N'Con chim', CAST(0x0000AA5500000000 AS DateTime), N'/Assets/images/anime-girl-school-uniform-back-view-clouds-buildings-sunlight.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (12, N'Con mèo', CAST(0x0000AA5600000000 AS DateTime), N'/Assets/images/photo-1533770699395-5761e5d08106.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (13, N'Con chó', CAST(0x0000AA5700000000 AS DateTime), N'/Assets/images/35749742_840863186110638_3992857900534988800_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (14, N'Con ngựa', CAST(0x0000AA5800000000 AS DateTime), N'/Assets/images/city_skyscrapers_clouds_rain_road_cars_lights_58563_3840x2160.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (15, N'Con dê', CAST(0x0000AA5900000000 AS DateTime), N'/Assets/images/photo-1533770699395-5761e5d08106.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [NgayTao], [DuongDanAnh]) VALUES (16, N'Con ba ba', CAST(0x0000AA5A00000000 AS DateTime), N'/Assets/images/photo-1533770699395-5761e5d08106.jpg')
SET IDENTITY_INSERT [dbo].[DANHSACHNHAC] OFF
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (1, 1)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (1, 2)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (1, 3)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (1, 4)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (1, 5)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (2, 2)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (2, 3)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (2, 4)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (3, 1)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (3, 3)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (3, 4)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (4, 1)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (4, 2)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (4, 5)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (5, 6)
INSERT [dbo].[DANHSACHNHAC_BANNHAC] ([MaDanhSach], [MaBanNhac]) VALUES (5, 7)
SET IDENTITY_INSERT [dbo].[QUYENTRUYCAP] ON 

INSERT [dbo].[QUYENTRUYCAP] ([MaQuyenTruyCap], [TenQuyenTruyCap]) VALUES (-1, N'Không xác định')
INSERT [dbo].[QUYENTRUYCAP] ([MaQuyenTruyCap], [TenQuyenTruyCap]) VALUES (0, N'Người dùng')
INSERT [dbo].[QUYENTRUYCAP] ([MaQuyenTruyCap], [TenQuyenTruyCap]) VALUES (1, N'Admin')
SET IDENTITY_INSERT [dbo].[QUYENTRUYCAP] OFF
INSERT [dbo].[NGUOIDUNG] ([Email], [MatKhau], [HoTen], [DuongDanAnh], [MaQuyenTruyCap]) VALUES (N'admin@email.com', N'admin', N'Vũ Quang Khải', NULL, 1)
INSERT [dbo].[NGUOIDUNG] ([Email], [MatKhau], [HoTen], [DuongDanAnh], [MaQuyenTruyCap]) VALUES (N'khaivu@gmail.com', N'admin', N'Vũ Quang Khải', NULL, 1)

END");
                db.Database.ExecuteSqlCommand("EXECUTE PROC_CreateDefaultRecord");
            }
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
