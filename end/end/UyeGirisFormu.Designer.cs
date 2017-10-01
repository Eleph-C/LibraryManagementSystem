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
            this.tabPage1.Size = new System.Drawing.Size(342, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnuserlog
            // 
            this.btnuserlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnuserlog.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuserlog.Location = new System.Drawing.Point(174, 183);
            this.btnuserlog.Name = "btnuserlog";
            this.btnuserlog.Size = new System.Drawing.Size(159, 43);
            this.btnuserlog.TabIndex = 36;
            this.btnuserlog.Text = "Giris";
            this.btnuserlog.UseVisualStyleBackColor = true;
            this.btnuserlog.Click += new System.EventHandler(this.btnuserlog_Click);
            // 
            // btnusercancel
            // 
            this.btnusercancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnusercancel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusercancel.Location = new System.Drawing.Point(9, 183);
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
            this.linkLabellost.Location = new System.Drawing.Point(57, 147);
            this.linkLabellost.Name = "linkLabellost";
            this.linkLabellost.Size = new System.Drawing.Size(99, 13);
            this.linkLabellost.TabIndex = 34;
            this.linkLabellost.TabStop = true;
            this.linkLabellost.Text = "Sifreni mi Unuttun ?";
            this.linkLabellost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabellost_LinkClicked);
            // 
            // txtkullanicisifre
            // 
            this.txtkullanicisifre.Location = new System.Drawing.Point(152, 106);
            this.txtkullanicisifre.Name = "txtkullanicisifre";
            this.txtkullanicisifre.Size = new System.Drawing.Size(133, 20);
            this.txtkullanicisifre.TabIndex = 33;
            this.txtkullanicisifre.UseSystemPasswordChar = true;
            // 
            // txtkullaniciemail
            // 
            this.txtkullaniciemail.Location = new System.Drawing.Point(152, 69);
            this.txtkullaniciemail.Name = "txtkullaniciemail";
            this.txtkullaniciemail.Size = new System.Drawing.Size(133, 20);
            this.txtkullaniciemail.TabIndex = 32;
            // 
            // lbluserpass
            // 
            this.lbluserpass.AutoSize = true;
            this.lbluserpass.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbluserpass.Location = new System.Drawing.Point(85, 103);
            this.lbluserpass.Name = "lbluserpass";
            this.lbluserpass.Size = new System.Drawing.Size(65, 23);
            this.lbluserpass.TabIndex = 31;
            this.lbluserpass.Text = "Sifre : ";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblusername.Location = new System.Drawing.Point(85, 67);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(64, 23);
            this.lblusername.TabIndex = 30;
            this.lblusername.Text = "Email : ";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbluser.Location = new System.Drawing.Point(26, 26);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(80, 23);
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
            this.tabPage2.Size = new System.Drawing.Size(342, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btncanceluser2
            // 
            this.btncanceluser2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncanceluser2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncanceluser2.Location = new System.Drawing.Point(17, 131);
            this.btncanceluser2.Name = "btncanceluser2";
            this.btncanceluser2.Size = new System.Drawing.Size(103, 41);
            this.btncanceluser2.TabIndex = 11;
            this.btncanceluser2.Text = "Iptal";
            this.btncanceluser2.UseVisualStyleBackColor = true;
            this.btncanceluser2.Click += new System.EventHandler(this.btncanceluser2_Click);
            // 
            // btnusersendcode
            // 
            this.btnusersendcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnusersendcode.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusersendcode.Location = new System.Drawing.Point(126, 131);
            this.btnusersendcode.Name = "btnusersendcode";
            this.btnusersendcode.Size = new System.Drawing.Size(195, 41);
            this.btnusersendcode.TabIndex = 10;
            this.btnusersendcode.Text = "Guvenlik Kodunu Gonder";
            this.btnusersendcode.UseVisualStyleBackColor = true;
            this.btnusersendcode.Click += new System.EventHandler(this.btnusersendcode_Click);
            // 
            // txtuseremail
            // 
            this.txtuseremail.Location = new System.Drawing.Point(111, 97);
            this.txtuseremail.Name = "txtuseremail";
            this.txtuseremail.Size = new System.Drawing.Size(210, 20);
            this.txtuseremail.TabIndex = 9;
            // 
            // lbluseremail
            // 
            this.lbluseremail.AutoSize = true;
            this.lbluseremail.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbluseremail.Location = new System.Drawing.Point(49, 95);
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
            this.tabPage3.Size = new System.Drawing.Size(342, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnusercode
            // 
            this.btnusercode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnusercode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusercode.Location = new System.Drawing.Point(110, 153);
            this.btnusercode.Name = "btnusercode";
            this.btnusercode.Size = new System.Drawing.Size(127, 33);
            this.btnusercode.TabIndex = 8;
            this.btnusercode.Text = "Devam";
            this.btnusercode.UseVisualStyleBackColor = true;
            this.btnusercode.Click += new System.EventHandler(this.btnusercode_Click);
            // 
            // txtcodeuser
            // 
            this.txtcodeuser.Location = new System.Drawing.Point(110, 113);
            this.txtcodeuser.Name = "txtcodeuser";
            this.txtcodeuser.Size = new System.Drawing.Size(127, 20);
            this.txtcodeuser.TabIndex = 7;
            this.txtcodeuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsendeduser
            // 
            this.lblsendeduser.AutoSize = true;
            this.lblsendeduser.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblsendeduser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsendeduser.Location = new System.Drawing.Point(16, 76);
            this.lblsendeduser.Name = "lblsendeduser";
            this.lblsendeduser.Size = new System.Drawing.Size(325, 23);
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
            this.lblnewpassworduser.Location = new System.Drawing.Point(79, 63);
            this.lblnewpassworduser.Name = "lblnewpassworduser";
            this.lblnewpassworduser.Size = new System.Drawing.Size(102, 23);
            this.lblnewpassworduser.TabIndex = 14;
            this.lblnewpassworduser.Text = "Yeni Sifre : ";
            // 
            // btnusersavepass
            // 
            this.btnusersavepass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnusersavepass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusersavepass.Location = new System.Drawing.Point(35, 159);
            this.btnusersavepass.Name = "btnusersavepass";
            this.btnusersavepass.Size = new System.Drawing.Size(276, 36);
            this.btnusersavepass.TabIndex = 18;
            this.btnusersavepass.Text = "Kaydet";
            this.btnusersavepass.UseVisualStyleBackColor = true;
            this.btnusersavepass.Click += new System.EventHandler(this.btnusersavepass_Click);
            // 
            // txtnewpassworduser
            // 
            this.txtnewpassworduser.Location = new System.Drawing.Point(182, 65);
            this.txtnewpassworduser.Name = "txtnewpassworduser";
            this.txtnewpassworduser.Size = new System.Drawing.Size(146, 20);
            this.txtnewpassworduser.TabIndex = 16;
            // 
            // txtconfrmpassuser
            // 
            this.txtconfrmpassuser.Location = new System.Drawing.Point(182, 112);
            this.txtconfrmpassuser.Name = "txtconfrmpassuser";
            this.txtconfrmpassuser.Size = new System.Drawing.Size(146, 20);
            this.txtconfrmpassuser.TabIndex = 17;
            // 
            // lblconfrmpassuser
            // 
            this.lblconfrmpassuser.AutoSize = true;
            this.lblconfrmpassuser.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblconfrmpassuser.Location = new System.Drawing.Point(4, 109);
            this.lblconfrmpassuser.Name = "lblconfrmpassuser";
            this.lblconfrmpassuser.Size = new System.Drawing.Size(178, 23);
            this.lblconfrmpassuser.TabIndex = 15;
            this.lblconfrmpassuser.Text = "Yeni Sifreyi Dogrula : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 23);
            this.panel1.TabIndex = 35;
            // 
            // UyeGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "UyeGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeGirisFormu";
            this.Load += new System.EventHandler(this.UyeGirisFormu_Load);
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