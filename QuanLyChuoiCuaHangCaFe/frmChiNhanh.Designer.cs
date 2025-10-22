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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiNhanh));
            this.grbChiNhanh = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.lblTenCN = new System.Windows.Forms.Label();
            this.lblMaCN = new System.Windows.Forms.Label();
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
            this.grbChiNhanh.Controls.Add(this.btnXoa);
            this.grbChiNhanh.Controls.Add(this.btnThem);
            this.grbChiNhanh.Controls.Add(this.btnSua);
            this.grbChiNhanh.Controls.Add(this.txtMaCN);
            this.grbChiNhanh.Controls.Add(this.labDiaChi);
            this.grbChiNhanh.Controls.Add(this.lblTenCN);
            this.grbChiNhanh.Controls.Add(this.lblMaCN);
            this.grbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiNhanh.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbChiNhanh.Location = new System.Drawing.Point(23, 14);
            this.grbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChiNhanh.Name = "grbChiNhanh";
            this.grbChiNhanh.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChiNhanh.Size = new System.Drawing.Size(644, 288);
            this.grbChiNhanh.TabIndex = 0;
            this.grbChiNhanh.TabStop = false;
            this.grbChiNhanh.Text = "•THÔNG TIN CHI NHÁNH";
            this.grbChiNhanh.Enter += new System.EventHandler(this.grbChiNhanh_Enter);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(235, 157);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(324, 33);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(235, 104);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(324, 33);
            this.txtTenCN.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.ImageIndex = 2;
            this.btnXoa.ImageList = this.imageList2;
            this.btnXoa.Location = new System.Drawing.Point(431, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "add_15526434.png");
            this.imageList2.Images.SetKeyName(1, "tools_17410833.png");
            this.imageList2.Images.SetKeyName(2, "delete_12530858.png");
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.imageList2;
            this.btnThem.Location = new System.Drawing.Point(65, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 42);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.ImageIndex = 1;
            this.btnSua.ImageList = this.imageList2;
            this.btnSua.Location = new System.Drawing.Point(246, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = " Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(235, 49);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(324, 33);
            this.txtMaCN.TabIndex = 4;
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiaChi.ForeColor = System.Drawing.Color.Black;
            this.labDiaChi.Location = new System.Drawing.Point(36, 165);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(82, 25);
            this.labDiaChi.TabIndex = 2;
            this.labDiaChi.Text = "Địa chỉ:";
            this.labDiaChi.Click += new System.EventHandler(this.labDiaChi_Click);
            // 
            // lblTenCN
            // 
            this.lblTenCN.AutoSize = true;
            this.lblTenCN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCN.ForeColor = System.Drawing.Color.Black;
            this.lblTenCN.Location = new System.Drawing.Point(36, 107);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(140, 25);
            this.lblTenCN.TabIndex = 1;
            this.lblTenCN.Text = "Tên chi nhánh:";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCN.ForeColor = System.Drawing.Color.Black;
            this.lblMaCN.Location = new System.Drawing.Point(36, 52);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(135, 25);
            this.lblMaCN.TabIndex = 0;
            this.lblMaCN.Text = "Mã chi nhánh:";
            // 
            // grbDanhSachCN
            // 
            this.grbDanhSachCN.Controls.Add(this.dataGridView1);
            this.grbDanhSachCN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachCN.Location = new System.Drawing.Point(23, 311);
            this.grbDanhSachCN.Name = "grbDanhSachCN";
            this.grbDanhSachCN.Size = new System.Drawing.Size(644, 229);
            this.grbDanhSachCN.TabIndex = 1;
            this.grbDanhSachCN.TabStop = false;
            this.grbDanhSachCN.Text = "• DANH SÁCH CHI NHÁNH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 572);
            this.Controls.Add(this.grbDanhSachCN);
            this.Controls.Add(this.grbChiNhanh);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ImageList imageList2;
    }
}