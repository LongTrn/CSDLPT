using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DMDS.model;

namespace DMDS.controller
{
    public class AccountController
    {
        private static AccountController instance;

        public static AccountController Instance
        {
            get { if (instance == null) instance = new AccountController(); return instance; }
            private set { instance = value; }
        }

        private AccountController() { }

        public bool Login (string username, string password)
        {
            string qr = String.Format("SELECT * FROM dbo.ACCOUNT WHERE username = N'{0}' AND password = N'{1}'", username, password);

            DataTable result = DataProvider.Instance.ExecuteQuery(qr);

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT username, password, displayname FROM dbo.Account WHERE username = @username", new object[] { username });

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);

            }

            return null;
        }

        public string EncodedPassword(string initial)
        {
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(initial);

            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(tmp);

            string hashPass = "";

            foreach (byte item in hashData)
            {
                hashPass += item;

            }

            return hashPass;

        }

        public bool Validate(string username, string password)
        {
            string hashed = EncodedPassword(password);

            string qr = "SP_VALIDATE_ACCOUNT @userName , @Password ";

            DataTable result = DataProvider.Instance.ExecuteQuery(qr, new object[] { username, hashed });

            return result.Rows.Count > 0;
        }
    }
}