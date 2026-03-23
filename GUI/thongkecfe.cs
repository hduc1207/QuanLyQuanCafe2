using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class thongkecfe : Form
    {
        public thongkecfe()
        {
            InitializeComponent();
            SetDefaultDate();
            datengayketthuc.ValueChanged += Datengayketthuc_ValueChanged;
            LoadDoanhThu();
        }

        void SetDefaultDate()
        {
            DateTime today = DateTime.Now;
            datengaybandau.Value = new DateTime(today.Year, today.Month, 1);
            datengayketthuc.Value = datengaybandau.Value.AddMonths(1).AddDays(-1);
        }

        void LoadDoanhThu()
        {
            DataTable data = BillBUS.Instance.GetBillListByDate(datengaybandau.Value, datengayketthuc.Value);
            dataGridView1.DataSource = data;
            decimal total = 0;
            foreach (DataRow row in data.Rows)
            {
                if (data.Columns.Contains("totalPrice") && row["totalPrice"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(row["totalPrice"]);
                }
                else if (data.Columns.Contains("Tổng tiền") && row["Tổng tiền"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(row["Tổng tiền"]);
                }
            }
            txtThuNhap.Text = total.ToString("N0") + " VNĐ";
        }

        private void datengaybandau_ValueChanged(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }
        private void Datengayketthuc_ValueChanged(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtThuNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}