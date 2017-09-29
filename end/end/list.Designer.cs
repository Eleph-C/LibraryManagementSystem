namespace end
{
    partial class list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list));
            this.booksdata = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.comboitems = new System.Windows.Forms.ComboBox();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.lblcolumn = new System.Windows.Forms.Label();
            this.lblitem = new System.Windows.Forms.Label();
            this.paneltools = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).BeginInit();
            this.paneltools.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksdata
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.booksdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.booksdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksdata.Location = new System.Drawing.Point(1, 0);
            this.booksdata.Name = "booksdata";
            this.booksdata.Size = new System.Drawing.Size(864, 403);
            this.booksdata.TabIndex = 4;
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnrefresh.FlatAppearance.BorderSize = 2;
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrefresh.Location = new System.Drawing.Point(778, 412);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(87, 31);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // comboitems
            // 
            this.comboitems.FormattingEnabled = true;
            this.comboitems.Items.AddRange(new object[] {
            "KitapAdi",
            "KitapYazari",
            "KitapSayfaSayisi",
            "KitapYayinci",
            "KitapKategori",
            "KitapTercumani",
            "KitapYayinTarihi",
            "KitapSahibi"});
            this.comboitems.Location = new System.Drawing.Point(210, 3);
            this.comboitems.Name = "comboitems";
            this.comboitems.Size = new System.Drawing.Size(121, 21);
            this.comboitems.TabIndex = 0;
            // 
            // txtitems
            // 
            this.txtitems.Location = new System.Drawing.Point(210, 39);
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(121, 20);
            this.txtitems.TabIndex = 1;
            this.txtitems.TextChanged += new System.EventHandler(this.txtitems_TextChanged);
            // 
            // lblcolumn
            // 
            this.lblcolumn.AutoSize = true;
            this.lblcolumn.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolumn.Location = new System.Drawing.Point(19, 3);
            this.lblcolumn.Name = "lblcolumn";
            this.lblcolumn.Size = new System.Drawing.Size(173, 21);
            this.lblcolumn.TabIndex = 5;
            this.lblcolumn.Text = "Choose The Column :";
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitem.Location = new System.Drawing.Point(46, 36);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(146, 21);
            this.lblitem.TabIndex = 6;
            this.lblitem.Text = "Write The Item  :";
            // 
            // paneltools
            // 
            this.paneltools.BackColor = System.Drawing.Color.Transparent;
            this.paneltools.Controls.Add(this.lblitem);
            this.paneltools.Controls.Add(this.lblcolumn);
            this.paneltools.Controls.Add(this.txtitems);
            this.paneltools.Controls.Add(this.comboitems);
            this.paneltools.Location = new System.Drawing.Point(298, 414);
            this.paneltools.Name = "paneltools";
            this.paneltools.Size = new System.Drawing.Size(367, 92);
            this.paneltools.TabIndex = 7;
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 536);
            this.Controls.Add(this.paneltools);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.booksdata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "list";
            this.Text = "C&U LIBRARY";
            this.Load += new System.EventHandler(this.list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksdata)).EndInit();
            this.paneltools.ResumeLayout(false);
            this.paneltools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksdata;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.ComboBox comboitems;
        private System.Windows.Forms.TextBox txtitems;
        private System.Windows.Forms.Label lblcolumn;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Panel paneltools;
    }
}