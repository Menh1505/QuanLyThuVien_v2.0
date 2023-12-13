using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_v2._0
{
    public partial class F_Borrower : Form
    {
        private Form activateForm;
        public F_Borrower()
        {
            InitializeComponent();
            txtb_search.Text = "(Tìm kiếm dựa trên tên, lớp, số điện thoại, gmail và tên sách mượn)";
            txtb_search.ForeColor = SystemColors.ScrollBar;
        }
        
        private void OpenChildForm(Form chilForm, Object btnSender)
        {
            if (activateForm != null)
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
        
        public void loadBorrower(SqlCommand cmd)
        {
            dgv_borrower.DataSource = dataProvider.LoadDatabase(cmd);
            for (int i = 0; i < 6; ++i)
            {
                dgv_borrower.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_AddBorrower(), sender);
        }

        private void btn_clearSearch_Click(object sender, EventArgs e)
        {
            txtb_search.Text = "";
            txtb_search.Focus();
        }

        private void txtb_search_Click(object sender, EventArgs e)
        {
                txtb_search.Text = "";
                txtb_search.ForeColor = SystemColors.ControlText;
                txtb_search.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }
            
            try
            {
                int currentRow = dgv_borrower.CurrentRow.Index;
                string sqlStr = @"exec giveBackBook @name, @bookName";
                SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);
                cmd.Parameters.AddWithValue("@name", dgv_borrower.Rows[currentRow].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@bookName", dgv_borrower.Rows[currentRow].Cells[2].Value.ToString());

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoá thành công");
                }
            }
            catch 
            {
                MessageBox.Show("Xoá không thành công");
            }

            dataProvider.conn.Close();
        }

        private void txtb_search_TextChanged(object sender, EventArgs e)
        {
            dataProvider.conn = new SqlConnection(dataProvider.connStr);
            if (dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }
            dgv_borrower.Controls.Clear();
            if (txtb_search.Text == "(Tìm kiếm dựa trên tên, lớp, số điện thoại, gmail và tên sách mượn)")
            {
                loadBorrower(new SqlCommand(@"exec selectAllBorrower", dataProvider.conn));
            }
            else
            {
                string sqlStr = @"exec searchBorrower @name, @class, @phone, @gmail, @bookName";
                SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);
                cmd.Parameters.AddWithValue("@name", txtb_search.Text);
                cmd.Parameters.AddWithValue("@class", txtb_search.Text);
                cmd.Parameters.AddWithValue("@phone", txtb_search.Text);
                cmd.Parameters.AddWithValue("@gmail", txtb_search.Text);
                cmd.Parameters.AddWithValue("@bookName", txtb_search.Text);

                loadBorrower(cmd);
            }
        }

        public static DateTime start, end;
        public static bool outDate;
        private void btn_find_Click(object sender, EventArgs e)
        {
            F_filterBorrower f_FilterBorrower = new F_filterBorrower();
            f_FilterBorrower.ShowDialog();
            if(outDate == true)
            {
                foreach (DataGridViewRow dgvRow in dgv_borrower.Rows)
                {
                    DateTime dt = DateTime.Parse(dgvRow.Cells[5].Value.ToString());
                    if (DateTime.Compare(dt, DateTime.Now) < 0)
                    {
                        dgv_borrower.Rows[dgvRow.Index].Selected = true;
                    }
                }
                foreach (DataGridViewRow item in this.dgv_borrower.SelectedRows)
                {
                    dgv_borrower.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                foreach (DataGridViewRow dgvRow in dgv_borrower.Rows )
                {
                    DateTime dtSt = DateTime.Parse(dgvRow.Cells[4].Value.ToString());
                    DateTime dtEn = DateTime.Parse(dgvRow.Cells[5].Value.ToString());
                    if (DateTime.Compare(start, dtSt) < 0 || DateTime.Compare(end, dtEn) > 0)
                    {
                        dgv_borrower.Rows[dgvRow.Index].Selected = true;
                    }
                }
                foreach (DataGridViewRow item in this.dgv_borrower.SelectedRows)
                {
                    dgv_borrower.Rows.RemoveAt(item.Index);
                }
            }
        }
    }
}
