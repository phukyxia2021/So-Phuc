using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhToanSoPhuc_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            SoPhuc sophuc1 = new SoPhuc();
            SoPhuc sophuc2 = new SoPhuc();
            SoPhuc kq = new SoPhuc();

            //Lay du lieu va ep kieu
            sophuc1.r = double.Parse(txtPhanThucSP1.Text);
            sophuc1.i = double.Parse(txtPhanAoSP1.Text);
            sophuc2.r = double.Parse(txtPhanThucSP2.Text);
            sophuc2.i = double.Parse(txtPhanAoSP2.Text);

            if (radCong.Checked == true)
            {
                kq = sophuc1 + sophuc2;
                txtPhanThucKQ.Text = kq.r.ToString();
                txtPhanAoKQ.Text = kq.i.ToString();

            }

            if (radTru.Checked == true)
            {
                kq = sophuc1 - sophuc2;
                txtPhanThucKQ.Text = kq.r.ToString();
                txtPhanAoKQ.Text = kq.i.ToString();

            }

            if (radNhan.Checked == true)
            {
                kq = sophuc1 * sophuc2;
                txtPhanThucKQ.Text = kq.r.ToString();
                txtPhanAoKQ.Text = kq.i.ToString();

            }

            if (radChia.Checked == true)
            {
                kq = sophuc1 / sophuc2;
                txtPhanThucKQ.Text = kq.r.ToString();
                txtPhanAoKQ.Text = kq.i.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //txtPhanThucSP1.Clear();
            //txtPhanAoSP1.Clear();
            //txtPhanThucSP2.Clear();
            //txtPhanAoSP2.Clear();
            //txtPhanThucKQ.Clear();
            //txtPhanAoKQ.Clear();
            txtPhanThucSP1.Text="";
            txtPhanAoSP1.Text="";
            txtPhanThucSP2.Text = "";
            txtPhanAoSP2.Text = "";
            txtPhanThucKQ.Text = "";
            txtPhanAoKQ.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //Nếu bấm Yes-->đóng chương trình
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
