namespace QuanLyQuanCafe.GUI
{
    partial class frmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.btnban = new System.Windows.Forms.Button();
            this.btndouong = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources._3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btndangxuat);
            this.panel2.Controls.Add(this.btnban);
            this.panel2.Controls.Add(this.btndouong);
            this.panel2.Controls.Add(this.btnthongke);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 533);
            this.panel2.TabIndex = 76;
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.Color.White;
            this.btndangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.ForeColor = System.Drawing.Color.Black;
            this.btndangxuat.Location = new System.Drawing.Point(31, 152);
            this.btndangxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(118, 34);
            this.btndangxuat.TabIndex = 56;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = false;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btnban
            // 
            this.btnban.BackColor = System.Drawing.Color.White;
            this.btnban.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnban.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnban.ForeColor = System.Drawing.Color.Black;
            this.btnban.Location = new System.Drawing.Point(31, 14);
            this.btnban.Margin = new System.Windows.Forms.Padding(4);
            this.btnban.Name = "btnban";
            this.btnban.Size = new System.Drawing.Size(118, 34);
            this.btnban.TabIndex = 53;
            this.btnban.Text = "Bàn";
            this.btnban.UseVisualStyleBackColor = false;
            this.btnban.Click += new System.EventHandler(this.btnban_Click);
            // 
            // btndouong
            // 
            this.btndouong.BackColor = System.Drawing.Color.White;
            this.btndouong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndouong.ForeColor = System.Drawing.Color.Black;
            this.btndouong.Location = new System.Drawing.Point(31, 60);
            this.btndouong.Margin = new System.Windows.Forms.Padding(4);
            this.btndouong.Name = "btndouong";
            this.btndouong.Size = new System.Drawing.Size(118, 34);
            this.btndouong.TabIndex = 54;
            this.btndouong.Text = "Đồ uống";
            this.btndouong.UseVisualStyleBackColor = false;
            this.btndouong.Click += new System.EventHandler(this.btndouong_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.White;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.ForeColor = System.Drawing.Color.Black;
            this.btnthongke.Location = new System.Drawing.Point(31, 106);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(118, 34);
            this.btnthongke.TabIndex = 55;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.hinh_nen_mau_nau_80;
            this.panel1.Controls.Add(this.pnContent);
            this.panel1.Location = new System.Drawing.Point(-14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 533);
            this.panel1.TabIndex = 77;
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1059, 533);
            this.pnContent.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button btnban;
        private System.Windows.Forms.Button btndouong;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContent;
    }
}