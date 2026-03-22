namespace QuanLyQuanCafe
{
    partial class QLyorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnquaylai = new System.Windows.Forms.Button();
            this.cbbtenchinh = new System.Windows.Forms.ComboBox();
            this.cbbsize = new System.Windows.Forms.ComboBox();
            this.txtsoluongnuoc = new System.Windows.Forms.TextBox();
            this.cbbmonphu = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.tblFood = new System.Windows.Forms.DataGridView();
            this.btndatmon = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Tan;
            this.btnquaylai.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquaylai.Location = new System.Drawing.Point(245, 13);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(148, 47);
            this.btnquaylai.TabIndex = 21;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // cbbtenchinh
            // 
            this.cbbtenchinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtenchinh.FormattingEnabled = true;
            this.cbbtenchinh.Items.AddRange(new object[] {
            "Trà Đào Cam Xả",
            "Dương Chi Cam Lộ",
            "Trà Vải Nhiệt Đới",
            "Trà Sen Vàng",
            "Hồng Trà Nhài",
            "Trà Xoài Kem chese",
            "Trà Sữa Matcha",
            "Trà Sữa Socola",
            "Trà Sữa Dâu Tây",
            "Sữa Tươi Chân Trâu Đường Đen",
            "Cafe Trứng ",
            "Cafe Muối",
            "Phindi",
            "Cafe Đen",
            "Bạc Sỉu",
            "Nâu Đá"});
            this.cbbtenchinh.Location = new System.Drawing.Point(387, 92);
            this.cbbtenchinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbtenchinh.Name = "cbbtenchinh";
            this.cbbtenchinh.Size = new System.Drawing.Size(222, 28);
            this.cbbtenchinh.TabIndex = 45;
            // 
            // cbbsize
            // 
            this.cbbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsize.FormattingEnabled = true;
            this.cbbsize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cbbsize.Location = new System.Drawing.Point(387, 131);
            this.cbbsize.Margin = new System.Windows.Forms.Padding(4);
            this.cbbsize.Name = "cbbsize";
            this.cbbsize.Size = new System.Drawing.Size(111, 28);
            this.cbbsize.TabIndex = 46;
            // 
            // txtsoluongnuoc
            // 
            this.txtsoluongnuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluongnuoc.Location = new System.Drawing.Point(387, 167);
            this.txtsoluongnuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluongnuoc.Name = "txtsoluongnuoc";
            this.txtsoluongnuoc.Size = new System.Drawing.Size(54, 26);
            this.txtsoluongnuoc.TabIndex = 48;
            // 
            // cbbmonphu
            // 
            this.cbbmonphu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmonphu.FormattingEnabled = true;
            this.cbbmonphu.Items.AddRange(new object[] {
            "Hướng Dương Nguyên Vị",
            "Hướng Dương Vị Dừa",
            "Tiramisu truyền Thống",
            "Tiramisu matcha",
            "Mouse Xoài",
            "Mouse Dâu Tây",
            "Bánh Sừng Bò",
            "Donut Socola",
            "Donut Dâu Tây",
            "Bánh Cookie Socola Hạnh Nhân"});
            this.cbbmonphu.Location = new System.Drawing.Point(774, 88);
            this.cbbmonphu.Margin = new System.Windows.Forms.Padding(4);
            this.cbbmonphu.Name = "cbbmonphu";
            this.cbbmonphu.Size = new System.Drawing.Size(229, 28);
            this.cbbmonphu.TabIndex = 49;
            this.cbbmonphu.SelectedIndexChanged += new System.EventHandler(this.cbbmonphu_SelectedIndexChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(774, 126);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(149, 26);
            this.txtsoluong.TabIndex = 50;
            // 
            // tblFood
            // 
            this.tblFood.BackgroundColor = System.Drawing.Color.White;
            this.tblFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFood.GridColor = System.Drawing.Color.Black;
            this.tblFood.Location = new System.Drawing.Point(245, 230);
            this.tblFood.Margin = new System.Windows.Forms.Padding(4);
            this.tblFood.Name = "tblFood";
            this.tblFood.RowHeadersWidth = 51;
            this.tblFood.Size = new System.Drawing.Size(758, 242);
            this.tblFood.TabIndex = 51;
            this.tblFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblFood_CellContentClick);
            // 
            // btndatmon
            // 
            this.btndatmon.BackColor = System.Drawing.Color.Tan;
            this.btndatmon.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatmon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndatmon.Location = new System.Drawing.Point(603, 180);
            this.btndatmon.Margin = new System.Windows.Forms.Padding(4);
            this.btndatmon.Name = "btndatmon";
            this.btndatmon.Size = new System.Drawing.Size(128, 42);
            this.btndatmon.TabIndex = 52;
            this.btndatmon.Text = "Đặt món";
            this.btndatmon.UseVisualStyleBackColor = false;
            this.btndatmon.Click += new System.EventHandler(this.btndatmon_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Tan;
            this.btnxoa.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnxoa.Location = new System.Drawing.Point(739, 180);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(128, 42);
            this.btnxoa.TabIndex = 53;
            this.btnxoa.Text = "Xóa món";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Tan;
            this.btnsua.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsua.Location = new System.Drawing.Point(875, 180);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(128, 42);
            this.btnsua.TabIndex = 54;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Tan;
            this.btnThanhToan.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(839, 479);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(164, 42);
            this.btnThanhToan.TabIndex = 56;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.hinh_nen_mau_nau_80;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnquaylai);
            this.panel1.Controls.Add(this.txtsoluongnuoc);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.cbbtenchinh);
            this.panel1.Controls.Add(this.btndatmon);
            this.panel1.Controls.Add(this.cbbmonphu);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tblFood);
            this.panel1.Controls.Add(this.cbbsize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 536);
            this.panel1.TabIndex = 57;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(666, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "Số lượng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(667, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Món phụ:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tên đồ uống:";
            // 
            // QLyorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1061, 580);
            this.Name = "QLyorder";
            this.Text = "odelnew";
            this.Load += new System.EventHandler(this.QLyorder_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tblFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.ComboBox cbbtenchinh;
        private System.Windows.Forms.ComboBox cbbsize;
        private System.Windows.Forms.TextBox txtsoluongnuoc;
        private System.Windows.Forms.ComboBox cbbmonphu;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.DataGridView tblFood;
        private System.Windows.Forms.Button btndatmon;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}