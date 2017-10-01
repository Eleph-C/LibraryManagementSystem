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
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcontactwithdrctr
            // 
            this.lblcontactwithdrctr.AutoSize = true;
            this.lblcontactwithdrctr.BackColor = System.Drawing.Color.Transparent;
            this.lblcontactwithdrctr.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactwithdrctr.ForeColor = System.Drawing.Color.White;
            this.lblcontactwithdrctr.Location = new System.Drawing.Point(284, 9);
            this.lblcontactwithdrctr.Name = "lblcontactwithdrctr";
            this.lblcontactwithdrctr.Size = new System.Drawing.Size(403, 24);
            this.lblcontactwithdrctr.TabIndex = 22;
            this.lblcontactwithdrctr.Text = "Kayit Olmak Icin Lutfen Kutuphaneciye Basvurun";
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
            this.btnadminlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnadminlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnadminlogin.FlatAppearance.BorderSize = 2;
            this.btnadminlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnadminlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnadminlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadminlogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminlogin.ForeColor = System.Drawing.Color.White;
            this.btnadminlogin.Location = new System.Drawing.Point(568, 236);
            this.btnadminlogin.Name = "btnadminlogin";
            this.btnadminlogin.Size = new System.Drawing.Size(174, 72);
            this.btnadminlogin.TabIndex = 18;
            this.btnadminlogin.Text = "Yonetici Girisi";
            this.btnadminlogin.UseVisualStyleBackColor = false;
            this.btnadminlogin.Click += new System.EventHandler(this.btnadminlogin_Click);
            // 
            // btnuserlogin
            // 
            this.btnuserlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnuserlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnuserlogin.FlatAppearance.BorderSize = 2;
            this.btnuserlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnuserlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnuserlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserlogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuserlogin.ForeColor = System.Drawing.Color.White;
            this.btnuserlogin.Location = new System.Drawing.Point(24, 236);
            this.btnuserlogin.Name = "btnuserlogin";
            this.btnuserlogin.Size = new System.Drawing.Size(174, 72);
            this.btnuserlogin.TabIndex = 17;
            this.btnuserlogin.Text = "Uye Girisi";
            this.btnuserlogin.UseVisualStyleBackColor = false;
            this.btnuserlogin.Click += new System.EventHandler(this.btnuserlogin_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(182, 66);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(173, 20);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearchbook
            // 
            this.lblsearchbook.AutoSize = true;
            this.lblsearchbook.BackColor = System.Drawing.Color.Transparent;
            this.lblsearchbook.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchbook.ForeColor = System.Drawing.Color.White;
            this.lblsearchbook.Location = new System.Drawing.Point(66, 66);
            this.lblsearchbook.Name = "lblsearchbook";
            this.lblsearchbook.Size = new System.Drawing.Size(107, 17);
            this.lblsearchbook.TabIndex = 21;
            this.lblsearchbook.Text = "Bir Kitap Ara : ";
            // 
            // btnrules
            // 
            this.btnrules.BackColor = System.Drawing.Color.Transparent;
            this.btnrules.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrules.FlatAppearance.BorderSize = 2;
            this.btnrules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnrules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnrules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrules.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrules.ForeColor = System.Drawing.Color.White;
            this.btnrules.Location = new System.Drawing.Point(252, 199);
            this.btnrules.Name = "btnrules";
            this.btnrules.Size = new System.Drawing.Size(164, 59);
            this.btnrules.TabIndex = 20;
            this.btnrules.Text = "Kutuphane Kurallari";
            this.btnrules.UseVisualStyleBackColor = false;
            this.btnrules.Click += new System.EventHandler(this.btnrules_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 334);
            this.Controls.Add(this.lblcontactwithdrctr);
            this.Controls.Add(this.booksdata);
            this.Controls.Add(this.btnadminlogin);
            this.Controls.Add(this.btnuserlogin);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearchbook);
            this.Controls.Add(this.btnrules);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C&U LIBRARY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.Click += new System.EventHandler(this.login_Click);
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcontactwithdrctr;
        private System.Windows.Forms.DataGridView booksdata;
        private System.Windows.Forms.Button btnadminlogin;
        private System.Windows.Forms.Button btnuserlogin;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearchbook;
        private System.Windows.Forms.Button btnrules;

    }
}