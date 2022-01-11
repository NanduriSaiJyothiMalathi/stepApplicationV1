using StepTestApplication.Models;
using StepTestApplication.StepTest.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StepTestApplication
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        public User user { get; set; }
        public Staff staff { get; set; }

        /// <summary>
        /// back to login click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToLoginClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        /// <summary>
        /// on signUpButton Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signup_Button_Click(object sender, EventArgs e)
        {
            UserData user = new UserData();
            string message;
            bool isDetailsValid = ValidateFields(out message);
            if (isDetailsValid)
            {
                //save user to database
                user.staff_first_name = this.firstName.Text;
                user.staff_last_name = this.lastName.Text;
                user.staff_email = this.email.Text;
                user.staff_password = this.password.Text;
                user.manager_access = this.isManagerYes.Checked;

                UserDB userDB = new UserDB();
                User userAfterSave = userDB.SaveUserInDB(user);

                //if save success
                if (userAfterSave.UserId > 0)
                {
                    //show success message

                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();
                }
                else
                {
                    //show error message
                }


                
            }
            else
            {
                //display error message
            }
        }

        /// <summary>
        /// validate details entered
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields(out string message)
        {
            message = string.Empty;

            try
            {
                //if firstname is not empty
                if (string.IsNullOrEmpty(this.firstName.Text))
                {
                    message = "First Name cannot be empty";
                    return false;
                }
                else if (this.firstName.Text.Length > 35)
                {
                    message = "Max characters for first name is 35";
                    return false;
                }

                if (string.IsNullOrEmpty(this.lastName.Text))
                {
                    message = "Last Name cannot be empty";
                    return false;
                }
                else if (this.lastName.Text.Length > 35)
                {
                    message = "Max characters for last name is 35";
                    return false;
                }

                if (string.IsNullOrEmpty(this.email.Text))
                {
                    message = "Email cannot be empty";
                    return false;
                }
                else if (this.email.Text.Length > 35)
                {
                    message = "Max characters for Email is 35";
                    return false;
                }

                if (string.IsNullOrEmpty(this.password.Text))
                {
                    message = "Password cannot be empty";
                    return false;
                }
                else if (this.password.Text.Length > 35)
                {
                    message = "Max characters for password is 35";
                    return false;
                }

                if (!this.isManagerYes.Checked && !this.isManagerNo.Checked)
                {
                    message = "Select whether is manager or not";
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void clearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.firstName.Text = string.Empty;
            this.lastName.Text = string.Empty;
            this.email.Text = string.Empty;
            this.password.Text = string.Empty;
            this.isManagerNo.Checked = false;
            this.isManagerYes.Checked = false;
        }
    }
}
