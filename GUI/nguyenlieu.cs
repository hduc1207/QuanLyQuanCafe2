using QuanLyQuanCafe.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe.GUI
{
    public partial class nguyenlieu : System.Windows.Forms.Form
    {
        BindingSource ingredientList = new BindingSource();

        public nguyenlieu()
        {
            InitializeComponent();
            dataGridView1.DataSource = ingredientList;
            LoadListIngredient();
            AddIngredientBinding();
            textBox1.ReadOnly = true;
            btnthem.Click += Btnthem_Click;
            btnsua.Click += Btnsua_Click;
            btnxoa.Click += Btnxoa_Click;
        }

        void LoadListIngredient()
        {
            ingredientList.DataSource = IngredientBUS.Instance.GetListIngredient();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["IngredientId"].HeaderText = "Mã NL";
                dataGridView1.Columns["IngredientName"].HeaderText = "Tên Nguyên Liệu";
                dataGridView1.Columns["Unit"].HeaderText = "Quy Đổi (Đơn vị)";
                dataGridView1.Columns["Quantity"].HeaderText = "Số Lượng Tồn";
                dataGridView1.Columns["UnitPrice"].HeaderText = "Giá Tiền";
                if (dataGridView1.Columns.Contains("MinQuantity"))
                    dataGridView1.Columns["MinQuantity"].Visible = false; 
            }
        }
        void AddIngredientBinding()
        {
            textBox1.DataBindings.Clear(); 
            textBox3.DataBindings.Clear(); 
            textBox2.DataBindings.Clear();
            textBox4.DataBindings.Clear(); 
            textBox5.DataBindings.Clear(); 

            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IngredientId", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IngredientName", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Unit", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Quantity", true, DataSourceUpdateMode.Never));
            textBox5.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "UnitPrice", true, DataSourceUpdateMode.Never));
        }
        private void Btnthem_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string unit = textBox2.Text;
            double quantity;
            decimal price;

            double.TryParse(textBox4.Text, out quantity);
            decimal.TryParse(textBox5.Text, out price);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên nguyên liệu và Quy đổi (Đơn vị tính)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IngredientBUS.Instance.InsertIngredient(name, unit, quantity, price, 10))
            {
                MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListIngredient();
            }
        }
        private void Btnsua_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu trên bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBox3.Text;
            string unit = textBox2.Text;
            double quantity;
            decimal price;

            double.TryParse(textBox4.Text, out quantity);
            decimal.TryParse(textBox5.Text, out price);

            if (IngredientBUS.Instance.UpdateIngredient(id, name, unit, quantity, price, 10))
            {
                MessageBox.Show("Sửa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListIngredient();
            }
        }
        private void Btnxoa_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu trên bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IngredientBUS.Instance.IsIngredientUsed(id))
            {
                MessageBox.Show("Nguyên liệu này ĐANG ĐƯỢC DÙNG trong Công thức pha chế.\nKhông thể xóa để tránh lỗi hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IngredientBUS.Instance.DeleteIngredient(id))
                {
                    MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListIngredient();
                }
            }
        }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}