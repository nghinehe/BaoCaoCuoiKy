namespace QuanLyChuoiCuaHangCaFe
{
    partial class frmChiNhanh
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
            this.grbChiNhanh = new System.Windows.Forms.GroupBox();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.lblTenCN = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbDanhSachCN = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbChiNhanh.SuspendLayout();
            this.grbDanhSachCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbChiNhanh
            // 
            this.grbChiNhanh.Controls.Add(this.txtDiaChi);
            this.grbChiNhanh.Controls.Add(this.txtTenCN);
            this.grbChiNhanh.Controls.Add(this.txtMaCN);
            this.grbChiNhanh.Controls.Add(this.btnSua);
            this.grbChiNhanh.Controls.Add(this.btnXoa);
            this.grbChiNhanh.Controls.Add(this.btnThem);
            this.grbChiNhanh.Controls.Add(this.labDiaChi);
            this.grbChiNhanh.Controls.Add(this.lblTenCN);
            this.grbChiNhanh.Controls.Add(this.lblMaCN);
            this.grbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiNhanh.Location = new System.Drawing.Point(21, 14);
            this.grbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChiNhanh.Name = "grbChiNhanh";
            this.grbChiNhanh.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChiNhanh.Size = new System.Drawing.Size(594, 288);
            this.grbChiNhanh.TabIndex = 0;
            this.grbChiNhanh.TabStop = false;
            this.grbChiNhanh.Text = "•THÔNG TIN CHI NHÁNH";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(33, 52);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(160, 25);
            this.lblMaCN.TabIndex = 0;
            this.lblMaCN.Text = "Mã chi nhánh:";
            // 
            // lblTenCN
            // 
            this.lblTenCN.AutoSize = true;
            this.lblTenCN.Location = new System.Drawing.Point(33, 107);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(163, 25);
            this.lblTenCN.TabIndex = 1;
            this.lblTenCN.Text = "Tên chi nhánh:";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(33, 165);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(90, 25);
            this.labDiaChi.TabIndex = 2;
            this.labDiaChi.Text = "Địa chỉ:";
            this.labDiaChi.Click += new System.EventHandler(this.labDiaChi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(75, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(217, 49);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(299, 33);
            this.txtMaCN.TabIndex = 4;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(217, 104);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(299, 33);
            this.txtTenCN.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(217, 157);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(299, 33);
            this.txtDiaChi.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(236, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(398, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 37);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // grbDanhSachCN
            // 
            this.grbDanhSachCN.Controls.Add(this.dataGridView1);
            this.grbDanhSachCN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachCN.Location = new System.Drawing.Point(21, 311);
            this.grbDanhSachCN.Name = "grbDanhSachCN";
            this.grbDanhSachCN.Size = new System.Drawing.Size(594, 229);
            this.grbDanhSachCN.TabIndex = 1;
            this.grbDanhSachCN.TabStop = false;
            this.grbDanhSachCN.Text = "• DANH SÁCH CHI NHÁNH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.grbDanhSachCN);
            this.Controls.Add(this.grbChiNhanh);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChiNhanh";
            this.Text = "Quản lí chi nhánh";
            this.grbChiNhanh.ResumeLayout(false);
            this.grbChiNhanh.PerformLayout();
            this.grbDanhSachCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChiNhanh;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label lblTenCN;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbDanhSachCN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}