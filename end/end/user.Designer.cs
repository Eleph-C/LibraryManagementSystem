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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnborrowedbooks = new System.Windows.Forms.Button();
            this.btnchangepass = new System.Windows.Forms.Button();
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
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelchangepass.SuspendLayout();
            this.panelbooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnborrowedbooks);
            this.groupBox1.Controls.Add(this.btnchangepass);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // btnborrowedbooks
            // 
            this.btnborrowedbooks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnborrowedbooks.FlatAppearance.BorderSize = 2;
            this.btnborrowedbooks.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnborrowedbooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrowedbooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnborrowedbooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrowedbooks.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnborrowedbooks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnborrowedbooks.Location = new System.Drawing.Point(6, 61);
            this.btnborrowedbooks.Name = "btnborrowedbooks";
            this.btnborrowedbooks.Size = new System.Drawing.Size(116, 58);
            this.btnborrowedbooks.TabIndex = 0;
            this.btnborrowedbooks.Text = "Borrowed Books";
            this.btnborrowedbooks.UseVisualStyleBackColor = true;
            this.btnborrowedbooks.Click += new System.EventHandler(this.btnborrowedbooks_Click);
            // 
            // btnchangepass
            // 
            this.btnchangepass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnchangepass.FlatAppearance.BorderSize = 2;
            this.btnchangepass.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnchangepass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnchangepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchangepass.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnchangepass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnchangepass.Location = new System.Drawing.Point(6, 193);
            this.btnchangepass.Name = "btnchangepass";
            this.btnchangepass.Size = new System.Drawing.Size(116, 59);
            this.btnchangepass.TabIndex = 1;
            this.btnchangepass.Text = "Change Password";
            this.btnchangepass.UseVisualStyleBackColor = true;
            this.btnchangepass.Click += new System.EventHandler(this.btnchangepass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Controls.Add(this.btnresetpass);
            this.groupBox2.Controls.Add(this.txtconfirmpass);
            this.groupBox2.Controls.Add(this.txtnewpass);
            this.groupBox2.Controls.Add(this.lblconfirmpass);
            this.groupBox2.Controls.Add(this.lblnewpass);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(203, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHANGE PASSWORD";
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnclear.FlatAppearance.BorderSize = 2;
            this.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclear.Location = new System.Drawing.Point(72, 207);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(221, 31);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnresetpass
            // 
            this.btnresetpass.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnresetpass.FlatAppearance.BorderSize = 2;
            this.btnresetpass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnresetpass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnresetpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresetpass.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresetpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnresetpass.Location = new System.Drawing.Point(72, 170);
            this.btnresetpass.Name = "btnresetpass";
            this.btnresetpass.Size = new System.Drawing.Size(221, 31);
            this.btnresetpass.TabIndex = 4;
            this.btnresetpass.Text = "Reset Password";
            this.btnresetpass.UseVisualStyleBackColor = true;
            this.btnresetpass.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(165, 96);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(128, 22);
            this.txtconfirmpass.TabIndex = 3;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(165, 60);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(128, 22);
            this.txtnewpass.TabIndex = 2;
            // 
            // lblconfirmpass
            // 
            this.lblconfirmpass.AutoSize = true;
            this.lblconfirmpass.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblconfirmpass.Location = new System.Drawing.Point(10, 96);
            this.lblconfirmpass.Name = "lblconfirmpass";
            this.lblconfirmpass.Size = new System.Drawing.Size(149, 21);
            this.lblconfirmpass.TabIndex = 1;
            this.lblconfirmpass.Text = "Confirm Password :";
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnewpass.Location = new System.Drawing.Point(36, 61);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(123, 21);
            this.lblnewpass.TabIndex = 0;
            this.lblnewpass.Text = "New Password :";
            // 
            // panelchangepass
            // 
            this.panelchangepass.Controls.Add(this.groupBox2);
            this.panelchangepass.Location = new System.Drawing.Point(165, 86);
            this.panelchangepass.Name = "panelchangepass";
            this.panelchangepass.Size = new System.Drawing.Size(692, 477);
            this.panelchangepass.TabIndex = 2;
            // 
            // panelbooks
            // 
            this.panelbooks.Controls.Add(this.btnresfresh);
            this.panelbooks.Controls.Add(this.booksdata);
            this.panelbooks.Controls.Add(this.lbltakenbooks);
            this.panelbooks.Location = new System.Drawing.Point(165, 86);
            this.panelbooks.Name = "panelbooks";
            this.panelbooks.Size = new System.Drawing.Size(692, 477);
            this.panelbooks.TabIndex = 3;
            // 
            // btnresfresh
            // 
            this.btnresfresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresfresh.Location = new System.Drawing.Point(614, 370);
            this.btnresfresh.Name = "btnresfresh";
            this.btnresfresh.Size = new System.Drawing.Size(75, 23);
            this.btnresfresh.TabIndex = 6;
            this.btnresfresh.Text = "REFRESH";
            this.btnresfresh.UseVisualStyleBackColor = true;
            // 
            // booksdata
            // 
            this.booksdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksdata.Location = new System.Drawing.Point(3, 103);
            this.booksdata.Name = "booksdata";
            this.booksdata.Size = new System.Drawing.Size(686, 261);
            this.booksdata.TabIndex = 7;
            // 
            // lbltakenbooks
            // 
            this.lbltakenbooks.AutoSize = true;
            this.lbltakenbooks.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltakenbooks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltakenbooks.Location = new System.Drawing.Point(9, 63);
            this.lbltakenbooks.Name = "lbltakenbooks";
            this.lbltakenbooks.Size = new System.Drawing.Size(222, 22);
            this.lbltakenbooks.TabIndex = 1;
            this.lbltakenbooks.Text = "The Books Which Have Taken :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.borrowedBooksToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.changePasswordToolStripMenuItem.Text = "CHANGE PASSWORD";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // borrowedBooksToolStripMenuItem
            // 
            this.borrowedBooksToolStripMenuItem.Name = "borrowedBooksToolStripMenuItem";
            this.borrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.borrowedBooksToolStripMenuItem.Text = "BORROWED BOOKS";
            this.borrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.borrowedBooksToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.signOutToolStripMenuItem.Text = "SIGN OUT";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelbooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelchangepass);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C&U LIBRARY";
            this.Load += new System.EventHandler(this.user_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelchangepass.ResumeLayout(false);
            this.panelbooks.ResumeLayout(false);
            this.panelbooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnborrowedbooks;
        private System.Windows.Forms.Button btnchangepass;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView booksdata;
        private System.Windows.Forms.Button btnresfresh;
    }
}