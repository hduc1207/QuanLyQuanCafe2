using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe.GUI
{
    public partial class QuanLyNLvsCT : System.Windows.Forms.Form
    {
        BindingSource ingredientList = new BindingSource();
        BindingSource recipeList = new BindingSource();

        public QuanLyNLvsCT()
        {
            InitializeComponent();
            btnThem.Click += btnThemNL_Click;
            btnSua.Click += btnSuaNL_Click;
            btnXoa.Click += btnXoaNL_Click;
            btnThemCT.Click += btnThemCT_Click;
            btnSuaCT.Click += btnSuaCT_Click;
            btnXoaCT.Click += btnXoaCT_Click;
            dataGridView1.DataSource = ingredientList;
            LoadListIngredient();
            AddIngredientBinding();
            dataGridView2.DataSource = recipeList;
            LoadComboBoxTab2();
            cbbDoUong.SelectedIndexChanged += CbbDoUong_Size_SelectedIndexChanged;
            cbbSize.SelectedIndexChanged += CbbDoUong_Size_SelectedIndexChanged;
            CbbDoUong_Size_SelectedIndexChanged(null, null);
        }
        void LoadListIngredient()
        {
            ingredientList.DataSource = IngredientBUS.Instance.GetListIngredient();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["IngredientId"].HeaderText = "Mã NL";
                dataGridView1.Columns["IngredientName"].HeaderText = "Tên Nguyên Liệu";
                dataGridView1.Columns["Unit"].HeaderText = "Đơn Vị Tính";
                dataGridView1.Columns["Quantity"].HeaderText = "Số Lượng Tồn Kho";
                if (dataGridView1.Columns.Contains("UnitPrice")) dataGridView1.Columns["UnitPrice"].Visible = false;
                if (dataGridView1.Columns.Contains("MinQuantity")) dataGridView1.Columns["MinQuantity"].Visible = false;
            }
        }

        void AddIngredientBinding()
        {
            txtMaNL.DataBindings.Clear();
            txtTenNL.DataBindings.Clear();
            txtDonVi.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();

            txtMaNL.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IngredientId", true, DataSourceUpdateMode.Never));
            txtTenNL.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IngredientName", true, DataSourceUpdateMode.Never));
            txtDonVi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Unit", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Quantity", true, DataSourceUpdateMode.Never));
        }

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            double quantity; double.TryParse(txtSoLuong.Text, out quantity);
            if (IngredientBUS.Instance.InsertIngredient(txtTenNL.Text, txtDonVi.Text, quantity, 0, 10))
            {
                MessageBox.Show("Thêm nguyên liệu thành công!"); LoadListIngredient();
            }
        }

        private void btnSuaNL_Click(object sender, EventArgs e)
        {
            int id; int.TryParse(txtMaNL.Text, out id);
            double quantity; double.TryParse(txtSoLuong.Text, out quantity);
            if (IngredientBUS.Instance.UpdateIngredient(id, txtTenNL.Text, txtDonVi.Text, quantity, 0, 10))
            {
                MessageBox.Show("Cập nhật kho thành công!"); LoadListIngredient();
            }
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            int id; int.TryParse(txtMaNL.Text, out id);
            if (IngredientBUS.Instance.IsIngredientUsed(id))
            {
                MessageBox.Show("Đang nằm trong công thức, KHÔNG THỂ XÓA!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (IngredientBUS.Instance.DeleteIngredient(id))
            {
                MessageBox.Show("Xóa nguyên liệu thành công!"); LoadListIngredient();
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) LoadComboBoxTab2();
        }

        void LoadComboBoxTab2()
        {
            cbbDoUong.DataSource = FoodBUS.Instance.GetListFood();
            cbbDoUong.DisplayMember = "FoodName";
            cbbDoUong.ValueMember = "FoodId";

            cbbNguyenLieu.DataSource = IngredientBUS.Instance.GetListIngredient();
            cbbNguyenLieu.DisplayMember = "IngredientName";
            cbbNguyenLieu.ValueMember = "IngredientId";
        }
        private void CbbDoUong_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idFood;
            if (cbbDoUong.SelectedValue != null && int.TryParse(cbbDoUong.SelectedValue.ToString(), out idFood) && cbbSize.SelectedItem != null)
            {
                string size = cbbSize.Text; // Lấy Size S, M, hoặc L
                recipeList.DataSource = RecipeBUS.Instance.GetRecipeByFood(idFood, size);

                if (dataGridView2.Columns.Contains("RecipeId")) dataGridView2.Columns["RecipeId"].Visible = false;
                if (dataGridView2.Columns.Contains("IngredientId")) dataGridView2.Columns["IngredientId"].Visible = false;
                AddRecipeBinding();
            }
        }

        void AddRecipeBinding()
        {
            txtDinhMuc.DataBindings.Clear();
            cbbNguyenLieu.DataBindings.Clear();

            txtDinhMuc.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "Amount", true, DataSourceUpdateMode.Never));
            cbbNguyenLieu.DataBindings.Add(new Binding("SelectedValue", dataGridView2.DataSource, "IngredientId", true, DataSourceUpdateMode.Never));
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            int foodId = (int)cbbDoUong.SelectedValue;
            int ingreId = (int)cbbNguyenLieu.SelectedValue;
            string size = cbbSize.Text;
            double amount;

            if (!double.TryParse(txtDinhMuc.Text, out amount) || amount <= 0 || string.IsNullOrEmpty(size))
            {
                MessageBox.Show("Vui lòng nhập định mức hợp lệ và chọn Size!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (RecipeBUS.Instance.InsertRecipe(foodId, ingreId, amount, size))
            {
                MessageBox.Show("Thêm vào công thức thành công!");
                CbbDoUong_Size_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Nguyên liệu này đã có trong Size này rồi! Vui lòng dùng nút Sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;

            int recipeId = (int)dataGridView2.CurrentRow.Cells["RecipeId"].Value;
            int foodId = (int)cbbDoUong.SelectedValue;
            int ingreId = (int)cbbNguyenLieu.SelectedValue;
            string size = cbbSize.Text;
            double amount;
            double.TryParse(txtDinhMuc.Text, out amount);

            if (RecipeBUS.Instance.UpdateRecipe(recipeId, foodId, ingreId, amount, size))
            {
                MessageBox.Show("Sửa công thức thành công!");
                CbbDoUong_Size_SelectedIndexChanged(null, null);
            }
        }
        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;
            int recipeId = (int)dataGridView2.CurrentRow.Cells["RecipeId"].Value;

            if (MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này khỏi món?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (RecipeBUS.Instance.DeleteRecipe(recipeId))
                {
                    MessageBox.Show("Xóa thành công!");
                    CbbDoUong_Size_SelectedIndexChanged(null, null);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}