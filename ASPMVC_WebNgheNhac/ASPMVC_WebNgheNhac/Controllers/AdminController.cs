using ASPMVC_WebNgheNhac.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC_WebNgheNhac.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        #region MY PARAMETER
        DbMusicWebsite db = new DbMusicWebsite();

        #endregion

        #region MY FUNCTION
        private int? CheckLogin()
        {
            if (Session["LoginInfo"] != null)
            {
                Models.NGUOIDUNG val = Session["LoginInfo"] as Models.NGUOIDUNG;
                return Code.MyClass.CheckLogin(val.Email, val.MatKhau);
            }
            return -1;
        }
        #endregion

        #region MY STRUCT - CLASS
        public class IndexStruct
        {
            public int[] lInt { get; set; }
            public string[] lString { get; set; }
            public string[] lAction { get; set; }
            public string[] lController { get; set; }
            public object[] lParameter { get; set; }
            public int Count
            {
                get
                {
                    return lInt.Count();
                }
            }
            public IndexStruct(int number)
            {
                lInt = new int[number];
                lString = new string[number];
                lAction = new string[number];
                lController = new string[number];
                lParameter = new object[number];
            }
        }
        #endregion

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

                case "TACGIA":
                    return View("Library_TACGIA", db.TACGIAs);

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

                case "TACGIA":
                    Models.TACGIA val6 = new Models.TACGIA();
                    val6.MaTacGia= Convert.ToInt32(_Value);

                    val6 = db.TACGIAs.Find(val6.MaTacGia);
                    return View("Edit_TACGIA", val6);

                default:
                    break;
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public ActionResult Edit(Models.BANNHAC _BANNHAC = null, Models.DANHSACHNHAC _DANHSACHNHAC = null,
            Models.NGUOIDUNG _NGUOIDUNG = null, Models.QUYENTRUYCAP _QUYENTRUYCAP = null, 
            Models.THELOAI _THELOAI = null, Models.TACGIA _TACGIA = null)
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

                case "TACGIA":
                    Models.TACGIA t6 = _TACGIA as Models.TACGIA;
                    if (t6.HienThiTrenTrangChu)
                    {
                        db.Database.ExecuteSqlCommand("UPDATE TACGIA SET HienThiTrenTrangChu = 'FALSE' WHERE MaTacGia != " + t6.MaTacGia);
                    }
                    db.TACGIAs.AddOrUpdate<Models.TACGIA>(t6);
                    db.SaveChanges();

                    return RedirectToAction("Library", "Admin", new { id = "TACGIA" });

                default:
                    break;
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public ActionResult Index(string message = null)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                ViewBag.Message = message;
            }
            IndexStruct l = new IndexStruct(6);
            l.lInt[0] = db.BANNHACs.Count();
            l.lInt[1] = db.DANHSACHNHACs.Count();
            l.lInt[2] = db.NGUOIDUNGs.Count();
            l.lInt[3] = db.QUYENTRUYCAPs.Count();
            l.lInt[4] = db.TACGIAs.Count();
            l.lInt[5] = db.THELOAIs.Count();

            l.lString[0] = l.lInt[0] + " bài hát";
            l.lString[1] = l.lInt[1] + " albums";
            l.lString[2] = l.lInt[2] + " người dùng";
            l.lString[3] = l.lInt[3] + " quyền truy cập";
            l.lString[4] = l.lInt[4] + " ca sỹ";
            l.lString[5] = l.lInt[5] + " thể loại";

            l.lAction[0] =
                l.lAction[1] =
                l.lAction[2] =
                l.lAction[3] =
                l.lAction[4] =
                l.lAction[5] = "Library";
            l.lController[0] =
                l.lController[1] =
                l.lController[2] =
                l.lController[3] =
                l.lController[4] =
                l.lController[5] = "Admin";
            l.lParameter[0] = "BANNHAC";
            l.lParameter[1] = "DANHSACHNHAC";
            l.lParameter[2] = "NGUOIDUNG";
            l.lParameter[3] = "QUYENTRUYCAP";
            l.lParameter[4] = "TACGIA";
            l.lParameter[5] = "THELOAI";
            switch (CheckLogin())
            {
                case 1:
                case 0:
                    return View(l);
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

                case "TACGIA":
                    db.Database.ExecuteSqlCommand("DELETE TACGIA_BANNHAC WHERE MaTacGia = " + _Value);
                    db.Database.ExecuteSqlCommand("UPDATE BANNHAC SET MaTacGia = null WHERE MaTacGia = " + _Value);
                    db.Database.ExecuteSqlCommand("UPDATE DANHSACHNHAC SET MaTacGia = null WHERE MaTacGia = " + _Value);
                    db.Database.ExecuteSqlCommand("DELETE TACGIA WHERE MaTacGia = " + _Value);
                    db.SaveChanges();
                    return RedirectToAction("Library", "Admin", new { id = "TACGIA" });

                default:
                    break;
            }
            // else
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
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

            if (file != null && file.ContentLength > 0)
            {
                string strExtention = Path.GetExtension(file.FileName).ToLower();
                string path = null;
                switch (strExtention)
                {
                    case ".jpg":
                    case ".png":
                    case ".gif":
                    case ".jpeg":
                        path = Path.Combine(Server.MapPath("~/Assets/images"), file.FileName);

                        break;
                    case ".mp3":
                    case ".flac":
                    case ".acc":
                    case ".ogg":
                    case ".mpeg":
                        path = Path.Combine(Server.MapPath("~/Assets/files"), file.FileName);
                        BANNHAC val = new BANNHAC();
                        val.TenBanNhac = Path.GetFileName(file.FileName);
                        val.KichThuoc = file.ContentLength;
                        val.DinhDang = Path.GetExtension(file.FileName);
                        val.DuongDanBanNhac = @"/Assets/files/" + file.FileName;

                        db.BANNHACs.Add(val);
                        db.SaveChanges();
                        break;
                    default:
                        ViewBag.Message = "Tập tin không được hỗ trợ!";
                        return RedirectToAction("Index", "Admin", new { message = ViewBag.Message });
                        //break;
                }

                // file is uploaded
                file.SaveAs(path);
                ViewBag.Message = "Upload file thành công!";
            }
            else
            {
                ViewBag.Message = "Không thể upload file!";
            }
            return RedirectToAction("Index", "Admin", new { message = ViewBag.Message });
        }
    }
}