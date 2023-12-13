namespace QuanLyThuVien_v2._0
{
    partial class F_filterBorrower
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
            this.checkBox_outDate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_borrEnd = new System.Windows.Forms.DateTimePicker();
            this.dtp_borrStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_outDate
            // 
            this.checkBox_outDate.AutoSize = true;
            this.checkBox_outDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_outDate.Location = new System.Drawing.Point(44, 336);
            this.checkBox_outDate.Name = "checkBox_outDate";
            this.checkBox_outDate.Size = new System.Drawing.Size(320, 33);
            this.checkBox_outDate.TabIndex = 0;
            this.checkBox_outDate.Text = "Lọc người quá hạn trả sách";
            this.checkBox_outDate.UseVisualStyleBackColor = true;
            this.checkBox_outDate.CheckedChanged += new System.EventHandler(this.checkBox_outDate_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đến ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Từ ngày";
            // 
            // dtp_borrEnd
            // 
            this.dtp_borrEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_borrEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_borrEnd.Location = new System.Drawing.Point(688, 170);
            this.dtp_borrEnd.Name = "dtp_borrEnd";
            this.dtp_borrEnd.Size = new System.Drawing.Size(332, 34);
            this.dtp_borrEnd.TabIndex = 12;
            // 
            // dtp_borrStart
            // 
            this.dtp_borrStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_borrStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_borrStart.Location = new System.Drawing.Point(254, 170);
            this.dtp_borrStart.Name = "dtp_borrStart";
            this.dtp_borrStart.Size = new System.Drawing.Size(332, 34);
            this.dtp_borrStart.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày mượn:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(763, 336);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(173, 55);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Quay về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(958, 336);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(173, 55);
            this.btn_filter.TabIndex = 16;
            this.btn_filter.Text = "Lọc";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // F_filterBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 403);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_borrEnd);
            this.Controls.Add(this.dtp_borrStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_outDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_filterBorrower";
            this.Text = "F_filterBorrower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_outDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtp_borrEnd;
        public System.Windows.Forms.DateTimePicker dtp_borrStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_filter;
    }
}