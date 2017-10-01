namespace end
{
    partial class UyeGirisFormu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnuserlog = new System.Windows.Forms.Button();
            this.btnusercancel = new System.Windows.Forms.Button();
            this.linkLabellost = new System.Windows.Forms.LinkLabel();
            this.txtkullanicisifre = new System.Windows.Forms.TextBox();
            this.txtkullaniciemail = new System.Windows.Forms.TextBox();
            this.lbluserpass = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncanceluser2 = new System.Windows.Forms.Button();
            this.btnusersendcode = new System.Windows.Forms.Button();
            this.txtuseremail = new System.Windows.Forms.TextBox();
            this.lbluseremail = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnusercode = new System.Windows.Forms.Button();
            this.txtcodeuser = new System.Windows.Forms.TextBox();
            this.lblsendeduser = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblnewpassworduser = new System.Windows.Forms.Label();
            this.btnusersavepass = new System.Windows.Forms.Button();
            this.txtnewpassworduser = new System.Windows.Forms.TextBox();
            this.txtconfrmpassuser = new System.Windows.Forms.TextBox();
            this.lblconfrmpassuser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.Controls.Add(this.btnuserlog);
            this.tabPage1.Controls.Add(this.btnusercancel);
            this.tabPage1.Controls.Add(this.linkLabellost);
            this.tabPage1.Controls.Add(this.txtkullanicisifre);
            this.tabPage1.Controls.Add(this.txtkullaniciemail);
            this.tabPage1.Controls.Add(this.lbluserpass);
            this.tabPage1.Controls.Add(this.lblusername);
            this.tabPage1.Controls.Add(this.lbluser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnuserlog
            // 
            this.btnuserlog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnuserlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserlog.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuserlog.ForeColor = System.Drawing.Color.White;
            this.btnuserlog.Location = new System.Drawing.Point(178, 139);
            this.btnuserlog.Name = "btnuserlog";
            this.btnuserlog.Size = new System.Drawing.Size(159, 43);
            this.btnuserlog.TabIndex = 36;
            this.btnuserlog.Text = "Giris";
            this.btnuserlog.UseVisualStyleBackColor = true;
            this.btnuserlog.Click += new System.EventHandler(this.btnuserlog_Click);
            // 
            // btnusercancel
            // 
            this.btnusercancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnusercancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusercancel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusercancel.ForeColor = System.Drawing.Color.White;
            this.btnusercancel.Location = new System.Drawing.Point(13, 139);
            this.btnusercancel.Name = "btnusercancel";
            this.btnusercancel.Size = new System.Drawing.Size(159, 43);
            this.btnusercancel.TabIndex = 35;
            this.btnusercancel.Text = "Iptal";
            this.btnusercancel.UseVisualStyleBackColor = true;
            this.btnusercancel.Click += new System.EventHandler(this.btnusercancel_Click);
            // 
            // linkLabellost
            // 
            this.linkLabellost.AutoSize = true;
            this.linkLabellost.Location = new System.Drawing.Point(45, 120);
            this.linkLabellost.Name = "linkLabellost";
            this.linkLabellost.Size = new System.Drawing.Size(99, 13);
            this.linkLabellost.TabIndex = 34;
            this.linkLabellost.TabStop = true;
            this.linkLabellost.Text = "Sifreni mi Unuttun ?";
            this.linkLabellost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabellost_LinkClicked);
            // 
            // txtkullanicisifre
            // 
            this.txtkullanicisifre.Location = new System.Drawing.Point(111, 82);
            this.txtkullanicisifre.Multiline = true;
            this.txtkullanicisifre.Name = "txtkullanicisifre";
            this.txtkullanicisifre.Size = new System.Drawing.Size(205, 23);
            this.txtkullanicisifre.TabIndex = 33;
            this.txtkullanicisifre.UseSystemPasswordChar = true;
            // 
            // txtkullaniciemail
            // 
            this.txtkullaniciemail.Location = new System.Drawing.Point(111, 45);
            this.txtkullaniciemail.Multiline = true;
            this.txtkullaniciemail.Name = "txtkullaniciemail";
            this.txtkullaniciemail.Size = new System.Drawing.Size(205, 23);
            this.txtkullaniciemail.TabIndex = 32;
            // 
            // lbluserpass
            // 
            this.lbluserpass.AutoSize = true;
            this.lbluserpass.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluserpass.ForeColor = System.Drawing.Color.White;
            this.lbluserpass.Location = new System.Drawing.Point(44, 79);
            this.lbluserpass.Name = "lbluserpass";
            this.lbluserpass.Size = new System.Drawing.Size(57, 21);
            this.lbluserpass.TabIndex = 31;
            this.lbluserpass.Text = "Sifre : ";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(44, 43);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(63, 21);
            this.lblusername.TabIndex = 30;
            this.lblusername.Text = "Email : ";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(33, 6);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(94, 28);
            this.lbluser.TabIndex = 29;
            this.lbluser.Text = "Uye Giris";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.btncanceluser2);
            this.tabPage2.Controls.Add(this.btnusersendcode);
            this.tabPage2.Controls.Add(this.txtuseremail);
            this.tabPage2.Controls.Add(this.lbluseremail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btncanceluser2
            // 
            this.btncanceluser2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncanceluser2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncanceluser2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncanceluser2.ForeColor = System.Drawing.Color.White;
            this.btncanceluser2.Location = new System.Drawing.Point(16, 85);
            this.btncanceluser2.Name = "btncanceluser2";
            this.btncanceluser2.Size = new System.Drawing.Size(86, 41);
            this.btncanceluser2.TabIndex = 11;
            this.btncanceluser2.Text = "Iptal";
            this.btncanceluser2.UseVisualStyleBackColor = true;
            this.btncanceluser2.Click += new System.EventHandler(this.btncanceluser2_Click);
            // 
            // btnusersendcode
            // 
            this.btnusersendcode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnusersendcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusersendcode.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusersendcode.ForeColor = System.Drawing.Color.White;
            this.btnusersendcode.Location = new System.Drawing.Point(110, 85);
            this.btnusersendcode.Name = "btnusersendcode";
            this.btnusersendcode.Size = new System.Drawing.Size(210, 41);
            this.btnusersendcode.TabIndex = 10;
            this.btnusersendcode.Text = "Guvenlik Kodunu Gonder";
            this.btnusersendcode.UseVisualStyleBackColor = true;
            this.btnusersendcode.Click += new System.EventHandler(this.btnusersendcode_Click);
            // 
            // txtuseremail
            // 
            this.txtuseremail.Location = new System.Drawing.Point(110, 51);
            this.txtuseremail.Multiline = true;
            this.txtuseremail.Name = "txtuseremail";
            this.txtuseremail.Size = new System.Drawing.Size(210, 23);
            this.txtuseremail.TabIndex = 9;
            // 
            // lbluseremail
            // 
            this.lbluseremail.AutoSize = true;
            this.lbluseremail.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbluseremail.ForeColor = System.Drawing.Color.White;
            this.lbluseremail.Location = new System.Drawing.Point(48, 49);
            this.lbluseremail.Name = "lbluseremail";
            this.lbluseremail.Size = new System.Drawing.Size(64, 23);
            this.lbluseremail.TabIndex = 8;
            this.lbluseremail.Text = "Email : ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage3.Controls.Add(this.btnusercode);
            this.tabPage3.Controls.Add(this.txtcodeuser);
            this.tabPage3.Controls.Add(this.lblsendeduser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(351, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnusercode
            // 
            this.btnusercode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusercode.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusercode.ForeColor = System.Drawing.Color.White;
            this.btnusercode.Location = new System.Drawing.Point(73, 111);
            this.btnusercode.Name = "btnusercode";
            this.btnusercode.Size = new System.Drawing.Size(196, 39);
            this.btnusercode.TabIndex = 8;
            this.btnusercode.Text = "Devam";
            this.btnusercode.UseVisualStyleBackColor = true;
            this.btnusercode.Click += new System.EventHandler(this.btnusercode_Click);
            // 
            // txtcodeuser
            // 
            this.txtcodeuser.Location = new System.Drawing.Point(109, 85);
            this.txtcodeuser.Name = "txtcodeuser";
            this.txtcodeuser.Size = new System.Drawing.Size(127, 20);
            this.txtcodeuser.TabIndex = 7;
            this.txtcodeuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsendeduser
            // 
            this.lblsendeduser.AutoSize = true;
            this.lblsendeduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsendeduser.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsendeduser.ForeColor = System.Drawing.Color.White;
            this.lblsendeduser.Location = new System.Drawing.Point(5, 43);
            this.lblsendeduser.Name = "lblsendeduser";
            this.lblsendeduser.Size = new System.Drawing.Size(342, 23);
            this.lblsendeduser.TabIndex = 6;
            this.lblsendeduser.Text = "Emailine gonderilen kodu asagidaki yere gir";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage4.Controls.Add(this.lblnewpassworduser);
            this.tabPage4.Controls.Add(this.btnusersavepass);
            this.tabPage4.Controls.Add(this.txtnewpassworduser);
            this.tabPage4.Controls.Add(this.txtconfrmpassuser);
            this.tabPage4.Controls.Add(this.lblconfrmpassuser);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(351, 260);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // lblnewpassworduser
            // 
            this.lblnewpassworduser.AutoSize = true;
            this.lblnewpassworduser.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblnewpassworduser.ForeColor = System.Drawing.Color.White;
            this.lblnewpassworduser.Location = new System.Drawing.Point(44, 41);
            this.lblnewpassworduser.Name = "lblnewpassworduser";
            this.lblnewpassworduser.Size = new System.Drawing.Size(102, 23);
            this.lblnewpassworduser.TabIndex = 14;
            this.lblnewpassworduser.Text = "Yeni Sifre : ";
            // 
            // btnusersavepass
            // 
            this.btnusersavepass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnusersavepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusersavepass.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusersavepass.ForeColor = System.Drawing.Color.White;
            this.btnusersavepass.Location = new System.Drawing.Point(35, 118);
            this.btnusersavepass.Name = "btnusersavepass";
            this.btnusersavepass.Size = new System.Drawing.Size(276, 40);
            this.btnusersavepass.TabIndex = 18;
            this.btnusersavepass.Text = "Kaydet";
            this.btnusersavepass.UseVisualStyleBackColor = true;
            this.btnusersavepass.Click += new System.EventHandler(this.btnusersavepass_Click);
            // 
            // txtnewpassworduser
            // 
            this.txtnewpassworduser.Location = new System.Drawing.Point(141, 42);
            this.txtnewpassworduser.Multiline = true;
            this.txtnewpassworduser.Name = "txtnewpassworduser";
            this.txtnewpassworduser.Size = new System.Drawing.Size(170, 23);
            this.txtnewpassworduser.TabIndex = 16;
            // 
            // txtconfrmpassuser
            // 
            this.txtconfrmpassuser.Location = new System.Drawing.Point(141, 89);
            this.txtconfrmpassuser.Multiline = true;
            this.txtconfrmpassuser.Name = "txtconfrmpassuser";
            this.txtconfrmpassuser.Size = new System.Drawing.Size(170, 23);
            this.txtconfrmpassuser.TabIndex = 17;
            // 
            // lblconfrmpassuser
            // 
            this.lblconfrmpassuser.AutoSize = true;
            this.lblconfrmpassuser.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblconfrmpassuser.ForeColor = System.Drawing.Color.White;
            this.lblconfrmpassuser.Location = new System.Drawing.Point(5, 85);
            this.lblconfrmpassuser.Name = "lblconfrmpassuser";
            this.lblconfrmpassuser.Size = new System.Drawing.Size(141, 23);
            this.lblconfrmpassuser.TabIndex = 15;
            this.lblconfrmpassuser.Text = "Sifreyi Dogrula : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 23);
            this.panel1.TabIndex = 35;
            // 
            // UyeGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "UyeGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uye Giris Formu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnuserlog;
        private System.Windows.Forms.Button btnusercancel;
        private System.Windows.Forms.LinkLabel linkLabellost;
        private System.Windows.Forms.TextBox txtkullanicisifre;
        public System.Windows.Forms.TextBox txtkullaniciemail;
        private System.Windows.Forms.Label lbluserpass;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btncanceluser2;
        private System.Windows.Forms.Button btnusersendcode;
        private System.Windows.Forms.TextBox txtuseremail;
        private System.Windows.Forms.Label lbluseremail;
        private System.Windows.Forms.Button btnusercode;
        private System.Windows.Forms.TextBox txtcodeuser;
        private System.Windows.Forms.Label lblsendeduser;
        private System.Windows.Forms.Label lblnewpassworduser;
        private System.Windows.Forms.Button btnusersavepass;
        private System.Windows.Forms.TextBox txtnewpassworduser;
        private System.Windows.Forms.TextBox txtconfrmpassuser;
        private System.Windows.Forms.Label lblconfrmpassuser;
        private System.Windows.Forms.Panel panel1;

    }
}