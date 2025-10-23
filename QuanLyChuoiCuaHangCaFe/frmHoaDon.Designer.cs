namespace QuanLyChuoiCuaHangCaFe
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.grbThongTinHD = new System.Windows.Forms.GroupBox();
            this.btnXemChiTietHD = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChinhanh = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbThongTinHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(202, 41);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(323, 33);
            this.txtMaHD.TabIndex = 0;
            // 
            // grbThongTinHD
            // 
            this.grbThongTinHD.Controls.Add(this.btnLuu);
            this.grbThongTinHD.Controls.Add(this.btnXoa);
            this.grbThongTinHD.Controls.Add(this.btnSua);
            this.grbThongTinHD.Controls.Add(this.btnThem);
            this.grbThongTinHD.Controls.Add(this.btnXemChiTietHD);
            this.grbThongTinHD.Controls.Add(this.comboBox1);
            this.grbThongTinHD.Controls.Add(this.lblChinhanh);
            this.grbThongTinHD.Controls.Add(this.lblNgayLap);
            this.grbThongTinHD.Controls.Add(this.lblMaHD);
            this.grbThongTinHD.Controls.Add(this.dtpNgayLap);
            this.grbThongTinHD.Controls.Add(this.txtMaHD);
            this.grbThongTinHD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinHD.ForeColor = System.Drawing.Color.Navy;
            this.grbThongTinHD.Location = new System.Drawing.Point(27, 24);
            this.grbThongTinHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTinHD.Name = "grbThongTinHD";
            this.grbThongTinHD.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTinHD.Size = new System.Drawing.Size(754, 275);
            this.grbThongTinHD.TabIndex = 1;
            this.grbThongTinHD.TabStop = false;
            this.grbThongTinHD.Text = "• THÔNG TIN HÓA ĐƠN";
            this.grbThongTinHD.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnXemChiTietHD
            // 
            this.btnXemChiTietHD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXemChiTietHD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietHD.ForeColor = System.Drawing.Color.Navy;
            this.btnXemChiTietHD.ImageIndex = 0;
            this.btnXemChiTietHD.ImageList = this.imageList1;
            this.btnXemChiTietHD.Location = new System.Drawing.Point(202, 219);
            this.btnXemChiTietHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemChiTietHD.Name = "btnXemChiTietHD";
            this.btnXemChiTietHD.Size = new System.Drawing.Size(211, 46);
            this.btnXemChiTietHD.TabIndex = 4;
            this.btnXemChiTietHD.Text = "Chi tiết hóa đơn";
            this.btnXemChiTietHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemChiTietHD.UseVisualStyleBackColor = false;
            this.btnXemChiTietHD.Click += new System.EventHandler(this.btnXemChiTietHD_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 99);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // lblChinhanh
            // 
            this.lblChinhanh.AutoSize = true;
            this.lblChinhanh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChinhanh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblChinhanh.Location = new System.Drawing.Point(52, 102);
            this.lblChinhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChinhanh.Name = "lblChinhanh";
            this.lblChinhanh.Size = new System.Drawing.Size(115, 26);
            this.lblChinhanh.TabIndex = 2;
            this.lblChinhanh.Text = "Chi nhánh:";
            this.lblChinhanh.Click += new System.EventHandler(this.lblChinhanh_Click);
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNgayLap.Location = new System.Drawing.Point(52, 157);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(100, 26);
            this.lblNgayLap.TabIndex = 2;
            this.lblNgayLap.Text = "Ngày lập:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMaHD.Location = new System.Drawing.Point(52, 44);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(129, 26);
            this.lblMaHD.TabIndex = 2;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Location = new System.Drawing.Point(202, 157);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(323, 33);
            this.dtpNgayLap.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(27, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(754, 389);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(165, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(360, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bill_6303155.png");
            this.imageList1.Images.SetKeyName(1, "add_15526434.png");
            this.imageList1.Images.SetKeyName(2, "tools_17410833.png");
            this.imageList1.Images.SetKeyName(3, "delete_12530858.png");
            this.imageList1.Images.SetKeyName(4, "save_18551749.png");
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.ImageIndex = 1;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(579, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 47);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.ImageIndex = 2;
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(580, 91);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 46);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.ImageIndex = 3;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(580, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 47);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.ImageIndex = 4;
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(580, 215);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 45);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 870);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbThongTinHD);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.grbThongTinHD.ResumeLayout(false);
            this.grbThongTinHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.GroupBox grbThongTinHD;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChinhanh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXemChiTietHD;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
    }
}