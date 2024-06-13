namespace QL_Sách
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.maSach1 = new System.Windows.Forms.Label();
            this.nhaXuatBan1 = new System.Windows.Forms.Label();
            this.namXuatBan1 = new System.Windows.Forms.Label();
            this.tenSach1 = new System.Windows.Forms.Label();
            this.giaSach1 = new System.Windows.Forms.Label();
            this.txtNhXB = new System.Windows.Forms.TextBox();
            this.txtNaXB = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dsSanPham = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(210, 25, 210, 25);
            this.label1.Size = new System.Drawing.Size(762, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thông Tin Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(172, 114);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 2;
            // 
            // maSach1
            // 
            this.maSach1.AutoSize = true;
            this.maSach1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSach1.Location = new System.Drawing.Point(27, 114);
            this.maSach1.Name = "maSach1";
            this.maSach1.Size = new System.Drawing.Size(83, 22);
            this.maSach1.TabIndex = 4;
            this.maSach1.Text = "Mã Sách";
            // 
            // nhaXuatBan1
            // 
            this.nhaXuatBan1.AutoSize = true;
            this.nhaXuatBan1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaXuatBan1.Location = new System.Drawing.Point(27, 154);
            this.nhaXuatBan1.Name = "nhaXuatBan1";
            this.nhaXuatBan1.Size = new System.Drawing.Size(124, 22);
            this.nhaXuatBan1.TabIndex = 5;
            this.nhaXuatBan1.Text = "Nhà Xuất Bản";
            // 
            // namXuatBan1
            // 
            this.namXuatBan1.AutoSize = true;
            this.namXuatBan1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namXuatBan1.Location = new System.Drawing.Point(27, 205);
            this.namXuatBan1.Name = "namXuatBan1";
            this.namXuatBan1.Size = new System.Drawing.Size(130, 22);
            this.namXuatBan1.TabIndex = 6;
            this.namXuatBan1.Text = "Năm Xuất Bản";
            // 
            // tenSach1
            // 
            this.tenSach1.AutoSize = true;
            this.tenSach1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSach1.Location = new System.Drawing.Point(285, 114);
            this.tenSach1.Name = "tenSach1";
            this.tenSach1.Size = new System.Drawing.Size(91, 22);
            this.tenSach1.TabIndex = 7;
            this.tenSach1.Text = "Tên Sách";
            // 
            // giaSach1
            // 
            this.giaSach1.AutoSize = true;
            this.giaSach1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaSach1.Location = new System.Drawing.Point(285, 205);
            this.giaSach1.Name = "giaSach1";
            this.giaSach1.Size = new System.Drawing.Size(80, 22);
            this.giaSach1.TabIndex = 8;
            this.giaSach1.Text = "Giá Tiền";
            // 
            // txtNhXB
            // 
            this.txtNhXB.Location = new System.Drawing.Point(172, 156);
            this.txtNhXB.Name = "txtNhXB";
            this.txtNhXB.Size = new System.Drawing.Size(407, 20);
            this.txtNhXB.TabIndex = 9;
            // 
            // txtNaXB
            // 
            this.txtNaXB.Location = new System.Drawing.Point(172, 207);
            this.txtNaXB.Name = "txtNaXB";
            this.txtNaXB.Size = new System.Drawing.Size(100, 20);
            this.txtNaXB.TabIndex = 10;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(382, 211);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(197, 20);
            this.txtGia.TabIndex = 12;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(382, 114);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(197, 20);
            this.txtTen.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dsSanPham
            // 
            this.dsSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.nhaXuatBan,
            this.namXuatBan,
            this.giaTien});
            this.dsSanPham.Location = new System.Drawing.Point(-3, 290);
            this.dsSanPham.Name = "dsSanPham";
            this.dsSanPham.Size = new System.Drawing.Size(765, 150);
            this.dsSanPham.TabIndex = 15;
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.Name = "maSach";
            this.maSach.ReadOnly = true;
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.Name = "tenSach";
            this.tenSach.ReadOnly = true;
            this.tenSach.Width = 250;
            // 
            // nhaXuatBan
            // 
            this.nhaXuatBan.DataPropertyName = "nhaXuatBan";
            this.nhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.nhaXuatBan.Name = "nhaXuatBan";
            this.nhaXuatBan.ReadOnly = true;
            this.nhaXuatBan.Width = 200;
            // 
            // namXuatBan
            // 
            this.namXuatBan.DataPropertyName = "namXuatBan";
            this.namXuatBan.HeaderText = "Năm Xuất Bản";
            this.namXuatBan.Name = "namXuatBan";
            this.namXuatBan.ReadOnly = true;
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "giaTien";
            this.giaTien.HeaderText = "Giá tiền";
            this.giaTien.Name = "giaTien";
            this.giaTien.ReadOnly = true;
            this.giaTien.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 432);
            this.Controls.Add(this.dsSanPham);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtNaXB);
            this.Controls.Add(this.txtNhXB);
            this.Controls.Add(this.giaSach1);
            this.Controls.Add(this.tenSach1);
            this.Controls.Add(this.namXuatBan1);
            this.Controls.Add(this.nhaXuatBan1);
            this.Controls.Add(this.maSach1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ứng dụng quản lý SÁCH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label maSach1;
        private System.Windows.Forms.Label nhaXuatBan1;
        private System.Windows.Forms.Label namXuatBan1;
        private System.Windows.Forms.Label tenSach1;
        private System.Windows.Forms.Label giaSach1;
        private System.Windows.Forms.TextBox txtNhXB;
        private System.Windows.Forms.TextBox txtNaXB;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dsSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
    }
}

