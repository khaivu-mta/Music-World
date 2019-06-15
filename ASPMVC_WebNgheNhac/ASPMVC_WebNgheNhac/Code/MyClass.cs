using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVC_WebNgheNhac.Code
{
    public class MyClass
    {
        #region MY PARAMETER
        private static Models.DbMusicWebsite db = new Models.DbMusicWebsite();
        #endregion
        /// <summary>
        /// 
        /// Kiểm tra đăng nhập
        /// 
        /// </summary>
        /// <param name="_email"></param>
        /// <param name="_password"></param>
        /// <returns></returns>
        public static int? CheckLogin(string _email, string _password)
        {
            if (string.IsNullOrWhiteSpace(_email) | string.IsNullOrWhiteSpace(_password))
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
    }
}