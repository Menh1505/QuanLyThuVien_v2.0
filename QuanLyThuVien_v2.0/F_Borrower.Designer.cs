namespace QuanLyThuVien_v2._0
{
    partial class F_Borrower
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
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btn_clearSearch = new System.Windows.Forms.Button();
            this.txtb_search = new System.Windows.Forms.TextBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dgv_borrower = new System.Windows.Forms.DataGridView();
            this.panelSearch.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrower)).BeginInit();
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
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(36, 36);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 36);
            this.btn_add.TabIndex = 0;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panelSearch.Controls.Add(this.btn_clearSearch);
            this.panelSearch.Controls.Add(this.btn_find);
            this.panelSearch.Controls.Add(this.txtb_search);
            this.panelSearch.Controls.Add(this.btn_delete);
            this.panelSearch.Controls.Add(this.btn_add);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1085, 59);
            this.panelSearch.TabIndex = 4;
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
            this.btn_clearSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clearSearch.Name = "btn_clearSearch";
            this.btn_clearSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_clearSearch.Size = new System.Drawing.Size(36, 36);
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
            this.txtb_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtb_search.Location = new System.Drawing.Point(208, 9);
            this.txtb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb_search.Name = "txtb_search";
            this.txtb_search.Size = new System.Drawing.Size(864, 41);
            this.txtb_search.TabIndex = 0;
            this.txtb_search.Click += new System.EventHandler(this.txtb_search_Click);
            this.txtb_search.TextChanged += new System.EventHandler(this.txtb_search_TextChanged);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.Controls.Add(this.dgv_borrower);
            this.panelDesktop.Location = new System.Drawing.Point(-1, 59);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1085, 610);
            this.panelDesktop.TabIndex = 5;
            // 
            // dgv_borrower
            // 
            this.dgv_borrower.AllowUserToAddRows = false;
            this.dgv_borrower.AllowUserToDeleteRows = false;
            this.dgv_borrower.AllowUserToResizeColumns = false;
            this.dgv_borrower.AllowUserToResizeRows = false;
            this.dgv_borrower.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_borrower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_borrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_borrower.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_borrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_borrower.EnableHeadersVisualStyles = false;
            this.dgv_borrower.Location = new System.Drawing.Point(0, 0);
            this.dgv_borrower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_borrower.Name = "dgv_borrower";
            this.dgv_borrower.ReadOnly = true;
            this.dgv_borrower.RowHeadersVisible = false;
            this.dgv_borrower.RowHeadersWidth = 51;
            this.dgv_borrower.RowTemplate.Height = 24;
            this.dgv_borrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_borrower.Size = new System.Drawing.Size(1085, 610);
            this.dgv_borrower.TabIndex = 0;
            // 
            // F_Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 670);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_Borrower";
            this.Text = "F_Borrower";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtb_search;
        private System.Windows.Forms.Button btn_clearSearch;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.DataGridView dgv_borrower;
    }
}