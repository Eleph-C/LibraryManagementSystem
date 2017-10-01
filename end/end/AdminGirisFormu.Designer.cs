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
            this.tabPage1.Size = new System.Drawing.Size(342, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnadminlog
            // 
            this.btnadminlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadminlog.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminlog.Location = new System.Drawing.Point(172, 178);
            this.btnadminlog.Name = "btnadminlog";
            this.btnadminlog.Size = new System.Drawing.Size(159, 41);
            this.btnadminlog.TabIndex = 35;
            this.btnadminlog.Text = "Giris";
            this.btnadminlog.UseVisualStyleBackColor = true;
            this.btnadminlog.Click += new System.EventHandler(this.btnadminlog_Click);
            // 
            // btncanceladmin
            // 
            this.btncanceladmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncanceladmin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncanceladmin.Location = new System.Drawing.Point(7, 178);
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
            this.linkLabellost2.Location = new System.Drawing.Point(56, 144);
            this.linkLabellost2.Name = "linkLabellost2";
            this.linkLabellost2.Size = new System.Drawing.Size(99, 13);
            this.linkLabellost2.TabIndex = 31;
            this.linkLabellost2.TabStop = true;
            this.linkLabellost2.Text = "Sifreni mi Unuttun ?";
            this.linkLabellost2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabellost2_LinkClicked);
            // 
            // txtyoneticisifre
            // 
            this.txtyoneticisifre.Location = new System.Drawing.Point(151, 103);
            this.txtyoneticisifre.Name = "txtyoneticisifre";
            this.txtyoneticisifre.Size = new System.Drawing.Size(139, 20);
            this.txtyoneticisifre.TabIndex = 33;
            this.txtyoneticisifre.UseSystemPasswordChar = true;
            // 
            // txtyoneticiemail
            // 
            this.txtyoneticiemail.Location = new System.Drawing.Point(151, 66);
            this.txtyoneticiemail.Name = "txtyoneticiemail";
            this.txtyoneticiemail.Size = new System.Drawing.Size(139, 20);
            this.txtyoneticiemail.TabIndex = 32;
            // 
            // lbladminpass
            // 
            this.lbladminpass.AutoSize = true;
            this.lbladminpass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladminpass.Location = new System.Drawing.Point(82, 101);
            this.lbladminpass.Name = "lbladminpass";
            this.lbladminpass.Size = new System.Drawing.Size(65, 23);
            this.lbladminpass.TabIndex = 30;
            this.lbladminpass.Text = "Sifre : ";
            // 
            // lbladminname
            // 
            this.lbladminname.AutoSize = true;
            this.lbladminname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladminname.Location = new System.Drawing.Point(82, 63);
            this.lbladminname.Name = "lbladminname";
            this.lbladminname.Size = new System.Drawing.Size(64, 23);
            this.lbladminname.TabIndex = 29;
            this.lbladminname.Text = "Email : ";
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladmin.Location = new System.Drawing.Point(7, 23);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(129, 26);
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
            this.tabPage2.Size = new System.Drawing.Size(342, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btncanceladmin2
            // 
            this.btncanceladmin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncanceladmin2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncanceladmin2.Location = new System.Drawing.Point(25, 132);
            this.btncanceladmin2.Name = "btncanceladmin2";
            this.btncanceladmin2.Size = new System.Drawing.Size(127, 55);
            this.btncanceladmin2.TabIndex = 15;
            this.btncanceladmin2.Text = "Iptal";
            this.btncanceladmin2.UseVisualStyleBackColor = true;
            this.btncanceladmin2.Click += new System.EventHandler(this.btncanceladmin2_Click);
            // 
            // btnadminsendcod
            // 
            this.btnadminsendcod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadminsendcod.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminsendcod.Location = new System.Drawing.Point(158, 132);
            this.btnadminsendcod.Name = "btnadminsendcod";
            this.btnadminsendcod.Size = new System.Drawing.Size(178, 55);
            this.btnadminsendcod.TabIndex = 14;
            this.btnadminsendcod.Text = "Guvenlik Kodunu Gonder";
            this.btnadminsendcod.UseVisualStyleBackColor = true;
            this.btnadminsendcod.Click += new System.EventHandler(this.btnadminsendcod_Click);
            // 
            // txtadminemail
            // 
            this.txtadminemail.Location = new System.Drawing.Point(123, 98);
            this.txtadminemail.Name = "txtadminemail";
            this.txtadminemail.Size = new System.Drawing.Size(194, 20);
            this.txtadminemail.TabIndex = 13;
            // 
            // lbladminemail
            // 
            this.lbladminemail.AutoSize = true;
            this.lbladminemail.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbladminemail.Location = new System.Drawing.Point(59, 96);
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
            this.tabPage3.Size = new System.Drawing.Size(342, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnadmincod
            // 
            this.btnadmincod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadmincod.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmincod.Location = new System.Drawing.Point(101, 160);
            this.btnadmincod.Name = "btnadmincod";
            this.btnadmincod.Size = new System.Drawing.Size(159, 41);
            this.btnadmincod.TabIndex = 11;
            this.btnadmincod.Text = "Devam";
            this.btnadmincod.UseVisualStyleBackColor = true;
            this.btnadmincod.Click += new System.EventHandler(this.btnadmincod_Click);
            // 
            // txtadmincod
            // 
            this.txtadmincod.Location = new System.Drawing.Point(101, 118);
            this.txtadmincod.Name = "txtadmincod";
            this.txtadmincod.Size = new System.Drawing.Size(159, 20);
            this.txtadmincod.TabIndex = 10;
            this.txtadmincod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcodsended2
            // 
            this.lblcodsended2.AutoSize = true;
            this.lblcodsended2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblcodsended2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcodsended2.Location = new System.Drawing.Point(7, 70);
            this.lblcodsended2.Name = "lblcodsended2";
            this.lblcodsended2.Size = new System.Drawing.Size(325, 23);
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
            this.lbladminnewpassword.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbladminnewpassword.Location = new System.Drawing.Point(81, 64);
            this.lbladminnewpassword.Name = "lbladminnewpassword";
            this.lbladminnewpassword.Size = new System.Drawing.Size(102, 23);
            this.lbladminnewpassword.TabIndex = 29;
            this.lbladminnewpassword.Text = "Yeni Sifre : ";
            // 
            // btnadminsavepass
            // 
            this.btnadminsavepass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadminsavepass.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminsavepass.Location = new System.Drawing.Point(12, 158);
            this.btnadminsavepass.Name = "btnadminsavepass";
            this.btnadminsavepass.Size = new System.Drawing.Size(320, 41);
            this.btnadminsavepass.TabIndex = 33;
            this.btnadminsavepass.Text = "Kaydet";
            this.btnadminsavepass.UseVisualStyleBackColor = true;
            this.btnadminsavepass.Click += new System.EventHandler(this.btnadminsavepass_Click);
            // 
            // txtadminnewpass
            // 
            this.txtadminnewpass.Location = new System.Drawing.Point(186, 67);
            this.txtadminnewpass.Name = "txtadminnewpass";
            this.txtadminnewpass.Size = new System.Drawing.Size(146, 20);
            this.txtadminnewpass.TabIndex = 31;
            // 
            // txtadminconfirmpass
            // 
            this.txtadminconfirmpass.Location = new System.Drawing.Point(186, 112);
            this.txtadminconfirmpass.Name = "txtadminconfirmpass";
            this.txtadminconfirmpass.Size = new System.Drawing.Size(146, 20);
            this.txtadminconfirmpass.TabIndex = 32;
            // 
            // lbladminconfirmpass
            // 
            this.lbladminconfirmpass.AutoSize = true;
            this.lbladminconfirmpass.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbladminconfirmpass.Location = new System.Drawing.Point(8, 110);
            this.lbladminconfirmpass.Name = "lbladminconfirmpass";
            this.lbladminconfirmpass.Size = new System.Drawing.Size(178, 23);
            this.lbladminconfirmpass.TabIndex = 30;
            this.lbladminconfirmpass.Text = "Yeni Sifreyi Dogrula : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 23);
            this.panel1.TabIndex = 34;
            // 
            // AdminGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGirisFormu";
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