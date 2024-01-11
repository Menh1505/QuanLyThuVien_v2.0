using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_v2._0
{
    public partial class F_main : Form
    {
        private Form activateForm;
        bool swapDisplay = false; //0: book, 1: borrower
        public F_main()
        {
            InitializeComponent();
            this.btn_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(115)))));
            OpenChildForm(new F_Book(), new object());
        }

        private void OpenChildForm(Form chilForm, Object btnSender)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(chilForm);
            this.panelDesktop.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            activateForm.Close();
        }
        private void btn_Book_Click(object sender, EventArgs e)
        {
            if(swapDisplay == true)
            {
                swapDisplay = false;
                this.btn_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(115)))));
                this.btn_borrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            }
            OpenChildForm(new F_Book(), sender);
        }

        private void btn_borrower_Click(object sender, EventArgs e)
        {
            if( swapDisplay == false)
            {
                swapDisplay = true;
                this.btn_borrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(115)))));
                this.btn_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            }
            OpenChildForm(new F_Borrower(), sender);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn thoát", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
            txtb_Intro.Text = @"- Kính gửi thầy Nguyễn Văn Huy

- Phần báo cáo bài tập lớn cuối môn Kỹ Thuật Lập Trình 

- Nhóm: BT77

- Thành viên: Đinh Thiên Mệnh, 
                Nguyễn Quốc Hùng,
                Đỗ Vĩnh Phú 
- Lớp: CN23CLC 

- Nội dung: Viết phần mềm quản lý thư viện";
        }

        private void txtb_Intro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
