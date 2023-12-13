namespace QuanLyThuVien_v2._0
{
    partial class F_AddBorrower
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_chooseBook = new System.Windows.Forms.ComboBox();
            this.txtb_Name = new System.Windows.Forms.TextBox();
            this.txtb_class = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_phone = new System.Windows.Forms.TextBox();
            this.txtb_gmail = new System.Windows.Forms.TextBox();
            this.dtp_borrow = new System.Windows.Forms.DateTimePicker();
            this.dtp_giveBack = new System.Windows.Forms.DateTimePicker();
            this.btn_AddBorrower = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.nud_qty = new System.Windows.Forms.NumericUpDown();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.btn_removeBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lv_book = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBorrowDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGiveBackDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.txtb_studentCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sách mượn:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày trả:";
            // 
            // cb_chooseBook
            // 
            this.cb_chooseBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_chooseBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_chooseBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_chooseBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chooseBook.FormattingEnabled = true;
            this.cb_chooseBook.Location = new System.Drawing.Point(249, 378);
            this.cb_chooseBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_chooseBook.Name = "cb_chooseBook";
            this.cb_chooseBook.Size = new System.Drawing.Size(279, 30);
            this.cb_chooseBook.TabIndex = 5;
            this.cb_chooseBook.SelectedIndexChanged += new System.EventHandler(this.cb_chooseBook_SelectedIndexChanged);
            // 
            // txtb_Name
            // 
            this.txtb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Name.Location = new System.Drawing.Point(173, 48);
            this.txtb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_Name.Name = "txtb_Name";
            this.txtb_Name.Size = new System.Drawing.Size(532, 28);
            this.txtb_Name.TabIndex = 0;
            // 
            // txtb_class
            // 
            this.txtb_class.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_class.Location = new System.Drawing.Point(173, 91);
            this.txtb_class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_class.Name = "txtb_class";
            this.txtb_class.Size = new System.Drawing.Size(532, 28);
            this.txtb_class.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gmail:";
            // 
            // txtb_phone
            // 
            this.txtb_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_phone.Location = new System.Drawing.Point(173, 132);
            this.txtb_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_phone.Name = "txtb_phone";
            this.txtb_phone.Size = new System.Drawing.Size(532, 28);
            this.txtb_phone.TabIndex = 2;
            // 
            // txtb_gmail
            // 
            this.txtb_gmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_gmail.Location = new System.Drawing.Point(173, 177);
            this.txtb_gmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_gmail.Name = "txtb_gmail";
            this.txtb_gmail.Size = new System.Drawing.Size(532, 28);
            this.txtb_gmail.TabIndex = 3;
            // 
            // dtp_borrow
            // 
            this.dtp_borrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_borrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_borrow.Location = new System.Drawing.Point(298, 418);
            this.dtp_borrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_borrow.Name = "dtp_borrow";
            this.dtp_borrow.Size = new System.Drawing.Size(138, 28);
            this.dtp_borrow.TabIndex = 7;
            // 
            // dtp_giveBack
            // 
            this.dtp_giveBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_giveBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_giveBack.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_giveBack.Location = new System.Drawing.Point(567, 418);
            this.dtp_giveBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_giveBack.Name = "dtp_giveBack";
            this.dtp_giveBack.Size = new System.Drawing.Size(138, 28);
            this.dtp_giveBack.TabIndex = 8;
            // 
            // btn_AddBorrower
            // 
            this.btn_AddBorrower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddBorrower.Location = new System.Drawing.Point(476, 459);
            this.btn_AddBorrower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddBorrower.Name = "btn_AddBorrower";
            this.btn_AddBorrower.Size = new System.Drawing.Size(104, 27);
            this.btn_AddBorrower.TabIndex = 11;
            this.btn_AddBorrower.Text = "Thêm người mượn";
            this.btn_AddBorrower.UseVisualStyleBackColor = true;
            this.btn_AddBorrower.Click += new System.EventHandler(this.btn_AddBorrower_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.Location = new System.Drawing.Point(602, 459);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 27);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Quay về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // nud_qty
            // 
            this.nud_qty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_qty.Location = new System.Drawing.Point(640, 380);
            this.nud_qty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_qty.Name = "nud_qty";
            this.nud_qty.Size = new System.Drawing.Size(64, 28);
            this.nud_qty.TabIndex = 6;
            // 
            // btn_addBook
            // 
            this.btn_addBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addBook.Location = new System.Drawing.Point(61, 302);
            this.btn_addBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(76, 30);
            this.btn_addBook.TabIndex = 9;
            this.btn_addBook.Text = "Thêm sách";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_removeBook
            // 
            this.btn_removeBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_removeBook.Location = new System.Drawing.Point(61, 341);
            this.btn_removeBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_removeBook.Name = "btn_removeBook";
            this.btn_removeBook.Size = new System.Drawing.Size(76, 30);
            this.btn_removeBook.TabIndex = 10;
            this.btn_removeBook.Text = "Bớt sách";
            this.btn_removeBook.UseVisualStyleBackColor = true;
            this.btn_removeBook.Click += new System.EventHandler(this.btn_removeBook_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(170, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tên sách:";
            // 
            // lv_book
            // 
            this.lv_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnQuantity,
            this.columnBorrowDate,
            this.columnGiveBackDate});
            this.lv_book.FullRowSelect = true;
            this.lv_book.HideSelection = false;
            this.lv_book.Location = new System.Drawing.Point(173, 225);
            this.lv_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv_book.Name = "lv_book";
            this.lv_book.Size = new System.Drawing.Size(532, 147);
            this.lv_book.TabIndex = 4;
            this.lv_book.UseCompatibleStateImageBehavior = false;
            this.lv_book.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Tên sách";
            this.columnName.Width = 300;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "SL";
            this.columnQuantity.Width = 50;
            // 
            // columnBorrowDate
            // 
            this.columnBorrowDate.Text = "Ngày mượn";
            this.columnBorrowDate.Width = 89;
            // 
            // columnGiveBackDate
            // 
            this.columnGiveBackDate.Text = "Ngày trả";
            this.columnGiveBackDate.Width = 89;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã học sinh:";
            // 
            // txtb_studentCode
            // 
            this.txtb_studentCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_studentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_studentCode.Location = new System.Drawing.Point(173, 5);
            this.txtb_studentCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb_studentCode.Name = "txtb_studentCode";
            this.txtb_studentCode.Size = new System.Drawing.Size(532, 28);
            this.txtb_studentCode.TabIndex = 17;
            // 
            // F_AddBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 496);
            this.Controls.Add(this.txtb_studentCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lv_book);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_removeBook);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.nud_qty);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_AddBorrower);
            this.Controls.Add(this.dtp_giveBack);
            this.Controls.Add(this.dtp_borrow);
            this.Controls.Add(this.txtb_gmail);
            this.Controls.Add(this.txtb_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_class);
            this.Controls.Add(this.txtb_Name);
            this.Controls.Add(this.cb_chooseBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_AddBorrower";
            this.Text = "F_AddBorrower";
            this.Load += new System.EventHandler(this.F_AddBorrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_chooseBook;
        private System.Windows.Forms.TextBox txtb_Name;
        private System.Windows.Forms.TextBox txtb_class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtb_phone;
        private System.Windows.Forms.TextBox txtb_gmail;
        private System.Windows.Forms.DateTimePicker dtp_borrow;
        private System.Windows.Forms.DateTimePicker dtp_giveBack;
        private System.Windows.Forms.Button btn_AddBorrower;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.NumericUpDown nud_qty;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_removeBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lv_book;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnBorrowDate;
        private System.Windows.Forms.ColumnHeader columnGiveBackDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtb_studentCode;
    }
}