using ASPMVC_WebNgheNhac.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC_WebNgheNhac.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult test()
        {
            var db = new DbMusicWebsite();
            db.Configuration.LazyLoadingEnabled = false;
            return View(db.Database.SqlQuery<BANNHAC>("SELECT * FROM BANNHAC").ToList());
        }

        // GET: Admin
        public int? CheckLogin(string _email, string _password)
        {
            if (string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_password))
            {
                return -1;
            }
            DbMusicWebsite db = new DbMusicWebsite();
            var _query = from m in db.NGUOIDUNGs where m.Email.Equals(_email) && m.MatKhau.Equals(_password) select m.MaQuyenTruyCap;
            if (!_query.Any())
            {
                return -1;
            }
            else
                return _query.First();
        }

        private int? CheckLogin()
        {
            if (Session["TypeUser"] != null)
            {
                if (Session["LoginInfo"] != null)
                {
                    try
                    {
                        Models.NGUOIDUNG val = Session["LoginInfo"] as Models.NGUOIDUNG;
                        int? type = Convert.ToInt32(Session["TypeUser"]);
                        if (CheckLogin(val.Email, val.MatKhau) == type)
                            return type;
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }
            return -1;
        }

        [HttpGet]
        public ActionResult Library(string id) // id = table name
        {
            // kiểm tra đăng nhập
            switch (CheckLogin())
            {
                case 1:
                case 0:
                    break;
                default:
                    return RedirectToAction("Login", "User");
            }

            Models.DbMusicWebsite db = new Models.DbMusicWebsite();
            switch (id)
            {
                case "BANNHAC":
                    return View("Library_BANNHAC", db.BANNHACs);

                case "DANHSACHNHAC":
                    return View("Library_DANHSACHNHAC", db.DANHSACHNHACs);

                case "NGUOIDUNG":
                    return View("Library_NGUOIDUNG", db.NGUOIDUNGs);

                case "QUYENTRUYCAP":
                    return View("Library_QUYENTRUYCAP", db.QUYENTRUYCAPs);

                case "THELOAI":
                    return View("Library_THELOAI", db.THELOAIs);

                default:
                    break;
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public ActionResult Edit(string id, string _Value)
        {
            Session["TableEditing"] = id;
            // kiểm tra đăng nhập
            switch (CheckLogin())
            {
                case 1:
                case 0:
                    break;
                default:
                    return RedirectToAction("Login", "User");
            }

            // nếu không, truyền dữ liệu cần chỉnh sửa đến View()
            Models.DbMusicWebsite db = new Models.DbMusicWebsite();
            switch (id)
            {
                case "BANNHAC":
                    Models.BANNHAC val1 = new Models.BANNHAC();
                    val1.MaBanNhac = Convert.ToInt32(_Value);
                    
                    val1 = db.BANNHACs.Find(val1.MaBanNhac);
                    return View("Edit_BANNHAC", val1);

                case "DANHSACHNHAC":
                    Models.DANHSACHNHAC val2 = new Models.DANHSACHNHAC();
                    val2.MaDanhSach = Convert.ToInt32(_Value);
                    
                    val2 = db.DANHSACHNHACs.Find(val2.MaDanhSach);
                    return View("Edit_DANHSACHNHAC", val2);
                    
                case "NGUOIDUNG":
                    Models.NGUOIDUNG val3 = new Models.NGUOIDUNG();
                    val3.Email = _Value;
                    
                    val3 = db.NGUOIDUNGs.Find(val3.Email);
                    return View("Edit_NGUOIDUNG", val3);
                    
                case "QUYENTRUYCAP":
                    Models.QUYENTRUYCAP val4 = new Models.QUYENTRUYCAP();
                    val4.MaQuyenTruyCap = Convert.ToInt32(_Value);
                    
                    val4 = db.QUYENTRUYCAPs.Find(val4.MaQuyenTruyCap);
                    return View("Edit_QUYENTRUYCAP", val4);

                case "THELOAI":
                    Models.THELOAI val5 = new Models.THELOAI();
                    val5.MaTheLoai = Convert.ToInt32(_Value);
                    
                    val5 = db.THELOAIs.Find(val5.MaTheLoai);
                    return View("Edit_THELOAI", val5);
                    
                default:
                    break;
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public ActionResult Edit(Models.BANNHAC _BANNHAC = null, Models.DANHSACHNHAC _DANHSACHNHAC = null,
            Models.NGUOIDUNG _NGUOIDUNG = null, Models.QUYENTRUYCAP _QUYENTRUYCAP = null, 
            Models.THELOAI _THELOAI = null)
        {
            // kiểm tra đăng nhập
            switch (CheckLogin())
            {
                case 1:
                case 0:
                    // nếu không biết được table đang chỉnh sửa -> thoát
                    if (Session["TableEditing"] == null)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    break;
                default:
                    return RedirectToAction("Login", "User");
            }
            
            Models.DbMusicWebsite db = new Models.DbMusicWebsite();
            switch (Session["TableEditing"].ToString())
            {
                case "BANNHAC":
                    Models.BANNHAC t1 = _BANNHAC as Models.BANNHAC;

                    db.BANNHACs.AddOrUpdate<Models.BANNHAC>(t1);
                    db.SaveChanges();

                    return RedirectToAction("Library", "Admin", new { id = "BANNHAC" });

                case "DANHSACHNHAC":
                    Models.DANHSACHNHAC t2 = _DANHSACHNHAC as Models.DANHSACHNHAC;
                    t2.NgayTao = DateTime.Now;
                    db.DANHSACHNHACs.AddOrUpdate<Models.DANHSACHNHAC>(t2);
                    db.SaveChanges();

                    return RedirectToAction("Library", "Admin", new { id = "DANHSACHNHAC" });

                case "NGUOIDUNG":
                    Models.NGUOIDUNG t3 = _NGUOIDUNG as Models.NGUOIDUNG;
                    db.NGUOIDUNGs.AddOrUpdate<Models.NGUOIDUNG>(t3);
                    db.SaveChanges();

                    return RedirectToAction("Library", "Admin", new { id = "NGUOIDUNG" });

                case "QUYENTRUYCAP":
                    Models.QUYENTRUYCAP t4 = _QUYENTRUYCAP as Models.QUYENTRUYCAP;
                    db.QUYENTRUYCAPs.AddOrUpdate<Models.QUYENTRUYCAP>(t4);
                    db.SaveChanges();

                    return RedirectToAction("Library", "Admin", new { id = "QUYENTRUYCAP" });

                case "THELOAI":
                    Models.THELOAI t5 = _THELOAI as Models.THELOAI;
                    db.THELOAIs.AddOrUpdate<Models.THELOAI>(t5);
                    db.SaveChanges();

                    return RedirectToAction("Library", "Admin", new { id = "THELOAI" });

                default:
                    break;
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public ActionResult Index()
        {
            
            switch (CheckLogin())
            {
                case 1:
                    return View();
                case 0:
                    return View();
                default:
                    break;
            }
            return RedirectToAction("Login", "User");
        }

        [HttpGet]
        public ActionResult Chart()
        {

            switch (CheckLogin())
            {
                case 1:
                    return View();
                case 0:
                    return View();
                default:
                    break;
            }
            return RedirectToAction("Login", "User");
        }

        public ActionResult Delete(string id, string _Value)
        {
            // kiểm tra đăng nhập
            switch (CheckLogin())
            {
                case 1:
                case 0:
                    break;
                default:
                    return RedirectToAction("Login", "User");
            }
            Models.DbMusicWebsite db = new Models.DbMusicWebsite();
            switch (id)
            {
                case "BANNHAC":
                    db.Database.ExecuteSqlCommand("DELETE DANHSACHNHAC_BANNHAC WHERE MaBanNhac = " + _Value);
                    db.Database.ExecuteSqlCommand("DELETE THELOAI_BANNHAC WHERE MaBanNhac = " + _Value);
                    db.Database.ExecuteSqlCommand("DELETE BANNHAC WHERE MaBanNhac = " + _Value);
                    db.SaveChanges();
                    return RedirectToAction("Library", "Admin", new { id = "BANNHAC" });

                case "DANHSACHNHAC":
                    db.Database.ExecuteSqlCommand("DELETE DANHSACHNHAC_BANNHAC WHERE MaDanhSach = " + _Value);
                    db.Database.ExecuteSqlCommand("DELETE NGUOIDUNG_DANHSACHNHAC WHERE MaDanhSach = " + _Value);
                    db.Database.ExecuteSqlCommand("DELETE DANHSACHNHAC WHERE MaDanhSach = " + _Value);
                    db.SaveChanges();
                    return RedirectToAction("Library", "Admin", new { id = "DANHSACHNHAC" });

                case "NGUOIDUNG":
                    db.Database.ExecuteSqlCommand("DELETE NGUOIDUNG_DANHSACHNHAC WHERE Email = N'" + _Value + "'");
                    db.Database.ExecuteSqlCommand("DELETE NGUOIDUNG WHERE Email = N'" + _Value + "'");
                    db.SaveChanges();
                    return RedirectToAction("Library", "Admin", new { id = "NGUOIDUNG" });

                case "QUYENTRUYCAP":
                    db.Database.ExecuteSqlCommand("UPDATE NGUOIDUNG SET MaQuyenTruyCap = null WHERE MaQuyenTruyCap = " + _Value);
                    db.Database.ExecuteSqlCommand("DELETE QUYENTRUYCAP WHERE MaQuyenTruyCap = " + _Value);
                    db.SaveChanges();
                    return RedirectToAction("Library", "Admin", new { id = "QUYENTRUYCAP" });

                case "THELOAI":
                    db.Database.ExecuteSqlCommand("DELETE THELOAI_BANNHAC WHERE MaTheLoai = " + _Value);
                    db.Database.ExecuteSqlCommand("DELETE THELOAI WHERE MaTheLoai = " + _Value);
                    db.SaveChanges();
                    return RedirectToAction("Library", "Admin", new { id = "THELOAI" });

                default:
                    break;
            }
            // else
            return RedirectToAction("Index", "Admin");
        }
    }
}