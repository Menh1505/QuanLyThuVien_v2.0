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
    public partial class F_bookFilter : Form
    {
        public F_bookFilter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SqlCommand command()
        {
            string sqlStr = @"exec filterBook @importDateStart, @importDateEnd, @pubDateStart, @pubDateEnd, @copiesStart, @copiesEnd";
            SqlCommand cmd = new SqlCommand(sqlStr, dataProvider.conn);
            cmd.Parameters.AddWithValue("@importDateStart", dtp_impStart.Value.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@importDateEnd", dtp_impEnd.Value.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@pubDateStart", dtp_pubStart.Value.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@pubDateEnd", dtp_pubEnd.Value.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@copiesStart", nud_copStart.Value);
            cmd.Parameters.AddWithValue("@copiesEnd", nud_copEnd.Value);

            return cmd;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            F_Book.filter = command();
            this.DialogResult = DialogResult.OK;
        }
    }
}
