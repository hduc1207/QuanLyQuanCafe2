using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class QLyorder : Form
    {
        private int currentTableId;
        public QLyorder(int tableId)
        {
            InitializeComponent();
            this.currentTableId = tableId;
        }
        void LoadFood()
        {
            // Lấy toàn bộ danh sách món
            List<FoodDTO> listFood = BUS.FoodBUS.Instance.GetListFood();
            List<FoodDTO> listDrink = listFood.Where(x => !string.IsNullOrEmpty(x.Size)).ToList();
            cbbtenchinh.DataSource = listDrink;
            cbbtenchinh.DisplayMember = "FoodName";
            cbbtenchinh.ValueMember = "FoodId";
            List<FoodDTO> listTopping = listFood.Where(x => string.IsNullOrEmpty(x.Size)).ToList();
            listTopping.Insert(0, new FoodDTO() { FoodId = 0, FoodName = "--- Không chọn ---" });
            cbbmonphu.DataSource = listTopping;
            cbbmonphu.DisplayMember = "FoodName";
            cbbmonphu.ValueMember = "FoodId";
        }

        private void QLyorder_Load_1(object sender, EventArgs e)
        {
            LoadFood();
            ShowBill(currentTableId);
        }
        void ShowBill(int idTable)
        {
            System.Data.DataTable data = DAO.BillInfoDAO.Instance.GetListBillInfoByTable(idTable);
            tblFood.DataSource = data;
        }

        private void btndatmon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idTable = currentTableId;
            int count = Convert.ToInt32(txtsoluong.Text);
            int idBill = BUS.BillBUS.Instance.GetUncheckBillByTableID(idTable);
            if (idBill == -1)
            {
                BUS.BillBUS.Instance.InsertBill(idTable);
                idBill = BUS.BillBUS.Instance.GetMaxIDBill();
            }
            FoodDTO mainFood = cbbtenchinh.SelectedItem as FoodDTO;
            int currentBillInfoId = BUS.BillInfoBUS.Instance.AddFoodToBill(idBill, mainFood.FoodId, count, mainFood.Size);
            FoodDTO topping = cbbmonphu.SelectedItem as FoodDTO;
            if (topping != null && topping.FoodId != 0)
            {
                BUS.BillInfoBUS.Instance.AddFoodToBill(idBill, topping.FoodId, count, topping.Size, currentBillInfoId);
            }
            MessageBox.Show("Đã thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowBill(currentTableId);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            thanhtoancfe f = new thanhtoancfe(currentTableId);
            f.ShowDialog();
            ShowBill(currentTableId);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tblFood.CurrentRow != null)
            {
                int idBillInfo = Convert.ToInt32(tblFood.CurrentRow.Cells["BillInfoId"].Value);

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa món này khỏi hóa đơn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DAO.BillInfoDAO.Instance.DeleteBillInfo(idBillInfo);
                    ShowBill(currentTableId);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một món trên bảng trước khi xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblFood.CurrentRow != null)
            {
                if (string.IsNullOrEmpty(txtsoluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng mới vào ô Số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idBillInfo = Convert.ToInt32(tblFood.CurrentRow.Cells["BillInfoId"].Value);
                int newQuantity = Convert.ToInt32(txtsoluong.Text);
                // Cập nhật xuống Database
                DAO.BillInfoDAO.Instance.UpdateBillInfoQuantity(idBillInfo, newQuantity);

                MessageBox.Show("Cập nhật số lượng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowBill(currentTableId);
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một món trên bảng trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbmonphu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();

            if (mainForm != null)
            {
                QLyban fBan = new QLyban();
                mainForm.OpenChildForm(fBan);
            }
            this.Close();
        }
    }
}