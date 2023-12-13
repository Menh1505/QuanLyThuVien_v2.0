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
    public partial class F_AddBook : Form
    {
        public F_AddBook()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_choosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pb_book.Image = new Bitmap(ofd.FileName);
            }
        }

        public void insertBook()
        {
            dataProvider.conn = new SqlConnection(dataProvider.connStr);
            if (dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }

            string query = @"exec addBook @image, @isbn, @name, @author, @genre, @publisher, @publicationDate, @importDate, @pages, @copies, @description";
            SqlCommand cmd = new SqlCommand(query, dataProvider.conn);

            cmd.Parameters.AddWithValue("@image", getPhoto());
            cmd.Parameters.AddWithValue("@isbn", txtb_isbn.Text);
            cmd.Parameters.AddWithValue("@name", txtb_bookName.Text);
            cmd.Parameters.AddWithValue("@author", txtb_author.Text);
            cmd.Parameters.AddWithValue("@genre", txtb_genre.Text);
            cmd.Parameters.AddWithValue("@publisher", txtb_publisher.Text);
            cmd.Parameters.AddWithValue("@publicationDate", dtp_publicationDate.Value.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@importDate", DateTime.Now.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@pages", nud_pages.Value);
            cmd.Parameters.AddWithValue("@copies", nud_Copies.Value);
            cmd.Parameters.AddWithValue("@description", txtb_description.Text);

            try
            {
                int queryRes = cmd.ExecuteNonQuery();
                if (queryRes > 0) MessageBox.Show("Thêm thành công..");
            }
            catch
            {
                MessageBox.Show("Mã sách bị trùng", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataProvider.conn.Close();
        }

        private byte[] getPhoto()
        {
            MemoryStream memoryStream = new MemoryStream();
            pb_book.Image.Save(memoryStream, pb_book.Image.RawFormat);

            return memoryStream.GetBuffer();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            insertBook();
        }
    }
}
