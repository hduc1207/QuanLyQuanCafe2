using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class thanhtoancfe : Form
    {
        private int currentTableId;
        private int currentBillId;
        private decimal totalAmount = 0;
        private decimal finalAmount = 0;
        public thanhtoancfe(int tableId)
        {
            InitializeComponent();
            this.currentTableId = tableId;
        }
        private void thanhtoancfe_Load(object sender, EventArgs e)
        {
            LoadBill();
            btnquaylai.Click += Btnquaylai_Click;
        }

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadBill()
        {
            currentBillId = BillBUS.Instance.GetUncheckBillByTableID(currentTableId);

            if (currentBillId != -1)
            {
                DataTable data = DAO.BillInfoDAO.Instance.GetListBillInfoByTable(currentTableId);
                tblBill.DataSource = data;
                totalAmount = 0;
                foreach (DataRow row in data.Rows)
                {
                    totalAmount += Convert.ToDecimal(row["TotalPrice"]);
                }

                finalAmount = totalAmount;
                txtTIenCanThanhToan.Text = finalAmount.ToString("N0");
                txtGiamGia.Text = "0";
            }
        }
        private void btnapdung_Click(object sender, EventArgs e)
        {
            int discount = 0;
            if (int.TryParse(txtGiamGia.Text, out discount))
            {
                if (discount >= 0 && discount <= 100)
                {
                    finalAmount = totalAmount - (totalAmount * discount / 100);
                    txtTIenCanThanhToan.Text = finalAmount.ToString("N0");
                    CalculateChange();
                }
                else
                {
                    MessageBox.Show("Giảm giá (%) chỉ được nhập từ 0 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }
        void CalculateChange()
        {
            decimal tienKhachTra = 0;
            if (decimal.TryParse(txtTienKhachTra.Text, out tienKhachTra))
            {
                decimal tienThua = tienKhachTra - finalAmount;
                if (tienThua >= 0)
                {
                    txtTienThua.Text = tienThua.ToString("N0");
                }
                else
                {
                    txtTienThua.Text = "Chưa đủ tiền";
                }
            }
            else
            {
                txtTienThua.Text = "0";
            }
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (currentBillId == -1)
            {
                MessageBox.Show("Bàn này chưa có món nào để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int discount = 0;
            int.TryParse(txtGiamGia.Text, out discount);

            if (MessageBox.Show($"Bạn có chắc chắn muốn thanh toán hóa đơn này?\nTổng tiền thu: {finalAmount.ToString("N0")} VNĐ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                BillBUS.Instance.CheckOut(currentBillId, discount);

                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void txttongtien_TextChanged(object sender, EventArgs e) { }

        private void btnquaylai_Click_1(object sender, EventArgs e)
        {

        }
    }
}