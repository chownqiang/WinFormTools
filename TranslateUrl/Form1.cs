using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TranslateUrl
{
    public partial class mainFrom : Form
    {
        public mainFrom()
        {
            InitializeComponent();

            cmbEncoding.DataSource = Encoding.GetEncodings();
            cmbEncoding.DisplayMember = "Name";
            cmbEncoding.ValueMember = "Name";
            cmbEncoding.SelectedValue = "utf-8";
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (cmbEncoding.SelectedValue == null)
            {
                MessageBox.Show("please select a Encoding type.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtOutput.Text = HttpUtility.UrlEncode(txtInput.Text, System.Text.Encoding.GetEncoding(cmbEncoding.SelectedValue.ToString()));

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (cmbEncoding.SelectedValue == null)
            {
                MessageBox.Show("please select a Encoding type.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtOutput.Text = HttpUtility.UrlDecode(txtInput.Text, System.Text.Encoding.GetEncoding(cmbEncoding.SelectedValue.ToString()));
        }
    }
}
