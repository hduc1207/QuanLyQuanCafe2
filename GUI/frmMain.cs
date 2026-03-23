using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.GUI
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();
        }
        public void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnContent.Controls.Add(childForm);
            pnContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            OpenChildForm(new QLyban());
            btnban.PerformClick();
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLyban());
        }

        private void btndouong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new qldouongcfe());
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new thongkecfe());
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
