using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class qldouongcfe : Form
    {
        BindingSource foodList = new BindingSource();

        public qldouongcfe()
        {
            InitializeComponent();

            // Tự động gài sự kiện cho các nút để không phải vào Design click
            this.Load += Qldouongcfe_Load;
            btnthem.Click += Btnthem_Click;
            btnsua.Click += Btnsua_Click;
            btnxoa.Click += Btnxoa_Click;
        }

        private void Qldouongcfe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = foodList;
            LoadFoodList();
            AddFoodBinding();

            // Khóa ô Mã đồ uống không cho nhập tay (vì Database tự động tăng)
            textBox1.ReadOnly = true;
        }

        void LoadFoodList()
        {
            foodList.DataSource = BUS.FoodBUS.Instance.GetListFood();

            // Đổi tên cột hiển thị cho chuyên nghiệp
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["FoodId"].HeaderText = "Mã Món";
                dataGridView1.Columns["FoodName"].HeaderText = "Tên Món";
                dataGridView1.Columns["CategoryId"].HeaderText = "Mã Danh Mục";
                dataGridView1.Columns["Price"].HeaderText = "Giá Tiền";
                dataGridView1.Columns["Size"].HeaderText = "Kích Cỡ";
            }
        }

        // Hàm ma thuật: Click vào dòng nào dưới bảng, chữ tự nảy lên TextBox trên cùng
        void AddFoodBinding()
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            cbbsize.DataBindings.Clear();

            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FoodId", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FoodName", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "CategoryId", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Price", true, DataSourceUpdateMode.Never));
            cbbsize.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Size", true, DataSourceUpdateMode.Never));
        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string size = cbbsize.Text;

            int categoryID;
            int.TryParse(textBox3.Text, out categoryID);

            decimal price;
            decimal.TryParse(textBox4.Text, out price);

            if (string.IsNullOrEmpty(name) || price <= 0 || categoryID <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên, Mã danh mục và Giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BUS.FoodBUS.Instance.InsertFood(name, categoryID, price, size))
            {
                MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadFoodList();
            }
        }

        private void Btnsua_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn một món trên bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBox2.Text;
            string size = cbbsize.Text;

            int categoryID;
            int.TryParse(textBox3.Text, out categoryID);

            decimal price;
            decimal.TryParse(textBox4.Text, out price);

            if (BUS.FoodBUS.Instance.UpdateFood(id, name, categoryID, price, size))
            {
                MessageBox.Show("Sửa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFoodList();
            }
        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn một món trên bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lá chắn thép: Chặn xóa món đã từng bán
            if (BUS.FoodBUS.Instance.IsFoodUsed(id))
            {
                MessageBox.Show("Món này ĐÃ TỪNG ĐƯỢC BÁN nên không thể xóa (Sẽ làm hỏng doanh thu cũ).\nGợi ý: Bạn có thể SỬA TÊN món này thành món khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS.FoodBUS.Instance.DeleteFood(id))
                {
                    MessageBox.Show("Xóa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFoodList();
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void cbbsize_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void btnthongke_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}

