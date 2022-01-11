
namespace StepTestApplication
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradientPanel1 = new StepTestApplication.GradientPanel();
            this.backToLogin = new System.Windows.Forms.LinkLabel();
            this.clearFields = new System.Windows.Forms.LinkLabel();
            this.signup_Button = new StepTestApplication.CustomButtom();
            this.isManagerNo = new System.Windows.Forms.RadioButton();
            this.isManagerYes = new System.Windows.Forms.RadioButton();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.gradientPanel1.Controls.Add(this.backToLogin);
            this.gradientPanel1.Controls.Add(this.clearFields);
            this.gradientPanel1.Controls.Add(this.signup_Button);
            this.gradientPanel1.Controls.Add(this.isManagerNo);
            this.gradientPanel1.Controls.Add(this.isManagerYes);
            this.gradientPanel1.Controls.Add(this.password);
            this.gradientPanel1.Controls.Add(this.email);
            this.gradientPanel1.Controls.Add(this.lastName);
            this.gradientPanel1.Controls.Add(this.firstName);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.BackColor = System.Drawing.Color.Transparent;
            this.backToLogin.Location = new System.Drawing.Point(709, 9);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(79, 15);
            this.backToLogin.TabIndex = 14;
            this.backToLogin.TabStop = true;
            this.backToLogin.Text = "Back to Login";
            this.backToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToLoginClick);
            // 
            // clearFields
            // 
            this.clearFields.AutoSize = true;
            this.clearFields.BackColor = System.Drawing.Color.Transparent;
            this.clearFields.Location = new System.Drawing.Point(364, 426);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(67, 15);
            this.clearFields.TabIndex = 13;
            this.clearFields.TabStop = true;
            this.clearFields.Text = "Clear Fields";
            this.clearFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clearFields_LinkClicked);
            // 
            // signup_Button
            // 
            this.signup_Button.BackColor = System.Drawing.Color.Orchid;
            this.signup_Button.BackgroundColor = System.Drawing.Color.Orchid;
            this.signup_Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.signup_Button.BorderRadius = 10;
            this.signup_Button.BorderSize = 0;
            this.signup_Button.FlatAppearance.BorderSize = 0;
            this.signup_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup_Button.ForeColor = System.Drawing.Color.White;
            this.signup_Button.Location = new System.Drawing.Point(320, 338);
            this.signup_Button.Name = "signup_Button";
            this.signup_Button.Size = new System.Drawing.Size(150, 40);
            this.signup_Button.TabIndex = 12;
            this.signup_Button.Text = "Sign Up";
            this.signup_Button.TextColor = System.Drawing.Color.White;
            this.signup_Button.UseVisualStyleBackColor = false;
            this.signup_Button.Click += new System.EventHandler(this.signup_Button_Click);
            // 
            // isManagerNo
            // 
            this.isManagerNo.AutoSize = true;
            this.isManagerNo.BackColor = System.Drawing.Color.Transparent;
            this.isManagerNo.Location = new System.Drawing.Point(390, 257);
            this.isManagerNo.Name = "isManagerNo";
            this.isManagerNo.Size = new System.Drawing.Size(41, 19);
            this.isManagerNo.TabIndex = 11;
            this.isManagerNo.TabStop = true;
            this.isManagerNo.Text = "No";
            this.isManagerNo.UseVisualStyleBackColor = false;
            // 
            // isManagerYes
            // 
            this.isManagerYes.AutoSize = true;
            this.isManagerYes.BackColor = System.Drawing.Color.Transparent;
            this.isManagerYes.Location = new System.Drawing.Point(342, 257);
            this.isManagerYes.Name = "isManagerYes";
            this.isManagerYes.Size = new System.Drawing.Size(42, 19);
            this.isManagerYes.TabIndex = 10;
            this.isManagerYes.TabStop = true;
            this.isManagerYes.Text = "Yes";
            this.isManagerYes.UseVisualStyleBackColor = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(342, 227);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(192, 23);
            this.password.TabIndex = 9;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(342, 197);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(192, 23);
            this.email.TabIndex = 8;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(342, 165);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(192, 23);
            this.lastName.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(342, 135);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(192, 23);
            this.firstName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(225, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Is Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(225, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Login Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(225, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(225, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(225, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(308, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel clearFields;
        private CustomButtom signup_Button;
        private System.Windows.Forms.RadioButton isManagerNo;
        private System.Windows.Forms.RadioButton isManagerYes;
        private System.Windows.Forms.LinkLabel backToLogin;
    }
}