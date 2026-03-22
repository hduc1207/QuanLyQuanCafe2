using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class QLyban : Form
    {
        public QLyban()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<TableFoodDTO> tableList = TableFoodBUS.Instance.GetListTable();

            foreach (TableFoodDTO item in tableList)
            {
                Button btn = new Button() { Width = 90, Height = 90 };
                btn.Text = item.TableName + Environment.NewLine + item.TableStatus;

                btn.Tag = item;

                switch (item.TableStatus)
                {
                    case "Trống":
                        btn.BackColor = Color.Gray;
                        break;
                    default:
                        btn.BackColor = Color.DarkOrange;
                        break;
                }

                btn.Click += btn_Click;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            TableFoodDTO table = (sender as Button).Tag as TableFoodDTO;
            QLyorder f = new QLyorder(table.TableID);
            f.FormClosed += new FormClosedEventHandler((s, args) => LoadTable());
            frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.OpenChildForm(f);
            }
            else
            {
                f.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void btnxoaban_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {

        }
    }
}
