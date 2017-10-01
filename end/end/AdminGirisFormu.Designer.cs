namespace end
{
    partial class AdminGirisFormu
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
            this.btnadminlog = new System.Windows.Forms.Button();
            this.btncanceladmin = new System.Windows.Forms.Button();
            this.linkLabellost2 = new System.Windows.Forms.LinkLabel();
            this.txtyoneticisifre = new System.Windows.Forms.TextBox();
            this.txtyoneticiemail = new System.Windows.Forms.TextBox();
            this.lbladminpass = new System.Windows.Forms.Label();
            this.lbladminname = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncanceladmin2 = new System.Windows.Forms.Button();
            this.btnadminsendcod = new System.Windows.Forms.Button();
            this.txtadminemail = new System.Windows.Forms.TextBox();
            this.lbladminemail = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnadmincod = new System.Windows.Forms.Button();
            this.txtadmincod = new System.Windows.Forms.TextBox();
            this.lblcodsended2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbladminnewpassword = new System.Windows.Forms.Label();
            this.btnadminsavepass = new System.Windows.Forms.Button();
            this.txtadminnewpass = new System.Windows.Forms.TextBox();
            this.txtadminconfirmpass = new System.Windows.Forms.TextBox();
            this.lbladminconfirmpass = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(-5, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.Controls.Add(this.btnadminlog);
            this.tabPage1.Controls.Add(this.btncanceladmin);
            this.tabPage1.Controls.Add(this.linkLabellost2);
            this.tabPage1.Controls.Add(this.txtyoneticisifre);
            this.tabPage1.Controls.Add(this.txtyoneticiemail);
            this.tabPage1.Controls.Add(this.lbladminpass);
            this.tabPage1.Controls.Add(this.lbladminname);
            this.tabPage1.Controls.Add(this.lbladmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnadminlog
            // 
            this.btnadminlog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnadminlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadminlog.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminlog.ForeColor = System.Drawing.Color.White;
            this.btnadminlog.Location = new System.Drawing.Point(182, 143);
            this.btnadminlog.Name = "btnadminlog";
            this.btnadminlog.Size = new System.Drawing.Size(159, 41);
            this.btnadminlog.TabIndex = 35;
            this.btnadminlog.Text = "Giris";
            this.btnadminlog.UseVisualStyleBackColor = true;
            this.btnadminlog.Click += new System.EventHandler(this.btnadminlog_Click);
            // 
            // btncanceladmin
            // 
            this.btncanceladmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncanceladmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncanceladmin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncanceladmin.ForeColor = System.Drawing.Color.White;
            this.btncanceladmin.Location = new System.Drawing.Point(17, 143);
            this.btncanceladmin.Name = "btncanceladmin";
            this.btncanceladmin.Size = new System.Drawing.Size(159, 41);
            this.btncanceladmin.TabIndex = 34;
            this.btncanceladmin.Text = "Iptal";
            this.btncanceladmin.UseVisualStyleBackColor = true;
            this.btncanceladmin.Click += new System.EventHandler(this.btncanceladmin_Click);
            // 
            // linkLabellost2
            // 
            this.linkLabellost2.AutoSize = true;
            this.linkLabellost2.Location = new System.Drawing.Point(50, 120);
            this.linkLabellost2.Name = "linkLabellost2";
            this.linkLabellost2.Size = new System.Drawing.Size(99, 13);
            this.linkLabellost2.TabIndex = 31;
            this.linkLabellost2.TabStop = true;
            this.linkLabellost2.Text = "Sifreni mi Unuttun ?";
            this.linkLabellost2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabellost2_LinkClicked);
            // 
            // txtyoneticisifre
            // 
            this.txtyoneticisifre.Location = new System.Drawing.Point(118, 85);
            this.txtyoneticisifre.Multiline = true;
            this.txtyoneticisifre.Name = "txtyoneticisifre";
            this.txtyoneticisifre.Size = new System.Drawing.Size(193, 23);
            this.txtyoneticisifre.TabIndex = 33;
            this.txtyoneticisifre.UseSystemPasswordChar = true;
            // 
            // txtyoneticiemail
            // 
            this.txtyoneticiemail.Location = new System.Drawing.Point(118, 48);
            this.txtyoneticiemail.Multiline = true;
            this.txtyoneticiemail.Name = "txtyoneticiemail";
            this.txtyoneticiemail.Size = new System.Drawing.Size(193, 23);
            this.txtyoneticiemail.TabIndex = 32;
            // 
            // lbladminpass
            // 
            this.lbladminpass.AutoSize = true;
            this.lbladminpass.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladminpass.ForeColor = System.Drawing.Color.White;
            this.lbladminpass.Location = new System.Drawing.Point(49, 83);
            this.lbladminpass.Name = "lbladminpass";
            this.lbladminpass.Size = new System.Drawing.Size(57, 21);
            this.lbladminpass.TabIndex = 30;
            this.lbladminpass.Text = "Sifre : ";
            // 
            // lbladminname
            // 
            this.lbladminname.AutoSize = true;
            this.lbladminname.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladminname.ForeColor = System.Drawing.Color.White;
            this.lbladminname.Location = new System.Drawing.Point(49, 45);
            this.lbladminname.Name = "lbladminname";
            this.lbladminname.Size = new System.Drawing.Size(63, 21);
            this.lbladminname.TabIndex = 29;
            this.lbladminname.Text = "Email : ";
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladmin.ForeColor = System.Drawing.Color.White;
            this.lbladmin.Location = new System.Drawing.Point(28, 5);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(138, 28);
            this.lbladmin.TabIndex = 28;
            this.lbladmin.Text = "Yonetici Girisi";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.btncanceladmin2);
            this.tabPage2.Controls.Add(this.btnadminsendcod);
            this.tabPage2.Controls.Add(this.txtadminemail);
            this.tabPage2.Controls.Add(this.lbladminemail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btncanceladmin2
            // 
            this.btncanceladmin2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncanceladmin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncanceladmin2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncanceladmin2.ForeColor = System.Drawing.Color.White;
            this.btncanceladmin2.Location = new System.Drawing.Point(17, 80);
            this.btncanceladmin2.Name = "btncanceladmin2";
            this.btncanceladmin2.Size = new System.Drawing.Size(86, 43);
            this.btncanceladmin2.TabIndex = 15;
            this.btncanceladmin2.Text = "Iptal";
            this.btncanceladmin2.UseVisualStyleBackColor = true;
            this.btncanceladmin2.Click += new System.EventHandler(this.btncanceladmin2_Click);
            // 
            // btnadminsendcod
            // 
            this.btnadminsendcod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnadminsendcod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadminsendcod.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminsendcod.ForeColor = System.Drawing.Color.White;
            this.btnadminsendcod.Location = new System.Drawing.Point(109, 80);
            this.btnadminsendcod.Name = "btnadminsendcod";
            this.btnadminsendcod.Size = new System.Drawing.Size(219, 43);
            this.btnadminsendcod.TabIndex = 14;
            this.btnadminsendcod.Text = "Guvenlik Kodunu Gonder";
            this.btnadminsendcod.UseVisualStyleBackColor = true;
            this.btnadminsendcod.Click += new System.EventHandler(this.btnadminsendcod_Click);
            // 
            // txtadminemail
            // 
            this.txtadminemail.Location = new System.Drawing.Point(115, 46);
            this.txtadminemail.Multiline = true;
            this.txtadminemail.Name = "txtadminemail";
            this.txtadminemail.Size = new System.Drawing.Size(213, 23);
            this.txtadminemail.TabIndex = 13;
            // 
            // lbladminemail
            // 
            this.lbladminemail.AutoSize = true;
            this.lbladminemail.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbladminemail.ForeColor = System.Drawing.Color.White;
            this.lbladminemail.Location = new System.Drawing.Point(51, 44);
            this.lbladminemail.Name = "lbladminemail";
            this.lbladminemail.Size = new System.Drawing.Size(64, 23);
            this.lbladminemail.TabIndex = 12;
            this.lbladminemail.Text = "Email : ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage3.Controls.Add(this.btnadmincod);
            this.tabPage3.Controls.Add(this.txtadmincod);
            this.tabPage3.Controls.Add(this.lblcodsended2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(359, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnadmincod
            // 
            this.btnadmincod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnadmincod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmincod.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmincod.ForeColor = System.Drawing.Color.White;
            this.btnadmincod.Location = new System.Drawing.Point(79, 99);
            this.btnadmincod.Name = "btnadmincod";
            this.btnadmincod.Size = new System.Drawing.Size(218, 46);
            this.btnadmincod.TabIndex = 11;
            this.btnadmincod.Text = "Devam";
            this.btnadmincod.UseVisualStyleBackColor = true;
            this.btnadmincod.Click += new System.EventHandler(this.btnadmincod_Click);
            // 
            // txtadmincod
            // 
            this.txtadmincod.Location = new System.Drawing.Point(118, 73);
            this.txtadmincod.Name = "txtadmincod";
            this.txtadmincod.Size = new System.Drawing.Size(128, 20);
            this.txtadmincod.TabIndex = 10;
            this.txtadmincod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcodsended2
            // 
            this.lblcodsended2.AutoSize = true;
            this.lblcodsended2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcodsended2.ForeColor = System.Drawing.Color.White;
            this.lblcodsended2.Location = new System.Drawing.Point(4, 25);
            this.lblcodsended2.Name = "lblcodsended2";
            this.lblcodsended2.Size = new System.Drawing.Size(342, 23);
            this.lblcodsended2.TabIndex = 9;
            this.lblcodsended2.Text = "Emailine gonderilen kodu asagidaki yere gir";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage4.Controls.Add(this.lbladminnewpassword);
            this.tabPage4.Controls.Add(this.btnadminsavepass);
            this.tabPage4.Controls.Add(this.txtadminnewpass);
            this.tabPage4.Controls.Add(this.txtadminconfirmpass);
            this.tabPage4.Controls.Add(this.lbladminconfirmpass);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(359, 260);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // lbladminnewpassword
            // 
            this.lbladminnewpassword.AutoSize = true;
            this.lbladminnewpassword.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladminnewpassword.ForeColor = System.Drawing.Color.White;
            this.lbladminnewpassword.Location = new System.Drawing.Point(53, 23);
            this.lbladminnewpassword.Name = "lbladminnewpassword";
            this.lbladminnewpassword.Size = new System.Drawing.Size(98, 23);
            this.lbladminnewpassword.TabIndex = 29;
            this.lbladminnewpassword.Text = "Yeni Sifre : ";
            // 
            // btnadminsavepass
            // 
            this.btnadminsavepass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnadminsavepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadminsavepass.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminsavepass.ForeColor = System.Drawing.Color.White;
            this.btnadminsavepass.Location = new System.Drawing.Point(18, 117);
            this.btnadminsavepass.Name = "btnadminsavepass";
            this.btnadminsavepass.Size = new System.Drawing.Size(320, 41);
            this.btnadminsavepass.TabIndex = 33;
            this.btnadminsavepass.Text = "Kaydet";
            this.btnadminsavepass.UseVisualStyleBackColor = true;
            this.btnadminsavepass.Click += new System.EventHandler(this.btnadminsavepass_Click);
            // 
            // txtadminnewpass
            // 
            this.txtadminnewpass.Location = new System.Drawing.Point(149, 24);
            this.txtadminnewpass.Multiline = true;
            this.txtadminnewpass.Name = "txtadminnewpass";
            this.txtadminnewpass.Size = new System.Drawing.Size(171, 23);
            this.txtadminnewpass.TabIndex = 31;
            // 
            // txtadminconfirmpass
            // 
            this.txtadminconfirmpass.Location = new System.Drawing.Point(149, 69);
            this.txtadminconfirmpass.Multiline = true;
            this.txtadminconfirmpass.Name = "txtadminconfirmpass";
            this.txtadminconfirmpass.Size = new System.Drawing.Size(171, 23);
            this.txtadminconfirmpass.TabIndex = 32;
            // 
            // lbladminconfirmpass
            // 
            this.lbladminconfirmpass.AutoSize = true;
            this.lbladminconfirmpass.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladminconfirmpass.ForeColor = System.Drawing.Color.White;
            this.lbladminconfirmpass.Location = new System.Drawing.Point(14, 69);
            this.lbladminconfirmpass.Name = "lbladminconfirmpass";
            this.lbladminconfirmpass.Size = new System.Drawing.Size(140, 23);
            this.lbladminconfirmpass.TabIndex = 30;
            this.lbladminconfirmpass.Text = "Sifreyi Dogrula : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 23);
            this.panel1.TabIndex = 34;
            // 
            // AdminGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giris Formu";
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnadminlog;
        private System.Windows.Forms.Button btncanceladmin;
        private System.Windows.Forms.LinkLabel linkLabellost2;
        private System.Windows.Forms.TextBox txtyoneticisifre;
        private System.Windows.Forms.TextBox txtyoneticiemail;
        private System.Windows.Forms.Label lbladminpass;
        private System.Windows.Forms.Label lbladminname;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Button btncanceladmin2;
        private System.Windows.Forms.Button btnadminsendcod;
        private System.Windows.Forms.TextBox txtadminemail;
        private System.Windows.Forms.Label lbladminemail;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnadmincod;
        private System.Windows.Forms.TextBox txtadmincod;
        private System.Windows.Forms.Label lblcodsended2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbladminnewpassword;
        private System.Windows.Forms.Button btnadminsavepass;
        private System.Windows.Forms.TextBox txtadminnewpass;
        private System.Windows.Forms.TextBox txtadminconfirmpass;
        private System.Windows.Forms.Label lbladminconfirmpass;
        private System.Windows.Forms.Panel panel1;
    }
}