using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_v2._0
{
    public partial class F_Book : Form
    {
        FlowLayoutPanel flp_book = new FlowLayoutPanel();
        public List<bookItem> booklist = new List<bookItem>();
        static public string choosingBook;
        private Form activateForm;
        public F_Book()
        {
            InitializeComponent();
            txtb_search.Text = "(Tìm kiếm dựa trên mã sách, tên sách, tác giả và nhà phát hành)";
            txtb_search.ForeColor = SystemColors.ScrollBar;

            panelDesktop.Controls.Add(flp_book);
            flp_book.Dock = DockStyle.Fill;
            flp_book.AutoScroll = true;
        }

        public void loadBookList(SqlCommand cmd)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            for (int i = 0; i < dataset.Tables[0].Rows.Count; ++i)
            {
                bookItem bookItem = new bookItem();
                MemoryStream ms = new MemoryStream((Byte[])dataset.Tables[0].Rows[i]["bookImage"]);
                bookItem.bookImage = Image.FromStream(ms);
               
                bookItem.isbn = dataset.Tables[0].Rows[i]["isbn"].ToString();
                bookItem.name = dataset.Tables[0].Rows[i]["name"].ToString();
                bookItem.author = dataset.Tables[0].Rows[i]["author"].ToString();
                bookItem.genre = dataset.Tables[0].Rows[i]["genre"].ToString();
                bookItem.publisher = dataset.Tables[0].Rows[i]["publisher"].ToString();
                bookItem.publicationDate = DateTime.Parse(dataset.Tables[0].Rows[i]["publicationDate"].ToString());
                bookItem.importDate = DateTime.Parse(dataset.Tables[0].Rows[i]["importDate"].ToString());
                bookItem.pages = int.Parse(dataset.Tables[0].Rows[i]["pages"].ToString());
                bookItem.copies = int.Parse(dataset.Tables[0].Rows[i]["copies"].ToString());
                bookItem.description = dataset.Tables[0].Rows[i]["description"].ToString();

                flp_book.Controls.Add(bookItem);
                booklist.Add(bookItem); 
            }
            dataProvider.conn.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_AddBook(), sender);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataProvider.conn = new SqlConnection(dataProvider.connStr);
                if (dataProvider.conn.State == ConnectionState.Closed)
                {
                    dataProvider.conn.Open();
                }
                string sqlStr = @"exec delBook @isbn";
                SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);
                foreach (bookItem book in booklist)
                {
                    if (book.choosing == true)
                    {
                        cmd.Parameters.Add("@isbn", book.isbn);
                        cmd.ExecuteNonQuery();
                    }
                }
                flp_book.Controls.Clear();
                loadBookList(new SqlCommand(@"select * from book", dataProvider.conn));
                dataProvider.conn.Close();
            }
        }

        private void txtb_search_Click(object sender, EventArgs e)
        {
            if(txtb_search.Text == "(Tìm kiếm dựa trên mã sách, tên sách, tác giả và nhà phát hành)")
            {
                txtb_search.Text = "";
                txtb_search.ForeColor = SystemColors.ControlText;
                txtb_search.Focus();
            }
        }

        private void btn_clearSearch_Click(object sender, EventArgs e)
        {
            txtb_search.Text = "";
        }

        private void txtb_search_TextChanged(object sender, EventArgs e)
        {
            dataProvider.conn = new SqlConnection(dataProvider.connStr);
            if (dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }
            flp_book.Controls.Clear();
            
            if(txtb_search.Text == "(Tìm kiếm dựa trên mã sách, tên sách, tác giả và nhà phát hành)")
            {
                string sqlStr = @"select * from book";
                SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);
                loadBookList(cmd);
            }
            else
            {
                string sqlStr = @"exec searchBook @isbn, @name, @author, @publisher";
                SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);
                cmd.Parameters.AddWithValue("@isbn", txtb_search.Text);
                cmd.Parameters.AddWithValue("@name", txtb_search.Text);
                cmd.Parameters.AddWithValue("@author", txtb_search.Text);
                cmd.Parameters.AddWithValue("@publisher", txtb_search.Text);
                loadBookList(cmd);
            }
            dataProvider.conn.Close();
        }

        static public SqlCommand filter;
        private void btn_find_Click(object sender, EventArgs e)
        {
            F_bookFilter Fsearch = new F_bookFilter();      
            if(Fsearch.ShowDialog() == DialogResult.OK)
            {
                if (dataProvider.conn.State == ConnectionState.Closed)
                {
                    dataProvider.conn.Open();
                }
                SqlCommand cmd = filter;
                flp_book.Controls.Clear();
                loadBookList(cmd);
            }
            dataProvider.conn.Close();
        }
    }
}
