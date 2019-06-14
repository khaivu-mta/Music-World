using ASPMVC_WebNgheNhac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPMVC_WebNgheNhac.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        /// <summary>
        /// Các giá trị ban đầu cho các biến toàn cục
        /// </summary>
        private DbMusicWebsite db = new DbMusicWebsite();
        public int? CheckLogin(string _email, string _password)
        {
            if (string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_password))
            {
                return -1;
            }
            var _query = from m in db.NGUOIDUNGs where m.Email.Equals(_email) && m.MatKhau.Equals(_password) select m.MaQuyenTruyCap;
            if (!_query.Any())
            {
                return -1;
            }
            else
                return _query.First();
        }

        private void LogoutState()
        {
            Session["LoginInfo"] = null;
            Session["TypeUser"] = -1;
            Session["TableEditing"] = null;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Database.SqlQuery<DANHSACHNHAC>("SELECT TOP 6 * FROM DANHSACHNHAC").ToList());
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

                itam = CheckLogin(email, password);
                if (itam == 1) // admin
                {
                    Session["LoginInfo"] = info;
                    Session["TypeUser"] = itam;
                    // ViewBag.Message = "Chào mừng admin!";
                    return this.RedirectToAction("Index", "Admin");
                }
                else if (itam == 0) // normal user
                {
                    Session["LoginInfo"] = info;
                    Session["TypeUser"] = itam;
                    // ViewBag.Message = "Chào mừng bạn!";
                    return this.RedirectToAction("Index", "Admin");
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

        [HttpGet]
        public ActionResult About()
        {
            return View(db.Database.SqlQuery<Models.DANHSACHNHAC>("SELECT TOP 6 * FROM DANHSACHNHAC"));
        }
        [HttpGet]
        public ActionResult Music()
        {
            return View(db.Database.SqlQuery<Models.BANNHAC>("SELECT TOP 30 * FROM BANNHAC"));
        }
        [HttpGet]
        public ActionResult Single()
        {
            return View(db.Database.SqlQuery<Models.BANNHAC>("SELECT TOP 1 * FROM BANNHAC").ToList());
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