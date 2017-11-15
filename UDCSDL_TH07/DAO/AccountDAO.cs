using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "EXEC usp_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;//result.Rows.Count là đếm số dòng được trả ra số dòng này > 0 thì bằng true ngược lại ra false
        }

        public bool confirmEmail(string email)
        {
            string query = "EXEC usp_confirmEmail @email";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {email});

            return result.Rows.Count > 0;//result.Rows.Count là đếm số dòng được trả ra số dòng này > 0 thì bằng true ngược lại ra false
        }

        public bool changePassword(string password, string email)
        {
            string query = "EXEC usp_changePassword @password , @email";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {password, email });

            return result > 0;//result là đếm số dòng được thực thi số dòng này > 0 thì bằng true ngược lại ra false
        }

        public bool register(string username,string displayname, string email, string password,string typeacc)
        {
            string query = "EXEC usp_Register @username , @displayname , @email , @password , @typeacc";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {username, displayname, email, password, typeacc });

            return result > 0;//result là đếm số dòng được thực thi số dòng này > 0 thì bằng true ngược lại ra false
        }

        public DataTable getListAccount()
        {
            string query = "SELECT UserName AS N'Tên Đăng Nhập', DisplayName AS N'Họ Tên', Email, typeAcc AS N'Chức vụ' FROM dbo.ACCOUNT";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;//result là đếm số dòng được thực thi số dòng này > 0 thì bằng true ngược lại ra false
        }

        public bool updateAccount(string displayname, string typeacc, string username)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET DisplayName = N'{0}',typeAcc = {1} WHERE UserName = '{2}'", displayname, typeacc, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
