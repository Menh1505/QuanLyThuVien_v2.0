namespace QuanLyThuVien_v2._0
{
    partial class F_main
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
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_borrower = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDisplay.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panelDisplay.Controls.Add(this.btn_Minimize);
            this.panelDisplay.Controls.Add(this.btn_Maximize);
            this.panelDisplay.Controls.Add(this.btn_close);
            this.panelDisplay.Controls.Add(this.btn_borrower);
            this.panelDisplay.Controls.Add(this.btn_Book);
            this.panelDisplay.Controls.Add(this.panelLogo);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1326, 76);
            this.panelDisplay.TabIndex = 0;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Image = global::QuanLyThuVien_v2._0.Properties.Resources.minimize_sign;
            this.btn_Minimize.Location = new System.Drawing.Point(1150, 13);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(50, 51);
            this.btn_Minimize.TabIndex = 7;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Image = global::QuanLyThuVien_v2._0.Properties.Resources.maximize;
            this.btn_Maximize.Location = new System.Drawing.Point(1207, 13);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(50, 51);
            this.btn_Maximize.TabIndex = 6;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::QuanLyThuVien_v2._0.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(1264, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 51);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_borrower
            // 
            this.btn_borrower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_borrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_borrower.FlatAppearance.BorderSize = 0;
            this.btn_borrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrower.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_borrower.Image = global::QuanLyThuVien_v2._0.Properties.Resources.user;
            this.btn_borrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrower.Location = new System.Drawing.Point(791, 10);
            this.btn_borrower.Name = "btn_borrower";
            this.btn_borrower.Size = new System.Drawing.Size(308, 55);
            this.btn_borrower.TabIndex = 2;
            this.btn_borrower.Text = "Quản Lý Người Mượn";
            this.btn_borrower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_borrower.UseVisualStyleBackColor = false;
            this.btn_borrower.Click += new System.EventHandler(this.btn_borrower_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Book.FlatAppearance.BorderSize = 0;
            this.btn_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Book.Image = global::QuanLyThuVien_v2._0.Properties.Resources.book;
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Book.Location = new System.Drawing.Point(445, 10);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(283, 55);
            this.btn_Book.TabIndex = 1;
            this.btn_Book.Text = "      Quản Lý Sách";
            this.btn_Book.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(439, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 76);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1326, 677);
            this.panelDesktop.TabIndex = 1;
            // 
            // F_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 753);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelDisplay.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_borrower;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

