namespace end
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lblcontactwithdrctr = new System.Windows.Forms.Label();
            this.booksdata = new System.Windows.Forms.DataGridView();
            this.btnadminlogin = new System.Windows.Forms.Button();
            this.btnuserlogin = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearchbook = new System.Windows.Forms.Label();
            this.btnrules = new System.Windows.Forms.Button();
            this.btnrules2 = new System.Windows.Forms.Button();
            this.piclibraryrules = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclibraryrules)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcontactwithdrctr
            // 
            this.lblcontactwithdrctr.AutoSize = true;
            this.lblcontactwithdrctr.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactwithdrctr.Location = new System.Drawing.Point(238, 14);
            this.lblcontactwithdrctr.Name = "lblcontactwithdrctr";
            this.lblcontactwithdrctr.Size = new System.Drawing.Size(348, 24);
            this.lblcontactwithdrctr.TabIndex = 22;
            this.lblcontactwithdrctr.Text = "Kayit Olmak Icin Kutuphaneciye Basvurun";
            // 
            // booksdata
            // 
            this.booksdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksdata.Location = new System.Drawing.Point(24, 92);
            this.booksdata.Name = "booksdata";
            this.booksdata.Size = new System.Drawing.Size(718, 101);
            this.booksdata.TabIndex = 23;
            // 
            // btnadminlogin
            // 
            this.btnadminlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadminlogin.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminlogin.Location = new System.Drawing.Point(553, 305);
            this.btnadminlogin.Name = "btnadminlogin";
            this.btnadminlogin.Size = new System.Drawing.Size(174, 72);
            this.btnadminlogin.TabIndex = 18;
            this.btnadminlogin.Text = "Yonetici Girisi";
            this.btnadminlogin.UseVisualStyleBackColor = true;
            this.btnadminlogin.Click += new System.EventHandler(this.btnadminlogin_Click);
            // 
            // btnuserlogin
            // 
            this.btnuserlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnuserlogin.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuserlogin.ForeColor = System.Drawing.Color.Black;
            this.btnuserlogin.Location = new System.Drawing.Point(32, 305);
            this.btnuserlogin.Name = "btnuserlogin";
            this.btnuserlogin.Size = new System.Drawing.Size(174, 72);
            this.btnuserlogin.TabIndex = 17;
            this.btnuserlogin.Text = "Uye Girisi";
            this.btnuserlogin.UseVisualStyleBackColor = true;
            this.btnuserlogin.Click += new System.EventHandler(this.btnuserlogin_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(362, 64);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(173, 20);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearchbook
            // 
            this.lblsearchbook.AutoSize = true;
            this.lblsearchbook.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchbook.Location = new System.Drawing.Point(246, 64);
            this.lblsearchbook.Name = "lblsearchbook";
            this.lblsearchbook.Size = new System.Drawing.Size(81, 17);
            this.lblsearchbook.TabIndex = 21;
            this.lblsearchbook.Text = "Kitap Ara : ";
            // 
            // btnrules
            // 
            this.btnrules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrules.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrules.Location = new System.Drawing.Point(338, 199);
            this.btnrules.Name = "btnrules";
            this.btnrules.Size = new System.Drawing.Size(116, 35);
            this.btnrules.TabIndex = 20;
            this.btnrules.Text = "Kutuphane Kurallari";
            this.btnrules.UseVisualStyleBackColor = true;
            this.btnrules.Click += new System.EventHandler(this.btnrules_Click);
            // 
            // btnrules2
            // 
            this.btnrules2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrules2.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrules2.Location = new System.Drawing.Point(338, 199);
            this.btnrules2.Name = "btnrules2";
            this.btnrules2.Size = new System.Drawing.Size(116, 35);
            this.btnrules2.TabIndex = 25;
            this.btnrules2.Text = "Kutuphane Kurallari";
            this.btnrules2.UseVisualStyleBackColor = true;
            this.btnrules2.Click += new System.EventHandler(this.button1_Click);
            // 
            // piclibraryrules
            // 
            this.piclibraryrules.Image = ((System.Drawing.Image)(resources.GetObject("piclibraryrules.Image")));
            this.piclibraryrules.Location = new System.Drawing.Point(249, 240);
            this.piclibraryrules.Name = "piclibraryrules";
            this.piclibraryrules.Size = new System.Drawing.Size(270, 244);
            this.piclibraryrules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclibraryrules.TabIndex = 24;
            this.piclibraryrules.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 499);
            this.Controls.Add(this.piclibraryrules);
            this.Controls.Add(this.lblcontactwithdrctr);
            this.Controls.Add(this.booksdata);
            this.Controls.Add(this.btnadminlogin);
            this.Controls.Add(this.btnuserlogin);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearchbook);
            this.Controls.Add(this.btnrules);
            this.Controls.Add(this.btnrules2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C&U LIBRARY";
            this.Load += new System.EventHandler(this.login_Load);
            this.Click += new System.EventHandler(this.login_Click);
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclibraryrules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclibraryrules;
        private System.Windows.Forms.Label lblcontactwithdrctr;
        private System.Windows.Forms.DataGridView booksdata;
        private System.Windows.Forms.Button btnadminlogin;
        private System.Windows.Forms.Button btnuserlogin;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearchbook;
        private System.Windows.Forms.Button btnrules;
        private System.Windows.Forms.Button btnrules2;

    }
}