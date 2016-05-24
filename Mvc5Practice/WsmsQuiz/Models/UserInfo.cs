using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string LeveDesc { get; set; }
        public Nullable<int> UserRole { get; set; }
        public int RoleID { get; set; }
        public bool IsMultiRole { get; set; }
        public string EmployeeCode { get; set; }
        public int ServicePointID { get; set; }

        public static UserInfo GetUserInfo(int userId, Boolean isMobileCrmUser)
        {
            UserInfo userInfo;
            String query = "";
            if (isMobileCrmUser)
            {
                query = String.Format("select * from WSMS.dbo.Users where UserID={0}", userId);
            }
            else
            {
                query = String.Format("select * from WaltonCrm.dbo.Users where UserID={0}", userId);
            }
            using (var db = new WsmsQuizEntities())
            {
                userInfo = db.Database.SqlQuery<UserInfo>(query).FirstOrDefault();
            }
            return userInfo;
        }
        public static UserInfo GetUserLoginIfInfo(String userName,String password)
        {
            UserInfo userInfo;
           
            using (var db = new WsmsQuizEntities())
            {
                userInfo = db.QuizAdmins.Where(x => x.UserName == userName && x.Password == password).Select(x=>new UserInfo
                {
                    UserID = (int)x.QuizAdminID,
                    UserName = x.UserName,
                    UserFullName = x.AdminName 
                }).FirstOrDefault();
            }
            return userInfo;
        }
    }
}