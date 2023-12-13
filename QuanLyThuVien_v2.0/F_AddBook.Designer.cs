namespace QuanLyThuVien_v2._0
{
    partial class F_AddBook
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
            this.btn_choosePicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtb_bookName = new System.Windows.Forms.TextBox();
            this.txtb_author = new System.Windows.Forms.TextBox();
            this.txtb_genre = new System.Windows.Forms.TextBox();
            this.txtb_publisher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtb_description = new System.Windows.Forms.TextBox();
            this.dtp_publicationDate = new System.Windows.Forms.DateTimePicker();
            this.nud_Copies = new System.Windows.Forms.NumericUpDown();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.nud_pages = new System.Windows.Forms.NumericUpDown();
            this.pb_book = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_choosePicture
            // 
            this.btn_choosePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_choosePicture.Location = new System.Drawing.Point(59, 451);
            this.btn_choosePicture.Name = "btn_choosePicture";
            this.btn_choosePicture.Size = new System.Drawing.Size(147, 30);
            this.btn_choosePicture.TabIndex = 1;
            this.btn_choosePicture.Text = "Chọn ảnh";
            this.btn_choosePicture.UseVisualStyleBackColor = true;
            this.btn_choosePicture.Click += new System.EventHandler(this.btn_choosePicture_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên sách:";
            // 
            // txtb_isbn
            // 
            this.txtb_isbn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_isbn.Location = new System.Drawing.Point(532, 19);
            this.txtb_isbn.Name = "txtb_isbn";
            this.txtb_isbn.Size = new System.Drawing.Size(421, 34);
            this.txtb_isbn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tác giả:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thể loại:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhà phát hành:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày phát hành:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số trang:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã sách (ISBN):";
            // 
            // txtb_bookName
            // 
            this.txtb_bookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_bookName.Location = new System.Drawing.Point(532, 76);
            this.txtb_bookName.Name = "txtb_bookName";
            this.txtb_bookName.Size = new System.Drawing.Size(421, 34);
            this.txtb_bookName.TabIndex = 3;
            // 
            // txtb_author
            // 
            this.txtb_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_author.Location = new System.Drawing.Point(532, 133);
            this.txtb_author.Name = "txtb_author";
            this.txtb_author.Size = new System.Drawing.Size(421, 34);
            this.txtb_author.TabIndex = 4;
            // 
            // txtb_genre
            // 
            this.txtb_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_genre.Location = new System.Drawing.Point(532, 190);
            this.txtb_genre.Name = "txtb_genre";
            this.txtb_genre.Size = new System.Drawing.Size(421, 34);
            this.txtb_genre.TabIndex = 5;
            // 
            // txtb_publisher
            // 
            this.txtb_publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_publisher.Location = new System.Drawing.Point(532, 247);
            this.txtb_publisher.Name = "txtb_publisher";
            this.txtb_publisher.Size = new System.Drawing.Size(421, 34);
            this.txtb_publisher.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mô tả:";
            // 
            // txtb_description
            // 
            this.txtb_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_description.Location = new System.Drawing.Point(532, 475);
            this.txtb_description.Multiline = true;
            this.txtb_description.Name = "txtb_description";
            this.txtb_description.Size = new System.Drawing.Size(421, 123);
            this.txtb_description.TabIndex = 10;
            // 
            // dtp_publicationDate
            // 
            this.dtp_publicationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_publicationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_publicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_publicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_publicationDate.Location = new System.Drawing.Point(532, 302);
            this.dtp_publicationDate.Name = "dtp_publicationDate";
            this.dtp_publicationDate.Size = new System.Drawing.Size(227, 34);
            this.dtp_publicationDate.TabIndex = 7;
            // 
            // nud_Copies
            // 
            this.nud_Copies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_Copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Copies.Location = new System.Drawing.Point(532, 419);
            this.nud_Copies.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Copies.Name = "nud_Copies";
            this.nud_Copies.Size = new System.Drawing.Size(120, 34);
            this.nud_Copies.TabIndex = 9;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.Location = new System.Drawing.Point(12, 533);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(106, 48);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Quay về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Location = new System.Drawing.Point(147, 533);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 48);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // nud_pages
            // 
            this.nud_pages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_pages.CausesValidation = false;
            this.nud_pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_pages.Location = new System.Drawing.Point(532, 362);
            this.nud_pages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_pages.Name = "nud_pages";
            this.nud_pages.Size = new System.Drawing.Size(120, 34);
            this.nud_pages.TabIndex = 8;
            // 
            // pb_book
            // 
            this.pb_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_book.Image = global::QuanLyThuVien_v2._0.Properties.Resources.sach;
            this.pb_book.Location = new System.Drawing.Point(14, 53);
            this.pb_book.Name = "pb_book";
            this.pb_book.Size = new System.Drawing.Size(243, 358);
            this.pb_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_book.TabIndex = 0;
            this.pb_book.TabStop = false;
            // 
            // F_AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 610);
            this.Controls.Add(this.nud_pages);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.nud_Copies);
            this.Controls.Add(this.dtp_publicationDate);
            this.Controls.Add(this.txtb_description);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtb_publisher);
            this.Controls.Add(this.txtb_genre);
            this.Controls.Add(this.txtb_author);
            this.Controls.Add(this.txtb_bookName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_isbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_choosePicture);
            this.Controls.Add(this.pb_book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_AddBook";
            this.Text = "F_Add";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_book;
        private System.Windows.Forms.Button btn_choosePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtb_bookName;
        private System.Windows.Forms.TextBox txtb_author;
        private System.Windows.Forms.TextBox txtb_genre;
        private System.Windows.Forms.TextBox txtb_publisher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtb_description;
        private System.Windows.Forms.DateTimePicker dtp_publicationDate;
        private System.Windows.Forms.NumericUpDown nud_Copies;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.NumericUpDown nud_pages;
    }
}