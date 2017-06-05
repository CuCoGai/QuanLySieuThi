namespace QuanLySieuThi.View
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XoaDT = new System.Windows.Forms.Button();
            this.btn_SuaDT = new System.Windows.Forms.Button();
            this.btn_ThemDT = new System.Windows.Forms.Button();
            this.btn_showDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxSDTKH = new System.Windows.Forms.TextBox();
            this.textBoxDiaChiKH = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 32);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btn_XoaDT);
            this.groupBox2.Controls.Add(this.btn_SuaDT);
            this.groupBox2.Controls.Add(this.btn_ThemDT);
            this.groupBox2.Controls.Add(this.btn_showDT);
            this.groupBox2.Location = new System.Drawing.Point(710, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 291);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_XoaDT
            // 
            this.btn_XoaDT.Location = new System.Drawing.Point(29, 191);
            this.btn_XoaDT.Name = "btn_XoaDT";
            this.btn_XoaDT.Size = new System.Drawing.Size(89, 30);
            this.btn_XoaDT.TabIndex = 3;
            this.btn_XoaDT.Text = "Xóa";
            this.btn_XoaDT.UseVisualStyleBackColor = true;
            this.btn_XoaDT.Click += new System.EventHandler(this.btn_XoaDT_Click);
            // 
            // btn_SuaDT
            // 
            this.btn_SuaDT.Location = new System.Drawing.Point(29, 139);
            this.btn_SuaDT.Name = "btn_SuaDT";
            this.btn_SuaDT.Size = new System.Drawing.Size(89, 30);
            this.btn_SuaDT.TabIndex = 2;
            this.btn_SuaDT.Text = "Sửa";
            this.btn_SuaDT.UseVisualStyleBackColor = true;
            this.btn_SuaDT.Click += new System.EventHandler(this.btn_SuaDT_Click);
            // 
            // btn_ThemDT
            // 
            this.btn_ThemDT.Location = new System.Drawing.Point(29, 90);
            this.btn_ThemDT.Name = "btn_ThemDT";
            this.btn_ThemDT.Size = new System.Drawing.Size(89, 30);
            this.btn_ThemDT.TabIndex = 1;
            this.btn_ThemDT.Text = "Thêm";
            this.btn_ThemDT.UseVisualStyleBackColor = true;
            this.btn_ThemDT.Click += new System.EventHandler(this.btn_ThemDT_Click);
            // 
            // btn_showDT
            // 
            this.btn_showDT.Location = new System.Drawing.Point(29, 35);
            this.btn_showDT.Name = "btn_showDT";
            this.btn_showDT.Size = new System.Drawing.Size(89, 30);
            this.btn_showDT.TabIndex = 0;
            this.btn_showDT.Text = "Hiển thị DS";
            this.btn_showDT.UseVisualStyleBackColor = true;
            this.btn_showDT.Click += new System.EventHandler(this.btn_showDT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxStatus);
            this.groupBox1.Controls.Add(this.textBoxSDTKH);
            this.groupBox1.Controls.Add(this.textBoxDiaChiKH);
            this.groupBox1.Controls.Add(this.textBoxTenKH);
            this.groupBox1.Controls.Add(this.textBoxMaKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 291);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(120, 168);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(193, 20);
            this.textBoxStatus.TabIndex = 13;
            // 
            // textBoxSDTKH
            // 
            this.textBoxSDTKH.Location = new System.Drawing.Point(448, 96);
            this.textBoxSDTKH.Name = "textBoxSDTKH";
            this.textBoxSDTKH.Size = new System.Drawing.Size(179, 20);
            this.textBoxSDTKH.TabIndex = 12;
            // 
            // textBoxDiaChiKH
            // 
            this.textBoxDiaChiKH.Location = new System.Drawing.Point(448, 38);
            this.textBoxDiaChiKH.Name = "textBoxDiaChiKH";
            this.textBoxDiaChiKH.Size = new System.Drawing.Size(179, 20);
            this.textBoxDiaChiKH.TabIndex = 11;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(120, 96);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(193, 20);
            this.textBoxTenKH.TabIndex = 10;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(120, 36);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(193, 20);
            this.textBoxMaKH.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 219);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(865, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHang";
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XoaDT;
        private System.Windows.Forms.Button btn_SuaDT;
        private System.Windows.Forms.Button btn_ThemDT;
        private System.Windows.Forms.Button btn_showDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxSDTKH;
        private System.Windows.Forms.TextBox textBoxDiaChiKH;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}