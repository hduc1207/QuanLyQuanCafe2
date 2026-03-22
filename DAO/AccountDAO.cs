using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        // Login
        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM Account WHERE UserName = @userName AND PassWord = @passWord AND AccountStatus = 1";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        // Lấy account theo username
        public AccountDTO GetAccountByUserName(string userName)
        {
            string query = "SELECT * FROM Account WHERE UserName = @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow row in data.Rows)
            {
                return new AccountDTO(row);
            }
            return null;
        }

        // Lấy danh sách account
        public List<AccountDTO> GetListAccount()
        {
            List<AccountDTO> list = new List<AccountDTO>();
            string query = "SELECT * FROM Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AccountDTO account = new AccountDTO(row);
                list.Add(account);
            }
            return list;
        }

        // Thêm account
        public bool InsertAccount(string userName, string displayName, string passWord, int type)
        {
            string query = "INSERT INTO Account (UserName, DisplayName, PassWord, AccountType) VALUES (@userName, @displayName, @passWord, @type)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, passWord, type });
            return result > 0;
        }

        // Update account
        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = "UPDATE Account SET DisplayName = @displayName, AccountType = @type WHERE UserName = @userName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { displayName, type, userName });
            return result > 0;
        }

        // Delete account
        public bool DeleteAccount(string userName)
        {
            string query = "DELETE FROM Account WHERE UserName = @userName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            return result > 0;
        }
    }
}