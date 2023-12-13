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
    public partial class F_BookInfo : Form
    {
        public Image image { get => image; set => pb_book.Image = value; }
        public string isbn { get => isbn; set => txtb_isbn.Text = value; }
        public string name { get => name; set => txtb_name.Text = value; }
        public string author { get => author; set => txtb_author.Text = value; }
        public string genre { get => genre; set => txtb_genre.Text = value; }
        public string publisher { get => publisher; set => txtb_publisher.Text = value; }
        public DateTime publicationDate { get => publicationDate; set => dtp_publicationDate.Value = DateTime.Parse(value.ToString()); }
        public DateTime importDate { get => importDate; set => dtp_importDate.Value = DateTime.Parse(value.ToString()); }
        public int pages { get => pages; set => txtb_pages.Text = value.ToString(); }
        public int copies { get => copies; set => txtb_copies.Text = value.ToString(); }
        public string description { get => description; set => txtb_description.Text = value.ToString(); }

        public F_BookInfo()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_book.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            dataProvider.conn = new SqlConnection(dataProvider.connStr);
            if(dataProvider.conn.State == ConnectionState.Closed)
            {
                dataProvider.conn.Open();
            }

            string sqlStr = @"exec updateBook @image, @isbn, @name, @author, @genre, @publisher, @publicationDate, @importDate, @pages, @copies, @description";

            SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);

            cmd.Parameters.AddWithValue("@image", getPhoto());
            cmd.Parameters.AddWithValue("@isbn", txtb_isbn.Text);
            cmd.Parameters.AddWithValue("@name", txtb_name.Text);
            cmd.Parameters.AddWithValue("@author", txtb_author.Text);
            cmd.Parameters.AddWithValue("@genre", txtb_genre.Text);
            cmd.Parameters.AddWithValue("@publisher", txtb_publisher.Text);
            cmd.Parameters.AddWithValue("@publicationDate", dtp_publicationDate.Value.Date.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@importDate", dtp_importDate.Value.Date.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@pages", int.Parse(txtb_pages.Text));
            cmd.Parameters.AddWithValue("@copies", int.Parse(txtb_copies.Text));
            cmd.Parameters.AddWithValue("@description", txtb_description.Text);

            cmd.ExecuteNonQuery();
            dataProvider.conn.Close();
            MessageBox.Show("Sửa thành công");
        }

        private byte[] getPhoto()
        {
            MemoryStream memoryStream = new MemoryStream();
            pb_book.Image.Save(memoryStream, pb_book.Image.RawFormat);

            return memoryStream.GetBuffer();
        }
    }
}
