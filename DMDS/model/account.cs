using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DMDS.model
{
    public class Account
    {
        public Account (string username, string password, string displayName)
        {
            this.Username = username;
            this.Password = password;
            this.DisplayName = displayName;

        }

        public Account (DataRow row)
        {
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.DisplayName = row["displayname"].ToString();

        }

        private string username;

        private string password;

        private string displayName;

        public string Username { get => username; set => username = value; }

        public string Password { get => password; set => password = value; }

        public string DisplayName { get => displayName; set => displayName = value; }
    }
}
