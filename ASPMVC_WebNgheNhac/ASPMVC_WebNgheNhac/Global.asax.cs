using ASPMVC_WebNgheNhac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPMVC_WebNgheNhac
{
    public enum MyTable
    {
        BANNHAC,
        DANHSACHNHAC,
        DANHSACHNHAC_BANNHAC,
        NGUOIDUNG,
        NGUOIDUNG_DANHSACHNHAC,
        QUYENTRUYCAP,
        TACGIA,
        TACGIA_BANNHAC,
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
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (1, N'Adam Lambert', CAST(0x0000751A00000000 AS DateTime), CAST(0x0000964700000000 AS DateTime), 25, N'Adam Lambert được sinh ra tại Indianapolis, Indiana vào ngày 29 tháng 1 năm 1982. Mẹ là Leila Mitchel, một nhà thiết kế nội thất, và cha - Eber Lambert, một người quản lý chương trình cho Novatel Wireless. Anh có một người em trai, Neil. Cha của Adam là người gốc Na Uy và mẹ là người Do Thái gốc Rômania. Lambert được nuôi lớn trong tôn giáo của mẹ và từ đó mà anh đã thực hiện một số sự kiện của người Do thái bằng tiếng Hewbrew, hát những bài hát như *Shir LaShalom* tại 1 buổi hòa nhạc tưởng nhớ Thủ tướng Yitzhak Rabin bị ám sát của Israel và biểu diễn tại San Diego *Ngôi Đền của Nghệ thuật* nhiều lần.

Ít lâu sau khi Lambert ra đời, gia đình anh di chuyển đến California khi 1 cơ hội việc làm mở ra cho cha anh tại San Diego. Lúc đầu, họ sống ở Rancho Bernardo--115.77.4.115 (thảo luận) 08:51, ngày 14 tháng 2 năm 2012 (UTC)--115.77.4.115 (thảo luận) 08:51, ngày 14 tháng 2 năm 2012 (UTC) nhưng chuyển đến Peñasquitos Rancho sau khi em trai của anh đã được sinh ra. Từ khi bắt đầu học tại Trường tiểu học Deer Canyon, Lambert bắt đầu diễn tại Nhà hát Metropolitan từ khi chín tuổi và xuất hiện trong các vở kịch địa phương như: You''re a Good Man, Charlie Brown, và Fiddler on the Roof. Khoảng thời gian này, Lambert cũng bắt đầu được luyện giọng và tiếp tục niềm đam mê của mình khi anh bắt đầu học tại trường trung học cơ sở Mesa Verde.

Trong khi đang học tại trường cấp 3 Mount Carmel (MCHS), Lambert càng bị ảnh hưởng bởi nhà hát và dàn hợp xướng, anh thường xuyên biểu diễn với ban nhạc jazz của trường Jazz MC. Sau khi tốt nghiệp vào năm 2000, ông chuyển đến Orange County để học đại học. Ngay sau khi ghi danh Lambert đã có một sự thay đổi trong trái tim, thúc đẩy bởi mong muốn mãnh liệt của mình. Và anh bỏ học chỉ sau năm tuần và chuyển đến Los Angeles. *Tôi quyết định rằng những gì tôi thực sự muốn làm là cố gắng làm việc trong thế giới giải trí,* anh nói. *Cuộc sống là chấp nhận tất cả những rủi ro để có được những gì bạn muốn.*', N'/Assets/images/Adam-Lambert300x300.jpg', N'https://g.co/kgs/SNnyfW', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (2, N'Da LAB', CAST(0x0000808400000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 34, NULL, N'/Assets/images/1535121377317.jpg', N'https://g.co/kgs/45EM7F', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (3, N'Am1r', CAST(0x00008BEE00000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 54, NULL, N'/Assets/images/1527581834391.jpg', N'https://en.wikipedia.org/wiki/Right_Now_(Na_Na_Na)', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (4, N'Linkin Park', CAST(0x0000A15500000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 60, N'Linkin Park là một ban nhạc rock ở Agoura Hills, California. Họ là ban nhạc nổi tiếng và thành công nhất của thể loại nu metal, chủ yếu do album đầu tiên, Hybrid Theory năm 2000, đã bán được 24 triệu bản trên thế giới[1], trở thành ban nhạc có một trong những album được bán ra nhiều nhất thế kỷ 21[2][3]. Họ tiếp tục thành công với album Meteora, đứng đầu bảng xếp hạng album Billboard 200 năm 2003. Năm 2003, MTV xếp họ vào 6 nhóm nhạc rock đứng đầu kỷ nguyên music video và 3 nhóm nhạc rock thành công nhất của kỷ nguyên mới, chỉ sau Oasis và Coldplay[cần dẫn nguồn].

Mặc dù được công chúng yêu thích với phong cách nu metal và rap metal trong hai album Hybrid Theory và Meteora, nhóm nhạc đã khám phá thêm nhiều thể loại nữa trong album phòng thu tiếp theo của họ, Minutes to Midnight phát hành năm 2007. Album đứng đầu các bảng xếp hạng Billboard và được bán ra nhiều nhất trong tuần đầu tiên. Nhóm nhạc còn hợp tác với nhiều nghệ sĩ khác, đáng chú ý nhất là hợp tác với rapper Jay-Z trong album phối lại của họ Collision Course phát hành năm 2004, và rất nhiều nghệ sĩ trong album phối lại đầu tay Reanimation phát hành năm 2002. Album mới đây nhất của nhóm, A Thousand Suns được ra mắt vào 8 tháng 9 năm 2010, đã đứng đầu trong bảng xếp hạng Billboard 200 và được bán ra nhiều nhất trong tuần liền. Kể từ khi thành lập năm 1996, họ đã bán được tổng cộng khoảng trên 50 triệu album và thắng 2 giải Grammy', N'/Assets/images/1489737693366.jpg', N'https://g.co/kgs/51BQEa', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (5, N'Michael Schulte', CAST(0x0000A59C00000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 29, NULL, N'/Assets/images/1461816519441.jpg', N'https://g.co/kgs/93jqRR', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (6, N'MIIA', CAST(0x0000A2F700000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 30, NULL, N'/Assets/images/avatar_default.jpg', N'https://g.co/kgs/HtV4hV', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (7, N'Sơn Tùng', CAST(0x0000808400000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 45, N'Nguyễn Thanh Tùng hay được biết đến với nghệ danh Sơn Tùng M-TP (sinh ngày 5 tháng 7 năm 1994) là một ca sĩ, nhạc sĩ và diễn viên người Việt Nam.

Các đĩa đơn năm 2012 và 2013 của anh, *Cơn mưa ngang qua* và *Em của ngày hôm qua* đã đánh dấu mốc khởi đầu cho sự nghiệp của anh. Vào năm 2017, anh nhận được sự công nhận thiện chí hơn từ cộng đồng mạng sau khi phát hành hai đĩa đơn *Lạc trôi* và *Nơi này có anh*. Sơn Tùng cũng cho ra mắt album tổng hợp m-tp M-TP vào cùng năm và cuốn tự truyện Chạm tới giấc mơ.

Tùng đã có hơn bốn năm gắn bó với các hãng thu âm Văn Production và WePro Entertainment cho đến khi hãng thu âm của anh, M-TP Entertainment, được thành lập vào cuối năm 2016. Anh khởi động chuyến lưu diễn hòa nhạc đầu tiên, mang tên M-TP Ambition - Chuyến bay đầu tiên, vào năm 2015 và kết thúc vào năm 2016. Anh còn đóng vai chính trong bộ phim chiếu rạp năm 2014 Chàng trai năm ấy, và nhận được một Giải Cánh diều vàng cho hạng mục Diễn viên trẻ triển vọng cho phần diễn xuất của mình. Năm 2015, anh xuất hiện với vai trò là thí sinh trong chương trình âm nhạc Hòa âm Ánh sáng. Vào tháng 7 năm 2018, đạo diễn Nguyễn Quang Dũng cùng Bitis Hunter kết hợp làm ra một bộ phim ngắn “Chuyến đi của thanh xuân” và Sơn Tùng M-TP đảm nhận một vai khách mời trong bộ phim. Được mệnh danh là *Hoàng tử V-pop*, Sơn Tùng M-TP đã nhận được nhiều giải thưởng bao gồm một Giải thưởng Âm nhạc Cống hiến, một Giải Âm nhạc châu Âu của MTV, một Giải Mnet Asian Music Awards, bảy Giải Làn Sóng Xanh và được đưa vào danh sách 30 Under 30 của tạp chí Forbes Vietnam (danh sách tôn vinh 30 gương mặt nổi bật có độ tuổi dưới 30 trong các lĩnh vực như kinh doanh, khởi nghiệp công nghệ, hoạt động xã hội, khoa học công nghệ, giáo dục, nghệ thuật, giải trí, thể thao tại Việt Nam)', N'/Assets/images/1.jpg', N'https://g.co/kgs/vRxQM2', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (8, N'Chi Pu', CAST(0x0000808400000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 20, NULL, N'/Assets/images/8.jpg', N'https://g.co/kgs/YmPC63', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (9, N'Xuân Mai', CAST(0x0000808400000000 AS DateTime), CAST(0x0000808400000000 AS DateTime), 57, NULL, N'/Assets/images/10.jpg', N'https://g.co/kgs/z8HV59', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (10, N'Two Steps From Hell', CAST(0x0000808400000000 AS DateTime), CAST(0x0000A59C00000000 AS DateTime), 70, N'Two Steps from Hell chủ yếu sản xuất nhạc trailer, mặc dù gần đây các bản nhạc của họ cũng được dùng cho các chương trình truyền hình và một số video game.

Mặc dù công ty luôn tìm kiếm sự thành công cho các bản nhạc của mình, mãi cho đến tháng 5 năm 2010 các bản nhạc mới lần đầu chính thức phát hành ra công chúng, khi album thương mại Invincible được phát hành. Invincible trở thành album đầu tiên của công ty lọt vào bảng xếp hạng Top 100 Soundtracks của iTunes.[1] Tính đến tháng 7 năm 2014, Two Steps from Hell đã xuất bản 8 album tới công chúng, trong số hơn 20 album trình diễn, với gần 1.000 bản nhạc.

Album Sun, được phát hành vào 30 tháng 9 năm 2014, là album solo thứ hai của Thomas Bergersen. Bản nhạc âm xem trước được phát hành từ album có tên Cry và Sun, có thể tải về từ website chính thức của Bergersen.[5] Một MV chính thức cho Sun cũng được phát hành trên YouTube,[6] trước khi Thomas công bố việc phát hành giới hạn một bản CD cao cấp có các bản nhạc âm mở rộng cũng như ghi chú từ chính Thomas, cũng như một tấm poster khổ rộng là một tác phẩm nghệ thuật của anh.[7]

Ngoài ra, vào tháng 7 năm 2014, Two Steps from Hell phát hành một cuốn e-book với tên Colin Frake on Fire Mountain, có tính năng như một cuốn tiểu thuyết 75.000 từ, được viết bởi Nick Phoenix và minh họa bởi Otto Bjornik, và phần nhạc của cuốn sách cũng được phát hành dưới dạng một album soundtrack.[8]

Họa sĩ thiết kế đồ họa chính của Two Steps from Hell là Steven Gilmore,[9] người đã tạo bìa album cho hầu hết các bản quảng cáo và các album được phát hành ra công chúng, bao gồm cả logo công ty, với một ngoại lệ duy nhất là đĩa DVD được phát hành vào năm 2009, bìa album đó đã được thiết kế bởi Paul Zeaiter.[10] Ngoài ra, đồ họa trong album solo Illusions của Thomas Bergersen được thiết kế bởi Jesper Krijgsman,[11] trong khi phần tiếp theo Sun, bìa album được thiết kết bởi chính Thomas.', N'/Assets/images/avatar_default.jpg', N'https://g.co/kgs/PBUHrD', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [NgaySinh], [NgayBatDau], [SoLuongBaiHat], [GioiThieu], [DuongDanAnh], [LienKet], [HienThiTrenTrangChu]) VALUES (11, N'Elle Fanning', CAST(0x00008C3400000000 AS DateTime), CAST(0x0000A59C00000000 AS DateTime), 12, N'Fanning bắt đầu sự nghiệp diễn xuất với những vai thời thơ ấu của chị gái khi 2 tuổi trong hai phim ngắn *Taken* và phim điện ảnh *I Am Sam*. Năm 4 tuổi, Fanning có vai chính đầu tiên để thoát khỏi cái bóng đóng thế cho chị gái là phim hài *Daddy Day Care*.

Cho đến năm 2003, Elle tham gia *The Door in the Floor* cùng Jeff Bridges và Kim Basinger.Cuối năm 2003, Fanning tham gia phim Because of Winn-Dixie với vai phụ Sweetie Pie Thomas. Năm 2004, cô đã lồng tiếng phiên bản tiếng Anh cho phim hoạt hình My Neighbor Totoro của Miyazaki trong vai Mei. Cùng năm đó, cô cũng đóng I Want Someone To Eat Cheese With.

Đầu năm 2005, Elle tham gia vài cảnh trong *Charlotte''s Web* với vai *cháu gái tương lai* của Fern Arable do chị gái Dakota thủ vai. Nhưng cuối cùng cảnh này đã bị cắt. Giữa năm 2005, Elle vào vai Debbie, con gái của Brad Pitt và Cate Blanchett được giành đề cử giải Giải thưởng Oscar trong phim *Babel*. Đầu năm 2006, cô bé góp mặt trong cả hai phim *The Nines* và Déjà Vu. Giữa năm 2006 là phim ngắn về đề tài khoa học viễn tưởng *The Lost Room*.


Elle Fanning trong buổi họp báo giữa năm 2014 tại San Diego Convention Center tại San Diego, California.
Đến cuối năm 2006, Elle dần được yêu mến qua các vai chính. Vai chính đầu tiên trong *Reservation Road* là Emma Learner, vai con gái của Joaquin Phoenix và Jennifer Connelly. Bộ phim kết thúc với tai nạn thảm khốc và em trai của Emma đã tử nạn. Cuối năm 2008, cô tham gia phim The Curious Case of Benjamin Button với vai thời thơ ấu của Cate Blanchett. Giữa năm 2007, cô bé trở lại trong Phoebe in Wonderland vai Phoebe. Câu chuyện kể về 1 cô bé không thể tuân theo và muốn phá vỡ mọi nguyên tắc cứng nhắc. Phim có sự tham gia của Felicity Huffman ra mắt khán giả vào tháng 3 năm 2009.', N'/Assets/images/elle-fanning_640x640y.jpg', N'https://vi.wikipedia.org/wiki/Elle_Fanning', 1)
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
SET IDENTITY_INSERT [dbo].[BANNHAC] ON 

INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (1, N'Runnin''', 1, 4, 228, 48000, N'mp3', 2012, N'/Assets/files/Falling Apart - Michael Schulte.mp3', N'/Assets/images/Adam-Lambert152x152.jpg', N'https://www.youtube.com/watch?v=KoJW3ob0Xt8')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (2, N'Thanh Xuân', 2, 4, 228, 48000, N'mp3', 2014, N'/Assets/files/Protectors Of The Earth Cinematic - Two Steps From Hell.mp3', N'/Assets/images/Music_player_logo152x152.png', N'https://www.youtube.com/watch?v=GgQFO8dL5XQ')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (3, N'Right Now (Na Na Na)', 3, 4, 228, 48000, N'mp3', 2012, N'/Assets/files/The anser - Fang Yu Jie (Đáp án - Phương Vũ Kiệt).mp3', N'/Assets/images/Music_player_logo152x152.png', N'https://www.youtube.com/watch?v=h_CEubK2qY8')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (4, N'In The End', 4, 4, 228, 48000, N'mp3', 2014, N'/Assets/files/NeverGiveUpOnYourDreams-TwoStepsFromHell.mp3', N'/Assets/images/Music_player_logo152x152.png', N'https://www.youtube.com/watch?v=WNeLUngb-Xg')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (5, N'Falling Apart', 5, 4, 228, 48000, N'mp3', 2016, N'/Assets/files/Right Now (Na Na Na) - Am1r (cover).mp3', N'/Assets/images/Music_player_logo152x152.png', N'https://www.youtube.com/watch?v=aqYnMSUTFGU')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (6, N'Dynasty', 6, 4, 228, 48000, N'mp3', 2016, N'/Assets/files/Thanh Xuân - Da LAB.mp3', N'/Assets/images/Music_player_logo152x152.png', N'https://www.youtube.com/watch?v=8JSdy3nLLYA')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (7, N'Như Ngày Hôm Qua', 7, 7, 7, 36000, N'mp3', 2016, N'/Assets/files/Thanh Xuân - Da LAB.mp3', N'/Assets/images/6.jpg', N'https://www.youtube.com/watch?v=P6NVGLcZlEs')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (8, N'Anh Ơi Ở Lại', 8, 4, 9, 12000, N'mp3', 2012, N'/Assets/files/The anser - Fang Yu Jie (Đáp án - Phương Vũ Kiệt).mp3', N'/Assets/images/7.jpg', N'https://www.youtube.com/watch?v=3fi7uwBU-CE')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (9, N'Người Nào Hay', 8, 5, 12, 12000, N'mp3', 2012, N'/Assets/files/Never Give Up On Your Dreams - Two Steps From Hell.mp3', N'/Assets/images/8.jpg', N'https://www.youtube.com/watch?v=gpD0CTxMYts')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (10, N'Tiểu Thư Cá Tính', 8, 7, 8, 36000, N'mp3', 2012, N'/Assets/files/Protectors Of The Earth Cinematic - Two Steps From Hell.mp3', N'/Assets/images/9.jpg', N'https://www.youtube.com/watch?v=Y33AOPcwu_s')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (11, N'Vườn Cây Của Ba', 9, 4, 11, 12000, N'mp3', 2014, N'/Assets/files/Two Steps From Hell - Heart Of Courage.mp3', N'/Assets/images/10.jpg', N'https://www.youtube.com/watch?v=p4Iq7G82n3s')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (12, N'Gió Mùa Xuân Tới', 9, 4, 11, 48000, N'mp3', 2016, N'/Assets/files/Victory - Two Steps From Hell.mp3', N'/Assets/images/10.jpg', N'https://www.youtube.com/watch?v=JbzFEc0RjiU')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (13, N'Quả Gì', 9, 4, 12, 12000, N'mp3', 2014, N'/Assets/files/Symphony-RobinHustin-Remix.mp3', N'/Assets/images/10.jpg', N'https://www.youtube.com/watch?v=CGO6ljmDmHM')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (14, N'Rửa Mặt Như Mèo', 9, 7, 11, 48000, N'mp3', 2016, N'/Assets/files/Dancin - Aaron Smith (KRONO Remix).mp3', N'/Assets/images/10.jpg', N'https://www.youtube.com/watch?v=SVAdm_rM-s4')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (15, N'Never Give Up On Your Dreams', 10, 5501, 320, 48000, N'mp3', 2014, N'/Assets/files/NeverGiveUpOnYourDreams-TwoStepsFromHell.mp3', N'/Assets/images/10.jpg', N'https://www.youtube.com/watch?v=V17ij5Ap1pA')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (16, N'Nắng Ấm Xa Dần', 7, 4, 4, 48000, N'mp3', 2012, N'/Assets/files/Dynasty - MIIA.mp3', N'/Assets/images/1.jpg', N'https://www.youtube.com/watch?v=ErhGuwNgrmw')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (17, N'Thái Bình Mồ Hôi Rơi', 7, 6, 6, 48000, N'mp3', 2012, N'/Assets/files/Falling Apart - Michael Schulte.mp3', N'/Assets/images/1.jpg', N'https://www.youtube.com/watch?v=5Jm9g0YdGDU')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (18, N'Âm Thầm Bên Em', 7, 7, 3, 48000, N'mp3', 2014, N'/Assets/files/I Miss You - Czarina.mp3', N'/Assets/images/2.jpg', N'https://www.youtube.com/watch?v=30KI5SuECuc')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (19, N'Không Phải Dạng Vừa Đâu', 7, 6, 11, 48000, N'mp3', 2014, N'/Assets/files/In The End - Linkin Park (Mellen Gi & Tommee Profitt Remix).mp3', N'/Assets/images/3.jpg', N'https://www.youtube.com/watch?v=fb3Eeyzi6XY')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (20, N'Em Của Ngày Hôm Qua', 7, 4, 3, 48000, N'mp3', 2012, N'/Assets/files/Right Now (Na Na Na) - Am1r (cover).mp3', N'/Assets/images/4.jpg', N'https://www.youtube.com/watch?v=5iMx3tlpFeY')
INSERT [dbo].[BANNHAC] ([MaBanNhac], [TenBanNhac], [MaTacGia], [KichThuoc], [DoDai], [TanSo], [DinhDang], [NamSanXuat], [DuongDanBanNhac], [DuongDanAnh], [DuongDanTrucTuyen]) VALUES (21, N'Buông Đôi Tay Nhau Ra', 7, 5, 7, 36000, N'mp3', 2014, N'/Assets/files/Runnin'' - Adam Lambert.mp3', N'/Assets/images/5.jpg', N'https://www.youtube.com/watch?v=LCyo565N_5w')
SET IDENTITY_INSERT [dbo].[BANNHAC] OFF
SET IDENTITY_INSERT [dbo].[DANHSACHNHAC] ON 

INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (1, N'Quỷ Kiếm Darkin', 1, CAST(0x0000AA4B00000000 AS DateTime), 100, N'https://soundcloud.com/linkin_park', N'/Assets/images/stay_close_by_softyrider62-dami1hw.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (2, N'Hồ Li Chín Đuôi', 1, CAST(0x0000AA4C00000000 AS DateTime), 99, N'https://soundcloud.com/martingarrix', N'/Assets/images/surface-planet-galaxy-22522-.jpeg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (3, N'Nắm Đấm Bóng Đêm', 2, CAST(0x0000AA4D00000000 AS DateTime), 86, N'https://soundcloud.com/masterfader-slimv/son-tung-mtp-ft-slimv-nang-am-xa-dan', N'/Assets/images/anime-girl-school-uniform-back-view-clouds-buildings-sunlight.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (4, N'Quái Vật Đầu Bò', 3, CAST(0x0000AA4E00000000 AS DateTime), 45, N'https://soundcloud.com/tripled-duongdaiduong/son-tung-mtp-lac-troi-original-mix', N'/Assets/images/35749742_840863186110638_3992857900534988800_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (5, N'Xác Ướp U Sầu', 4, CAST(0x0000AA4F00000000 AS DateTime), 45, N'https://soundcloud.com/martingarrix/martin-garrix-matisse-sadko-feat-alex-aris-mistaken-club-mix', N'/Assets/images/index.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (6, N'Phượng Hoàng Băng', 4, CAST(0x0000AA5000000000 AS DateTime), 45, N'https://soundcloud.com/martingarrix/martin-garrix-feat-mike-yung-dreamer-1', N'/Assets/images/36632325_2112581568812386_3206334493967253504_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (7, N'Đứa Trẻ Bóng Tối', 4, CAST(0x0000AA5100000000 AS DateTime), 12, N'https://soundcloud.com/martingarrix/martin-garrix-julian-jordan-glitch', N'/Assets/images/index.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (8, N'Cung Băng', 5, CAST(0x0000AA5200000000 AS DateTime), 12, N'https://soundcloud.com/martingarrix/sets/bylaw-ep', N'/Assets/images/36632325_2112581568812386_3206334493967253504_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (9, N'Ác Long Thượng Giới', 6, CAST(0x0000AA5300000000 AS DateTime), 23, N'https://soundcloud.com/martingarrix/martin-garrix-pierce-fulton-feat-mike-shinoda-waiting-for-tomorrow', N'/Assets/images/35749742_840863186110638_3992857900534988800_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (10, N'Hoàng Đế Sa Mạc', 6, CAST(0x0000AA5400000000 AS DateTime), 9, N'https://soundcloud.com/martingarrix/martin-garrix-access', N'/Assets/images/city_skyscrapers_clouds_rain_road_cars_lights_58563_3840x2160.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (11, N'Ông Bụt Vũ Trụ', 6, CAST(0x0000AA5500000000 AS DateTime), 9, N'https://soundcloud.com/martingarrix/martin-garrix-yottabyte', N'/Assets/images/anime-girl-school-uniform-back-view-clouds-buildings-sunlight.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (12, N'Người Máy Hơi Nước', 6, CAST(0x0000AA5600000000 AS DateTime), 8, N'https://soundcloud.com/martingarrix/martin-garrix-blinders-breach-walk-alone', N'/Assets/images/photo-1533770699395-5761e5d08106.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (13, N'Thần Lửa', 3, CAST(0x0000AA5700000000 AS DateTime), 6, N'https://soundcloud.com/martingarrix/ocean-martin-garrix-cesqeaux-remix', N'/Assets/images/35749742_840863186110638_3992857900534988800_o.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (14, N'Trái Tim Của Freljord', 4, CAST(0x0000AA5800000000 AS DateTime), 4, N'https://soundcloud.com/martingarrix/martin-garrix-david-guetta-so-far-away-feat-jamie-scott-romy-dya16', N'/Assets/images/city_skyscrapers_clouds_rain_road_cars_lights_58563_3840x2160.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (15, N'Cảnh Sát Trưởng Piltover', 2, CAST(0x0000AA5900000000 AS DateTime), 12, N'https://soundcloud.com/martingarrix/pizza', N'/Assets/images/photo-1533770699395-5761e5d08106.jpg')
INSERT [dbo].[DANHSACHNHAC] ([MaDanhSach], [TenDanhSach], [MaTacGia], [NgayTao], [LuongTruyCap], [DuongDanTrucTuyen], [DuongDanAnh]) VALUES (16, N'Xà Nữ', 1, CAST(0x0000AA5A00000000 AS DateTime), 4, N'https://soundcloud.com/martingarrix/stbla', N'/Assets/images/photo-1533770699395-5761e5d08106.jpg')
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
SET IDENTITY_INSERT [dbo].[THELOAI] ON 

INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (1, N'Pop', N'/Assets/images/POP-Music-l.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (2, N'Rock', N'/Assets/images/rock-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (3, N'Jazz', N'/Assets/images/jazz-music.png')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (4, N'Blues', N'/Assets/images/blue-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (5, N'Hip hop', N'/Assets/images/hiphop-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (6, N'R&B/Soul', N'/Assets/images/R-BSoul-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (7, N'Nhạc đồng quê', N'/Assets/images/country-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (8, N'Nhạc điện tử', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (9, N'Folk đương đại', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (10, N'Nhạc dance', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (11, N'Avant-Garde', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (12, N'Nhạc dễ nghe', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (13, N'Mỹ Latinh', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (14, N'Brasil', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (15, N'Caribe', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (16, N'Châu Phi', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (17, N'Châu Á', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (18, N'EDM', N'/Assets/images/edm-music.jpg')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [DuongDanAnh]) VALUES (19, N'Epic', N'/Assets/images/edm-music.jpg')
SET IDENTITY_INSERT [dbo].[THELOAI] OFF
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
