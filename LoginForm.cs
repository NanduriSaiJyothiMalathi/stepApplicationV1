using StepTestApplication.Models;
using StepTestApplication.StepTest.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepTestApplication
{
    public partial class LoginForm : Form
    {
        public string UserNameMatch { get; set; }
        public string PasswordMatch { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Rectangle bounds = new Rectangle(0, 0, this.gradientPanel2.Width, this.gradientPanel2.Height);
            int iCornerRadius = 20;
            GraphicsPath gpath = new GraphicsPath();
            gpath.AddArc(bounds.X, bounds.Y, iCornerRadius, iCornerRadius, 180, 90);
            gpath.AddArc(bounds.X + bounds.Width - iCornerRadius, bounds.Y, iCornerRadius, iCornerRadius, 270, 90);
            gpath.AddArc(bounds.X + bounds.Width - iCornerRadius, bounds.Y + bounds.Height - iCornerRadius, iCornerRadius, iCornerRadius, 0, 90);
            gpath.AddArc(bounds.X, bounds.Y + bounds.Height - iCornerRadius, iCornerRadius, iCornerRadius, 90, 90);
            gpath.CloseAllFigures();
            this.gradientPanel2.Region = new Region(gpath);
        }

        private void customButtom2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm form = new SignUpForm();
            form.Show();

        }

        private void ClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.username.Clear();
            this.password.Clear();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.username.Text)|| string.IsNullOrEmpty(this.password.Text))
            {
                //throw error
            }
            else
            {
                Staff s = new Staff()
                {
                    LoginEmail = this.username.Text,
                    LoginPass = this.password.Text
                };
                UserDB userDB = new UserDB();
                Tuple<User, Staff> user = userDB.ValidateCredentials(s);
                if(user.Item1.UserId!=0)
                {
                    //throw success message
                    MainForm mainForm = new MainForm(user);
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    //throw invalid credentials message
                }
            }
        }
    }
}
