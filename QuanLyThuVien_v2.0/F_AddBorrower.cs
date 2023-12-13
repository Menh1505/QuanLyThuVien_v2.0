using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_v2._0
{
    public partial class F_AddBorrower : Form
    {
        
        public F_AddBorrower()
        {
            InitializeComponent();
            fillBookToList();
        }

        private void F_AddBorrower_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fillBookToList()
        {
            if(dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }
            SqlCommand cmd = new SqlCommand(@"select name from book", dataProvider.conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                cb_chooseBook.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
            }
            
            dataProvider.conn.Close();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            if(nud_qty.Value == 0)
            {
                MessageBox.Show("Sách này đã hết");
            }
            else
            {
                ListViewItem listViewItem = new ListViewItem(new[] { cb_chooseBook.Text, nud_qty.Value.ToString(), dtp_borrow.Value.ToString("dd/MM/yyyy"), dtp_giveBack.Value.ToString("dd/MM/yyyy") });
                lv_book.Items.Add(listViewItem);
            }
        }

        private void btn_removeBook_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lv_book.SelectedItems)
            {
                lv_book.Items.Remove(selectedItem);
            }
        }

        private void btn_AddBorrower_Click(object sender, EventArgs e)
        {
            if (dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }
            try
            {
                string sqlStr = @"exec addBorrower @id, @name, @class, @phone, @gmail";
                SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);

                cmd.Parameters.AddWithValue("@id", txtb_studentCode.Text);
                cmd.Parameters.AddWithValue("@name", txtb_Name.Text);
                cmd.Parameters.AddWithValue("@class", txtb_class.Text);
                cmd.Parameters.AddWithValue("@phone", txtb_phone.Text);
                cmd.Parameters.AddWithValue("@gmail", txtb_gmail.Text);

                cmd.ExecuteNonQuery();

                
                foreach (ListViewItem listViewItem in lv_book.Items)
                {
                    sqlStr = @"exec addBorrow @id, @bookName, @qty, @borrowDate, @giveBackDate";
                    cmd = new SqlCommand(sqlStr, dataProvider.conn);
                    cmd.Parameters.AddWithValue("@id", txtb_studentCode.Text);
                    cmd.Parameters.AddWithValue("@bookName", listViewItem.SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@qty", listViewItem.SubItems[1].Text);
                    DateTime borrowDate = DateTime.Parse(listViewItem.SubItems[2].Text);
                    cmd.Parameters.AddWithValue("@borrowDate", borrowDate.ToString("yyyyMMdd"));
                    DateTime giveBackDate = DateTime.Parse(listViewItem.SubItems[3].Text);
                    cmd.Parameters.AddWithValue("@giveBackDate", giveBackDate.ToString("yyyyMMdd"));

                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                foreach (ListViewItem listViewItem in lv_book.Items)
                {
                    string sqlStr = @"exec addBorrow @id, @bookName, @qty, @borrowDate, @giveBackDate";
                    SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);
                    cmd.Parameters.AddWithValue("@id", txtb_studentCode.Text);
                    cmd.Parameters.AddWithValue("@bookName", listViewItem.SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@qty", listViewItem.SubItems[1].Text);
                    DateTime borrowDate = DateTime.Parse(listViewItem.SubItems[2].Text);
                    cmd.Parameters.AddWithValue("@borrowDate", borrowDate.ToString("yyyyMMdd"));
                    DateTime giveBackDate = DateTime.Parse(listViewItem.SubItems[3].Text);
                    cmd.Parameters.AddWithValue("@giveBackDate", giveBackDate.ToString("yyyyMMdd"));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                MessageBox.Show("Thêm thành công");
                dataProvider.conn.Close();
            }
        }

        private void cb_chooseBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }
            string sqlStr = @"select copies from book where name = N'" + cb_chooseBook.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(sqlStr, dataProvider.conn));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            nud_qty.Maximum = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            dataProvider.conn.Close();
        }
    }
}
