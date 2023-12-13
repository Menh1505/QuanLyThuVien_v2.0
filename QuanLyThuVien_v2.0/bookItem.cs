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
    public partial class bookItem : UserControl
    {
        public bool choosing = false;
        private Image _bookImage;
        private string _isbn;
        private string _name;
        private string _author;
        private string _genre;
        private int _copies;
        private string _publisher;
        private DateTime _publicationDate;
        private DateTime _importDate;
        private int _pages;
        private string _description;

        [Category("Custom Props")]
        public string isbn { get { return _isbn; } set { _isbn = value; } }
        [Category("Custom Props")]
        public string name { get => _name; set { lbl_name.Text = value; _name = value; } }
        [Category("Custom Props")]
        public string author { get => _author; set { lbl_author.Text = value; _author = value; } }
        [Category("Custom Props")]
        public string genre { get => _genre; set => _genre = value; }
        [Category("Custom Props")]
        public int copies { get => _copies; set { lbl_copies.Text = value.ToString(); _copies = value; } }
        [Category("Custom Props")]
        public string publisher { get => _publisher; set { lbl_publisher.Text = value.ToString(); _publisher = value; } }
        [Category("Custom Props")]
        public DateTime publicationDate { get => _publicationDate; set => _publicationDate = DateTime.Parse(value.ToString()); }
        [Category("Custom Props")]
        public DateTime importDate { get => _importDate; set => _importDate = DateTime.Parse(value.ToString()); }
        [Category("Custom Props")]
        public int pages { get => _pages; set => _pages = value; }
        [Category("Custom Props")]
        public string description { get => _description; set => _description = value; }
        [Category("Custom Props")]
        public Image bookImage { get => _bookImage; set { pb_book.Image = value; _bookImage = value; } }

        public bookItem()
        {
            InitializeComponent();
        }

        private void bookItem_Load(object sender, EventArgs e)
        {

        }

        private void bookItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            F_BookInfo bookInfo = new F_BookInfo();
            bookInfo.image = bookImage;
            bookInfo.isbn = isbn;
            bookInfo.name = name;
            bookInfo.author = author;
            bookInfo.genre = genre;
            bookInfo.publisher = publisher;
            bookInfo.publicationDate = publicationDate;
            bookInfo.importDate = importDate;
            bookInfo.pages = pages;
            bookInfo.copies = copies;
            bookInfo.description = description;
            bookInfo.Show();
        }

        private void pb_book_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            F_BookInfo bookInfo = new F_BookInfo();
            bookInfo.image = bookImage;
            bookInfo.isbn = isbn;
            bookInfo.name = name;
            bookInfo.author = author;
            bookInfo.genre = genre;
            bookInfo.publisher = publisher;
            bookInfo.publicationDate = publicationDate;
            bookInfo.importDate = importDate;
            bookInfo.pages = pages;
            bookInfo.copies = copies;
            bookInfo.description = description;
            bookInfo.Show();
        }

        private void bookItem_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.BackColor != SystemColors.ButtonFace)
            {
                this.BackColor = SystemColors.ButtonFace;
                choosing = true;
            }
            else
            {
                this.BackColor = SystemColors.Window;
                choosing = false;
            }
        }

        private void pb_book_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.BackColor != SystemColors.ButtonFace)
            {
                this.BackColor = SystemColors.ButtonFace;
                choosing = true;
            }
            else
            {
                this.BackColor = SystemColors.Window;
                choosing = false;
            }
        }
    }
}
