namespace end
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.btnkitaplariniz = new System.Windows.Forms.Button();
            this.btnsifredegis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnresetpass = new System.Windows.Forms.Button();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.lblconfirmpass = new System.Windows.Forms.Label();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.panelchangepass = new System.Windows.Forms.Panel();
            this.panelbooks = new System.Windows.Forms.Panel();
            this.btnresfresh = new System.Windows.Forms.Button();
            this.booksdata = new System.Windows.Forms.DataGridView();
            this.lbltakenbooks = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panelchangepass.SuspendLayout();
            this.panelbooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnkitaplariniz
            // 
            this.btnkitaplariniz.BackColor = System.Drawing.Color.Transparent;
            this.btnkitaplariniz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkitaplariniz.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnkitaplariniz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnkitaplariniz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnkitaplariniz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkitaplariniz.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitaplariniz.ForeColor = System.Drawing.Color.White;
            this.btnkitaplariniz.Location = new System.Drawing.Point(12, 173);
            this.btnkitaplariniz.Name = "btnkitaplariniz";
            this.btnkitaplariniz.Size = new System.Drawing.Size(116, 58);
            this.btnkitaplariniz.TabIndex = 0;
            this.btnkitaplariniz.Text = "Kitaplariniz";
            this.btnkitaplariniz.UseVisualStyleBackColor = false;
            this.btnkitaplariniz.Click += new System.EventHandler(this.btnkitaplariniz_Click);
            // 
            // btnsifredegis
            // 
            this.btnsifredegis.BackColor = System.Drawing.Color.Transparent;
            this.btnsifredegis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsifredegis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnsifredegis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnsifredegis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsifredegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsifredegis.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifredegis.ForeColor = System.Drawing.Color.White;
            this.btnsifredegis.Location = new System.Drawing.Point(12, 305);
            this.btnsifredegis.Name = "btnsifredegis";
            this.btnsifredegis.Size = new System.Drawing.Size(116, 59);
            this.btnsifredegis.TabIndex = 1;
            this.btnsifredegis.Text = "Sifreni Degistir";
            this.btnsifredegis.UseVisualStyleBackColor = false;
            this.btnsifredegis.Click += new System.EventHandler(this.btnsifredegis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Controls.Add(this.btnresetpass);
            this.groupBox2.Controls.Add(this.txtconfirmpass);
            this.groupBox2.Controls.Add(this.txtnewpass);
            this.groupBox2.Controls.Add(this.lblconfirmpass);
            this.groupBox2.Controls.Add(this.lblnewpass);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(31, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sifre Degis";
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnclear.FlatAppearance.BorderSize = 2;
            this.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(22, 196);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(295, 31);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Temizle";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnresetpass
            // 
            this.btnresetpass.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnresetpass.FlatAppearance.BorderSize = 2;
            this.btnresetpass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnresetpass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnresetpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresetpass.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresetpass.ForeColor = System.Drawing.Color.White;
            this.btnresetpass.Location = new System.Drawing.Point(22, 145);
            this.btnresetpass.Name = "btnresetpass";
            this.btnresetpass.Size = new System.Drawing.Size(295, 44);
            this.btnresetpass.TabIndex = 4;
            this.btnresetpass.Text = "Sifreyi Kaydet";
            this.btnresetpass.UseVisualStyleBackColor = true;
            this.btnresetpass.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(165, 96);
            this.txtconfirmpass.Multiline = true;
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(152, 22);
            this.txtconfirmpass.TabIndex = 3;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(165, 60);
            this.txtnewpass.Multiline = true;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(152, 22);
            this.txtnewpass.TabIndex = 2;
            // 
            // lblconfirmpass
            // 
            this.lblconfirmpass.AutoSize = true;
            this.lblconfirmpass.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpass.ForeColor = System.Drawing.Color.White;
            this.lblconfirmpass.Location = new System.Drawing.Point(18, 96);
            this.lblconfirmpass.Name = "lblconfirmpass";
            this.lblconfirmpass.Size = new System.Drawing.Size(126, 21);
            this.lblconfirmpass.TabIndex = 1;
            this.lblconfirmpass.Text = "Sifreyi Dogrula :";
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpass.ForeColor = System.Drawing.Color.White;
            this.lblnewpass.Location = new System.Drawing.Point(57, 61);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(87, 21);
            this.lblnewpass.TabIndex = 0;
            this.lblnewpass.Text = "Yeni Sifre :";
            // 
            // panelchangepass
            // 
            this.panelchangepass.BackColor = System.Drawing.Color.Transparent;
            this.panelchangepass.Controls.Add(this.groupBox2);
            this.panelchangepass.Location = new System.Drawing.Point(165, 86);
            this.panelchangepass.Name = "panelchangepass";
            this.panelchangepass.Size = new System.Drawing.Size(437, 379);
            this.panelchangepass.TabIndex = 2;
            // 
            // panelbooks
            // 
            this.panelbooks.BackColor = System.Drawing.Color.Transparent;
            this.panelbooks.Controls.Add(this.btnresfresh);
            this.panelbooks.Controls.Add(this.booksdata);
            this.panelbooks.Controls.Add(this.lbltakenbooks);
            this.panelbooks.Location = new System.Drawing.Point(165, 86);
            this.panelbooks.Name = "panelbooks";
            this.panelbooks.Size = new System.Drawing.Size(437, 379);
            this.panelbooks.TabIndex = 3;
            // 
            // btnresfresh
            // 
            this.btnresfresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnresfresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnresfresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnresfresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresfresh.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresfresh.ForeColor = System.Drawing.Color.White;
            this.btnresfresh.Location = new System.Drawing.Point(328, 278);
            this.btnresfresh.Name = "btnresfresh";
            this.btnresfresh.Size = new System.Drawing.Size(106, 27);
            this.btnresfresh.TabIndex = 6;
            this.btnresfresh.Text = "Yenile";
            this.btnresfresh.UseVisualStyleBackColor = true;
            // 
            // booksdata
            // 
            this.booksdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksdata.Location = new System.Drawing.Point(3, 103);
            this.booksdata.Name = "booksdata";
            this.booksdata.Size = new System.Drawing.Size(431, 150);
            this.booksdata.TabIndex = 7;
            // 
            // lbltakenbooks
            // 
            this.lbltakenbooks.AutoSize = true;
            this.lbltakenbooks.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltakenbooks.ForeColor = System.Drawing.Color.White;
            this.lbltakenbooks.Location = new System.Drawing.Point(3, 59);
            this.lbltakenbooks.Name = "lbltakenbooks";
            this.lbltakenbooks.Size = new System.Drawing.Size(271, 28);
            this.lbltakenbooks.TabIndex = 1;
            this.lbltakenbooks.Text = "Sahip Oldugunuz Kitaplar :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.borrowedBooksToolStripMenuItem,
            this.toolStripMenuItem2,
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "Dosya";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.changePasswordToolStripMenuItem.Text = "Sifre Degis";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // borrowedBooksToolStripMenuItem
            // 
            this.borrowedBooksToolStripMenuItem.Name = "borrowedBooksToolStripMenuItem";
            this.borrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.borrowedBooksToolStripMenuItem.Text = "Sahip Olunan Kitaplar";
            this.borrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.borrowedBooksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.signOutToolStripMenuItem.Text = "Oturumu Kapat";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.helpToolStripMenuItem.Text = "Yardim";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 502);
            this.Controls.Add(this.btnkitaplariniz);
            this.Controls.Add(this.btnsifredegis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelchangepass);
            this.Controls.Add(this.panelbooks);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C&U LIBRARY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.user_FormClosing);
            this.Load += new System.EventHandler(this.user_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelchangepass.ResumeLayout(false);
            this.panelbooks.ResumeLayout(false);
            this.panelbooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkitaplariniz;
        private System.Windows.Forms.Button btnsifredegis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnresetpass;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label lblconfirmpass;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.Panel panelchangepass;
        private System.Windows.Forms.Panel panelbooks;
        private System.Windows.Forms.Label lbltakenbooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView booksdata;
        private System.Windows.Forms.Button btnresfresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}