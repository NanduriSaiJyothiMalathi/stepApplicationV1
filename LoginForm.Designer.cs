
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StepTestApplication
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gradientPanel1 = new StepTestApplication.GradientPanel();
            this.exit = new System.Windows.Forms.LinkLabel();
            this.gradientPanel2 = new StepTestApplication.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customButtom2 = new StepTestApplication.CustomButtom();
            this.login = new StepTestApplication.CustomButtom();
            this.ClearFields = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.gradientPanel1.Controls.Add(this.exit);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(638, 367);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(600, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 15);
            this.exit.TabIndex = 11;
            this.exit.TabStop = true;
            this.exit.Text = "Exit";
            this.exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = -225F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.label3);
            this.gradientPanel2.Controls.Add(this.customButtom2);
            this.gradientPanel2.Controls.Add(this.login);
            this.gradientPanel2.Controls.Add(this.ClearFields);
            this.gradientPanel2.Controls.Add(this.password);
            this.gradientPanel2.Controls.Add(this.username);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Location = new System.Drawing.Point(135, 31);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(354, 276);
            this.gradientPanel2.TabIndex = 0;
            this.gradientPanel2.TopColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(39, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 23);
            this.label3.TabIndex = 9;
            // 
            // customButtom2
            // 
            this.customButtom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.customButtom2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.customButtom2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.customButtom2.BorderRadius = 10;
            this.customButtom2.BorderSize = 0;
            this.customButtom2.FlatAppearance.BorderSize = 0;
            this.customButtom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtom2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButtom2.ForeColor = System.Drawing.Color.Black;
            this.customButtom2.Image = ((System.Drawing.Image)(resources.GetObject("customButtom2.Image")));
            this.customButtom2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButtom2.Location = new System.Drawing.Point(221, 230);
            this.customButtom2.Margin = new System.Windows.Forms.Padding(0);
            this.customButtom2.Name = "customButtom2";
            this.customButtom2.Size = new System.Drawing.Size(90, 32);
            this.customButtom2.TabIndex = 7;
            this.customButtom2.Text = "Sign Up";
            this.customButtom2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtom2.TextColor = System.Drawing.Color.Black;
            this.customButtom2.UseVisualStyleBackColor = false;
            this.customButtom2.Click += new System.EventHandler(this.customButtom2_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Snow;
            this.login.BackgroundColor = System.Drawing.Color.Snow;
            this.login.BorderColor = System.Drawing.Color.White;
            this.login.BorderRadius = 10;
            this.login.BorderSize = 0;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(62, 160);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(228, 45);
            this.login.TabIndex = 6;
            this.login.Text = "Log In";
            this.login.TextColor = System.Drawing.Color.Black;
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.AutoSize = true;
            this.ClearFields.BackColor = System.Drawing.Color.Transparent;
            this.ClearFields.Location = new System.Drawing.Point(26, 240);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(67, 15);
            this.ClearFields.TabIndex = 5;
            this.ClearFields.TabStop = true;
            this.ClearFields.Text = "Clear Fields";
            this.ClearFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearFields_LinkClicked);
            // 
            // password
            // 
            this.password.AcceptsTab = true;
            this.password.BackColor = System.Drawing.Color.AliceBlue;
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(62, 115);
            this.password.Name = "password";
            this.password.PlaceholderText = "Password";
            this.password.Size = new System.Drawing.Size(228, 23);
            this.password.TabIndex = 2;
            // 
            // username
            // 
            this.username.AcceptsTab = true;
            this.username.BackColor = System.Drawing.Color.AliceBlue;
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(62, 86);
            this.username.Name = "username";
            this.username.PlaceholderText = "@UserName";
            this.username.Size = new System.Drawing.Size(228, 23);
            this.username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(638, 367);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        //public void CustomizeLinearGradients(PaintEventArgs e)
        //{
        //    LinearGradientBrush linGrBrush = new LinearGradientBrush(
        //       new Point(0, 10),
        //       new Point(200, 10),
        //       Color.FromArgb(255, 0, 0, 0),     // Opaque black
        //       Color.FromArgb(255, 255, 0, 0));  // Opaque red

        //    float[] relativeIntensities = { 0.0f, 0.5f, 1.0f };
        //    float[] relativePositions = { 0.0f, 0.2f, 1.0f };

        //    //Create a Blend object and assign it to linGrBrush.
        //    Blend blend = new Blend();
        //    blend.Factors = relativeIntensities;
        //    blend.Positions = relativePositions;
        //    linGrBrush.Blend = blend;

        //    e.Graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
        //    e.Graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);
        //}

        #endregion

        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private Label label1;
        private LinkLabel ClearFields;
        private TextBox password;
        private TextBox username;
        private CustomButtom customButtom1;
        private CustomButtom customButtom2;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel2;
        private CustomButtom login;
        private LinkLabel exit;
    }
}

