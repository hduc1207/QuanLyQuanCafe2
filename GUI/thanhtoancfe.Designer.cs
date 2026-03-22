namespace QuanLyQuanCafe
{
    partial class thanhtoancfe
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
            this.components = new System.ComponentModel.Container();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnapdung = new System.Windows.Forms.Button();
            this.tblBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTIenCanThanhToan = new System.Windows.Forms.TextBox();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienKhachTra = new System.Windows.Forms.TextBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Tan;
            this.btnquaylai.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquaylai.Location = new System.Drawing.Point(16, 15);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(148, 47);
            this.btnquaylai.TabIndex = 22;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giảm giá:";
            // 
            // btnapdung
            // 
            this.btnapdung.BackColor = System.Drawing.Color.Tan;
            this.btnapdung.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapdung.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnapdung.Location = new System.Drawing.Point(372, 74);
            this.btnapdung.Margin = new System.Windows.Forms.Padding(4);
            this.btnapdung.Name = "btnapdung";
            this.btnapdung.Size = new System.Drawing.Size(128, 42);
            this.btnapdung.TabIndex = 40;
            this.btnapdung.Text = "Áp Dụng";
            this.btnapdung.UseVisualStyleBackColor = false;
            this.btnapdung.Click += new System.EventHandler(this.btnapdung_Click);
            // 
            // tblBill
            // 
            this.tblBill.BackgroundColor = System.Drawing.Color.White;
            this.tblBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBill.Location = new System.Drawing.Point(20, 124);
            this.tblBill.Margin = new System.Windows.Forms.Padding(4);
            this.tblBill.Name = "tblBill";
            this.tblBill.RowHeadersWidth = 51;
            this.tblBill.Size = new System.Drawing.Size(1013, 213);
            this.tblBill.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tiền cần thanh toán:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTIenCanThanhToan
            // 
            this.txtTIenCanThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIenCanThanhToan.Location = new System.Drawing.Point(226, 356);
            this.txtTIenCanThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTIenCanThanhToan.Name = "txtTIenCanThanhToan";
            this.txtTIenCanThanhToan.ReadOnly = true;
            this.txtTIenCanThanhToan.Size = new System.Drawing.Size(241, 29);
            this.txtTIenCanThanhToan.TabIndex = 43;
            this.txtTIenCanThanhToan.TextChanged += new System.EventHandler(this.txttongtien_TextChanged);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.Color.Tan;
            this.btnthanhtoan.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthanhtoan.Location = new System.Drawing.Point(885, 475);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(148, 47);
            this.btnthanhtoan.TabIndex = 44;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.hinh_nen_mau_nau_80;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtTienThua);
            this.panel2.Controls.Add(this.txtTienKhachTra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnapdung);
            this.panel2.Controls.Add(this.tblBill);
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTIenCanThanhToan);
            this.panel2.Controls.Add(this.btnthanhtoan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 545);
            this.panel2.TabIndex = 47;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(123, 81);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(241, 29);
            this.txtGiamGia.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tiền khách trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tiền thừa:";
            // 
            // txtTienKhachTra
            // 
            this.txtTienKhachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhachTra.Location = new System.Drawing.Point(226, 400);
            this.txtTienKhachTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienKhachTra.Name = "txtTienKhachTra";
            this.txtTienKhachTra.Size = new System.Drawing.Size(241, 29);
            this.txtTienKhachTra.TabIndex = 50;
            this.txtTienKhachTra.TextChanged += new System.EventHandler(this.txtTienKhachTra_TextChanged);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.Location = new System.Drawing.Point(226, 444);
            this.txtTienThua.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.ReadOnly = true;
            this.txtTienThua.Size = new System.Drawing.Size(241, 29);
            this.txtTienThua.TabIndex = 51;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // thanhtoancfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1061, 580);
            this.Name = "thanhtoancfe";
            this.Text = "thanhtoancfe";
            this.Load += new System.EventHandler(this.thanhtoancfe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnapdung;
        private System.Windows.Forms.DataGridView tblBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTIenCanThanhToan;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.TextBox txtTienKhachTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}