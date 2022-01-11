using StepTestApplication.Entities;
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
    public partial class MainForm : Form
    {
        List<Participant> sessionParticipants = new List<Participant>();
        Participant currentParticipant = new Participant();
        List<Test> participantsTest = new List<Test>();
        bool isTestPanel = false;
        public Tuple<User, Staff> _currentUser;
        public string testStatus = "PrepareTest";

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Tuple<User, Staff> currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            hideAllPanes();
            this.loadexistingprtPanel.Show();
            this.navBarMenu.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!isTestPanel)
            {
                if (this.navBarMenu.Visible)
                    this.navBarMenu.Hide();
                else
                    this.navBarMenu.Show();
            }

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void AddParticipant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.AddParticipant.LinkColor = this.AddParticipant.ActiveLinkColor;
            hideAllPanes();
            this.addparticipantpanel.Show();
            this.AddParticipant.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(225)))));
        }



        /// <summary>
        /// add new participant 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveParticipant_Click(object sender, EventArgs e)
        {
            ParticipantData participantData = new ParticipantData();
            string message = string.Empty;
            try
            {
                bool isParticipantValid = ValidateParticapant(out message);
                if (isParticipantValid)
                {
                    //save particiapnt to db
                    participantData.participant_first_name = this.firstName.Text;
                    participantData.participant_last_name = this.lastName.Text;
                    participantData.gender = this.femaleG.Checked;
                    int age = 0;
                    age = DateTime.Now.Subtract(this.dateTimePicker1.Value).Days;
                    age = age / 365;
                    participantData.participant_age = age;

                    ParicipantDB paricipantDB = new ParicipantDB();
                    Participant participantAfterSave = paricipantDB.SaveParicipant(participantData);
                    if (participantAfterSave.ID > 0)
                    {
                        //show success message

                        //hide and show
                    }
                    else
                    {
                        //show error message
                    }


                }
                else
                {
                    //error message
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// to validate participant
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private bool ValidateParticapant(out string message)
        {
            message = string.Empty;
            try
            {
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

                if (this.dateTimePicker1.Value.ToString() == "")
                {
                    message = "Age cannot be empty";
                    return false;
                }
                else
                {
                    int age = 0;
                    age = DateTime.Now.Subtract(this.dateTimePicker1.Value).Days;
                    age = age / 365;
                    if (age < 20)
                    {
                        message = "Age cannot be less than 20";
                        return false;
                    }
                }

                if (!this.isMaleGender.Checked && !this.femaleG.Checked)
                {
                    message = "Select Gender";
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }



        private void LoadTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAllPanes();
            this.loadexistingprtPanel.Show();

        }

        /// <summary>
        /// Clear Mainform foelds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.firstName.Text = string.Empty;
            this.lastName.Text = string.Empty;
            this.dateTimePicker1.Text = string.Empty;
            this.isMaleGender.Checked = false;
            this.femaleG.Checked = false;
        }

        private void UpdateProfile_Click(object sender, EventArgs e)
        {
            this.userFirstName.Text = _currentUser.Item1.FirstName;
            this.userLastName.Text = _currentUser.Item1.LastName;
            this.email.Text = _currentUser.Item2.LoginEmail;
            this.password.Text = _currentUser.Item2.LoginPass;
            hideAllPanes();
            this.updateProfilePanel.Show();
        }

        private void hideAllPanes()
        {
            isTestPanel = false;
            this.loadexistingprtPanel.Hide();
            this.addparticipantpanel.Hide();
            this.TestPanel.Hide();
            this.updateProfilePanel.Hide();
        }

        private void Test_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.checkreadinesspanel.Show();
            this.hideAllPanes();
            isTestPanel = true;
            this.TestPanel.Show();
            this.runtestpanel.Hide();
            testStatus = "PrepareTest";
            this.prepareTest.TextColor = Color.DarkBlue;
            this.testbutton.TextColor = Color.Black;
            this.resultTestButton.TextColor = Color.Black;
            ParicipantDB paricipantDB = new ParicipantDB();
            List<Participant> participants = paricipantDB.GetParticipants("");
            this.selectparticipantbox.DataSource = participants;
            this.selectparticipantbox.DisplayMember = "FirstName";
            this.selectparticipantbox.ValueMember = "ID";
        }

        private void customButtom1_Click(object sender, EventArgs e)
        {
            testStatus = "StartTest";
            //this.prepareTest.TextColor = Color.Black;
            //this.testbutton.TextColor = Color.DarkBlue;
            //this.resultTestButton.TextColor = Color.Black;
            this.checkreadinesspanel.Hide();
        }

        /// <summary>
        /// To clear add pariticipant form fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.firstName.Text = string.Empty;
            this.lastName.Text = string.Empty;
            this.dateTimePicker1.Text = string.Empty;
            this.isMaleGender.Checked = false;
            this.femaleG.Checked = false;
        }

        /// <summary>
        /// Clear update from fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.firstName.Text = string.Empty;
            this.lastName.Text = string.Empty;
            this.email.Text = string.Empty;
            this.password.Text = string.Empty;
        }

        /// <summary>
        /// Update profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signup_Button_Click(object sender, EventArgs e)
        {
            UserData user = new UserData();
            string message;
            bool isDetailsValid = ValidateUserFields(out message);
            if (isDetailsValid)
            {
                //save user to database
                user.staff_first_name = this.userFirstName.Text;
                user.staff_last_name = this.userLastName.Text;
                user.staff_email = this.email.Text;
                user.staff_password = this.password.Text;
                user.staff_id = _currentUser.Item1.UserId;
                user.manager_access = _currentUser.Item2.HasManagerAccess;

                //Updating current user tuple
                _currentUser.Item1.FirstName = this.userFirstName.Text;
                _currentUser.Item1.LastName = this.userLastName.Text;
                _currentUser.Item2.LoginEmail = this.email.Text;
                _currentUser.Item2.LoginPass = this.password.Text;



                UserDB userDB = new UserDB();
                User userAfterSave = userDB.SaveUserInDB(user);

                //if save success
                if (userAfterSave.UserId > 0)
                {
                    //show success message


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
        /// ValidateUserFields
        /// </summary>
        /// <returns></returns>
        private bool ValidateUserFields(out string message)
        {
            message = string.Empty;

            try
            {
                //if firstname is not empty
                if (string.IsNullOrEmpty(this.userFirstName.Text))
                {
                    message = "First Name cannot be empty";
                    return false;
                }
                else if (this.userFirstName.Text.Length > 35)
                {
                    message = "Max characters for first name is 35";
                    return false;
                }

                if (string.IsNullOrEmpty(this.userLastName.Text))
                {
                    message = "Last Name cannot be empty";
                    return false;
                }
                else if (this.userLastName.Text.Length > 35)
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

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// start test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void starttestbutton_Click(object sender, EventArgs e)
        {
            //assign currentparticipant

            //check readiness

            //if all three arechecked

            //check height

            //select appropriate height

            //else

            //throw error

            //show test entry button

            this.checkreadinesspanel.Hide();
            this.runtestpanel.Show();
            this.currentParticipant = (Models.Participant)this.selectparticipantbox.SelectedItem;
            this.prepareTest.TextColor = Color.Black;
            this.testbutton.TextColor = Color.DarkBlue;
            this.resultTestButton.TextColor = Color.Black;

        }

        private void customButtom1_Click_1(object sender, EventArgs e)
        {
            //read all y values

            int stepHeight = Convert.ToInt32(this.comboBox3.SelectedItem.ToString().Replace("cm", ""));
            LineOfBestFit lineOfBestFit = new LineOfBestFit(stepHeight);

            lineOfBestFit.maxHr = 220 - this.currentParticipant.Age;
            lineOfBestFit.maxhr85 = lineOfBestFit.maxHr * 85 / 100;
            lineOfBestFit.maxhr50 = lineOfBestFit.maxHr * 50 / 100;
            lineOfBestFit.y_values = new decimal[5];
            lineOfBestFit.y_values[0] = this.hr1.Value;
            lineOfBestFit.y_values[1] = this.hr2.Value;
            lineOfBestFit.y_values[2] = this.hr3.Value;
            lineOfBestFit.y_values[3] = this.hr4.Value;
            lineOfBestFit.y_values[4] = this.hr5.Value;
            lineOfBestFit.calculateX();
        }
    }
}
