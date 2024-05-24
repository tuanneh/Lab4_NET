namespace QuanNet
{
    partial class formNguoiDung
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_TraCuuTK = new System.Windows.Forms.Button();
            this.BTN_CapNhatTK = new System.Windows.Forms.Button();
            this.BTN_XoaTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_ThongTinNguoiDung = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.Exit);
            this.groupBox2.Controls.Add(this.BTN_TraCuuTK);
            this.groupBox2.Controls.Add(this.BTN_CapNhatTK);
            this.groupBox2.Controls.Add(this.BTN_XoaTK);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(419, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 193);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FUNCTION";
            // 
            // BTN_TraCuuTK
            // 
            this.BTN_TraCuuTK.Location = new System.Drawing.Point(15, 45);
            this.BTN_TraCuuTK.Name = "BTN_TraCuuTK";
            this.BTN_TraCuuTK.Size = new System.Drawing.Size(142, 57);
            this.BTN_TraCuuTK.TabIndex = 3;
            this.BTN_TraCuuTK.Text = "TRA CỨU";
            this.BTN_TraCuuTK.UseVisualStyleBackColor = true;
            this.BTN_TraCuuTK.Click += new System.EventHandler(this.BTN_TraCuuTK_Click);
            // 
            // BTN_CapNhatTK
            // 
            this.BTN_CapNhatTK.Location = new System.Drawing.Point(15, 124);
            this.BTN_CapNhatTK.Name = "BTN_CapNhatTK";
            this.BTN_CapNhatTK.Size = new System.Drawing.Size(142, 54);
            this.BTN_CapNhatTK.TabIndex = 2;
            this.BTN_CapNhatTK.Text = "CẬP NHẬT";
            this.BTN_CapNhatTK.UseVisualStyleBackColor = true;
            // 
            // BTN_XoaTK
            // 
            this.BTN_XoaTK.Location = new System.Drawing.Point(199, 45);
            this.BTN_XoaTK.Name = "BTN_XoaTK";
            this.BTN_XoaTK.Size = new System.Drawing.Size(142, 54);
            this.BTN_XoaTK.TabIndex = 1;
            this.BTN_XoaTK.Text = "XÓA TK";
            this.BTN_XoaTK.UseVisualStyleBackColor = true;
            this.BTN_XoaTK.Click += new System.EventHandler(this.BTN_XoaTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI KHOẢN:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(15, 86);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(354, 30);
            this.txtTaiKhoan.TabIndex = 2;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // data_ThongTinNguoiDung
            // 
            this.data_ThongTinNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThongTinNguoiDung.Location = new System.Drawing.Point(7, 281);
            this.data_ThongTinNguoiDung.Name = "data_ThongTinNguoiDung";
            this.data_ThongTinNguoiDung.RowHeadersWidth = 51;
            this.data_ThongTinNguoiDung.RowTemplate.Height = 24;
            this.data_ThongTinNguoiDung.Size = new System.Drawing.Size(781, 156);
            this.data_ThongTinNguoiDung.TabIndex = 4;
            this.data_ThongTinNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(199, 124);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(142, 54);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "THOÁT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // formNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_ThongTinNguoiDung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formNguoiDung";
            this.Text = "NguoiDung";
            this.Load += new System.EventHandler(this.formNguoiDung_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_CapNhatTK;
        private System.Windows.Forms.Button BTN_XoaTK;
        private System.Windows.Forms.Button BTN_TraCuuTK;
        private System.Windows.Forms.DataGridView data_ThongTinNguoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
    }
}