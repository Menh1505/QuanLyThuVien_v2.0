using System.Drawing;
using System.Drawing.Drawing2D;

namespace QuanLyThuVien_v2._0
{
    partial class F_Book
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
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btn_clearSearch = new System.Windows.Forms.Button();
            this.txtb_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_find.FlatAppearance.BorderSize = 0;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_find.Image = global::QuanLyThuVien_v2._0.Properties.Resources.search;
            this.btn_find.Location = new System.Drawing.Point(144, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(36, 36);
            this.btn_find.TabIndex = 3;
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Image = global::QuanLyThuVien_v2._0.Properties.Resources.remove;
            this.btn_delete.Location = new System.Drawing.Point(79, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(36, 36);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.Location = new System.Drawing.Point(0, 59);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1084, 610);
            this.panelDesktop.TabIndex = 4;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panelSearch.Controls.Add(this.btn_clearSearch);
            this.panelSearch.Controls.Add(this.btn_find);
            this.panelSearch.Controls.Add(this.txtb_search);
            this.panelSearch.Controls.Add(this.btn_add);
            this.panelSearch.Controls.Add(this.btn_delete);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1084, 59);
            this.panelSearch.TabIndex = 3;
            // 
            // btn_clearSearch
            // 
            this.btn_clearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clearSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clearSearch.BackgroundImage = global::QuanLyThuVien_v2._0.Properties.Resources.close;
            this.btn_clearSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clearSearch.FlatAppearance.BorderSize = 0;
            this.btn_clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearSearch.Location = new System.Drawing.Point(1032, 12);
            this.btn_clearSearch.Name = "btn_clearSearch";
            this.btn_clearSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_clearSearch.Size = new System.Drawing.Size(34, 34);
            this.btn_clearSearch.TabIndex = 1;
            this.btn_clearSearch.UseVisualStyleBackColor = false;
            this.btn_clearSearch.Click += new System.EventHandler(this.btn_clearSearch_Click);
            // 
            // txtb_search
            // 
            this.txtb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_search.BackColor = System.Drawing.SystemColors.Control;
            this.txtb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtb_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtb_search.Location = new System.Drawing.Point(208, 9);
            this.txtb_search.Name = "txtb_search";
            this.txtb_search.Size = new System.Drawing.Size(864, 41);
            this.txtb_search.TabIndex = 0;
            this.txtb_search.Click += new System.EventHandler(this.txtb_search_Click);
            this.txtb_search.TextChanged += new System.EventHandler(this.txtb_search_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Image = global::QuanLyThuVien_v2._0.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(13, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 36);
            this.btn_add.TabIndex = 0;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 669);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Book";
            this.Text = "F_Book";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtb_search;
        private System.Windows.Forms.Button btn_clearSearch;
    }
}