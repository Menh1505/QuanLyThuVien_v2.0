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
    public partial class F_filterBorrower : Form
    {
        public F_filterBorrower()
        {
            InitializeComponent();
        }

        private void checkBox_outDate_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_outDate.Checked == true)
            {
                dtp_borrStart.Enabled = false;
                dtp_borrEnd.Enabled = false;
            }
            else
            {
                dtp_borrStart.Enabled=true;
                dtp_borrEnd.Enabled = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            if(checkBox_outDate.Checked == true)
            {
                F_Borrower.outDate = true;
            }
            else
            {
                F_Borrower.start = dtp_borrStart.Value;
                F_Borrower.end = dtp_borrEnd.Value;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
