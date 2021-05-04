using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DMDS.controller;
using DMDS.model;

namespace DMDS
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool isRemember = false;
        
        public static string savedUserName;

        public static string savedPassword;

        public formLogin()
        {
            InitializeComponent();

            LoadAccount();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            if (isRemember)
            {
                cbRemember.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            isRemember = cbRemember.Checked;

            if (username == "" && password == "")
            {
                MessageBox.Show("Nhập username hoặc password");

            }
            else
            {
                /*
                if (Validate(username, password))
                {
                */
                    Account loginAccount = AccountController.Instance.GetAccountByUsername(username);
                    bool isLogin = AccountController.Instance.Login(username, password);
                    if (isLogin)
                    {
                        SaveAccount();
                        Form1 home = new Form1(loginAccount);

                        this.Hide();

                        home.ShowDialog();

                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!");
                    }
                /*
                }

                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!");
                }
                */
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        void LoadAccount()
        {
            /*
            if (Properties.Settings.Default.savedUserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.savedUserName;

                txtPassword.Text = Properties.Settings.Default.savedPassword;

                cbRemember.Checked = Properties.Settings.Default.SavedAccount;

            }
            */
        }

        bool Validate(string userName, string password)
        {
            return AccountController.Instance.Validate(userName, password);

        }

        void SaveAccount()
        {
            string username = txtUsername.Text;

            string password = txtPassword.Text;

            /*
            if (username != string.Empty && password != string.Empty && cbRemember.Checked && Validate(username, password))
            {
                Properties.Settings.Default.savedUserName = username;

                Properties.Settings.Default.savedPassword = password;

                savedUserName = username;

                savedPassword = password;

                Properties.Settings.Default.SavedAccount = cbRemember.Checked;

                Properties.Settings.Default.Save();

            }
            */
        }
    }
}