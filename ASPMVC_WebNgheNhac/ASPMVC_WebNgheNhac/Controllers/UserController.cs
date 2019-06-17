using ASPMVC_WebNgheNhac.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPMVC_WebNgheNhac.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        #region MY PARAMETER
        private DbMusicWebsite db = new DbMusicWebsite();
        private List<int> lmusicListen = new List<int>();
        private static List<int> lmusicAll= new List<int>();
        #endregion

        #region MY STRUCT - CLASS
        public struct MySimpleStructBanNhac
        {
            [Key]
            [DisplayName("Mã bản nhạc")]
            public int MaBanNhac { get; set; }

            [StringLength(100)]
            [DisplayName("Tên bản nhạc")]
            public string TenBanNhac { get; set; }

            [DisplayName("Tên tác giả")]
            public string HoTen{ get; set; }

            [StringLength(200)]
            [DisplayName("Đường dẫn bản nhạc")]
            public string DuongDanBanNhac { get; set; }

            [StringLength(200)]
            [DisplayName("Đường dẫn ảnh")]
            public string DuongDanAnh { get; set; }

            [StringLength(200)]
            [DisplayName("Đường dẫn trực tuyến")]
            public string DuongDanTrucTuyen { get; set; }
        }
        #endregion

        #region MY FUNCTION

        /// <summary>
        /// Các giá trị ban đầu cho các biến toàn cục
        /// </summary>
        private void LogoutState()
        {
            Session["LoginInfo"] = null;
            Session["TableEditing"] = null;
        }
        #endregion

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Database.SqlQuery<DANHSACHNHAC>("SELECT TOP 6 * FROM DANHSACHNHAC ORDER BY LuongTruyCap DESC").ToList());
        }

        [HttpGet]
        public ActionResult Login()
        {
            LogoutState();
            // ViewBag.Message = null;
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.NGUOIDUNG info)
        {
            if (ModelState.IsValid)
            {
                string email = info.Email;
                string password = info.MatKhau;
                int? itam = -1;

                itam = Code.MyClass.CheckLogin(email, password);
                switch (itam)
                {
                    case 1: // admin
                        Session["LoginInfo"] = info;
                        return this.RedirectToAction("Index", "Admin", new { message = "Chào mừng admin" });
                    case 0:// normal user
                        Session["LoginInfo"] = info;
                        return this.RedirectToAction("Index", "Admin", new { message = "Chào mừng bạn" });
                    default:
                        break;
                }
            }
            ViewBag.Message = @"Sai tên đăng nhập hoặc mật khẩu";
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            LogoutState();
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.NGUOIDUNG info, string comfirmPassword)
        {
            // cái này để gửi lại nếu nó có nhập sai pass
            ViewBag.HoTen = info.HoTen;
            ViewBag.Email = info.Email;
            if (!string.Equals(info.MatKhau, comfirmPassword))
            {
                ViewBag.Message = @"Mật khẩu nhập lại không trùng khớp!";
                return View();
            }
            if (string.IsNullOrWhiteSpace(info.MatKhau) ||
                    string.IsNullOrWhiteSpace(comfirmPassword))
            {
                ViewBag.Message = @"Chưa nhập mật khẩu!";
                return View();
            }

            // cái này gán cho MaQuyenTruyCap bằng 0
            info.MaQuyenTruyCap = 0;

            // đoạn này để lưu bản đăng ký của người dùng vào csdl
            db.NGUOIDUNGs.Add(info);
            if (db.SaveChanges() > 0)
            {
                // ViewBag.Message = "Lưu thành công!";
                return this.RedirectToAction("Login", "User");
            }
            ViewBag.Message = @"Không thể lưu vào csdl";
            return View();
        }

        [HttpGet]
        public ActionResult ResetPassword()
        {
            LogoutState();
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// 
        /// Các thể loại nhạc
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult About()
        {
            return View(db.Database.SqlQuery<Models.THELOAI>("SELECT TOP 6 * FROM THELOAI"));
        }

        [HttpGet]
        public ActionResult Music(int id = 9, int sotrang = 1) // id = số bản nhạc hiển thị trên trang web, sotrang = số thứ tự trang đang hiển thị
        {
            lmusicAll = db.Database.SqlQuery<int>("SELECT MaBanNhac FROM BANNHAC").ToList();
            ViewBag.NumberShow = id > 9 ? id : 9;
            ViewBag.NumberPages = lmusicAll.Count % id > 0 ? lmusicAll.Count/id + 1 : lmusicAll.Count / id;
            if (sotrang <= 1)
            {
                return View(db.Database.SqlQuery<MySimpleStructBanNhac>("SELECT TOP " + id + " bn.MaBanNhac, bn.TenBanNhac, bn.DuongDanBanNhac, bn.DuongDanAnh, bn.DuongDanTrucTuyen ,tg.HoTen FROM TACGIA tg, BANNHAC bn WHERE tg.MaTacGia = bn.MaTacGia").Cast<MySimpleStructBanNhac>().ToList());
            }
            List<MySimpleStructBanNhac> lshow = new List<MySimpleStructBanNhac>();
            int ___i = id * (sotrang - 1);
            for (int i = 0; i < id && ___i < lmusicAll.Count; i++)
            {
                lshow.Add(db.Database.SqlQuery<MySimpleStructBanNhac>("SELECT TOP 1 bn.MaBanNhac, bn.TenBanNhac, bn.DuongDanBanNhac, bn.DuongDanAnh, bn.DuongDanTrucTuyen ,tg.HoTen FROM TACGIA tg, BANNHAC bn WHERE tg.MaTacGia = bn.MaTacGia AND bn.MaBanNhac = " + lmusicAll[___i++]).SingleOrDefault());
            }
            return View(lshow);
        }
        [HttpGet]
        public ActionResult Single()
        {
            IEnumerable<TACGIA> l = db.Database.SqlQuery<Models.TACGIA>("SELECT TOP 1 * FROM TACGIA WHERE HienThiTrenTrangChu = 'True'");
            if (l.Count() <= 0)
            {
                return View(db.Database.SqlQuery<Models.TACGIA>("SELECT TOP 1 * FROM TACGIA").SingleOrDefault());
            }
            return View(l.First());
        }

        [HttpGet]
        public ActionResult NotFound404()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Black()
        {
            return View();
        }
    }
}