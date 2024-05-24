namespace QuanNet
{
    partial class formThongTinMay
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Thoat = new System.Windows.Forms.Button();
            this.BTN_TraCuu = new System.Windows.Forms.Button();
            this.BTN_CapNhat = new System.Windows.Forms.Button();
            this.checkTrangThaiMay = new System.Windows.Forms.CheckedListBox();
            this.textSoMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_ThongTinMay = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinMay)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUẢN LÝ THÔNG TIN MÁY";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.BTN_Thoat);
            this.groupBox1.Controls.Add(this.BTN_TraCuu);
            this.groupBox1.Controls.Add(this.BTN_CapNhat);
            this.groupBox1.Controls.Add(this.checkTrangThaiMay);
            this.groupBox1.Controls.Add(this.textSoMay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 362);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN MÁY";
            // 
            // BTN_Thoat
            // 
            this.BTN_Thoat.BackColor = System.Drawing.Color.Red;
            this.BTN_Thoat.Location = new System.Drawing.Point(11, 293);
            this.BTN_Thoat.Name = "BTN_Thoat";
            this.BTN_Thoat.Size = new System.Drawing.Size(399, 54);
            this.BTN_Thoat.TabIndex = 7;
            this.BTN_Thoat.Text = "THOÁT";
            this.BTN_Thoat.UseVisualStyleBackColor = false;
            this.BTN_Thoat.Click += new System.EventHandler(this.BTN_Thoat_Click);
            // 
            // BTN_TraCuu
            // 
            this.BTN_TraCuu.Location = new System.Drawing.Point(239, 200);
            this.BTN_TraCuu.Name = "BTN_TraCuu";
            this.BTN_TraCuu.Size = new System.Drawing.Size(181, 56);
            this.BTN_TraCuu.TabIndex = 6;
            this.BTN_TraCuu.Text = "TRA CỨU";
            this.BTN_TraCuu.UseVisualStyleBackColor = true;
            this.BTN_TraCuu.Click += new System.EventHandler(this.BTN_TraCuu_Click);
            // 
            // BTN_CapNhat
            // 
            this.BTN_CapNhat.Location = new System.Drawing.Point(11, 200);
            this.BTN_CapNhat.Name = "BTN_CapNhat";
            this.BTN_CapNhat.Size = new System.Drawing.Size(181, 56);
            this.BTN_CapNhat.TabIndex = 5;
            this.BTN_CapNhat.Text = "CẬP NHẬT";
            this.BTN_CapNhat.UseVisualStyleBackColor = true;
            // 
            // checkTrangThaiMay
            // 
            this.checkTrangThaiMay.FormattingEnabled = true;
            this.checkTrangThaiMay.Items.AddRange(new object[] {
            "CÒN TRỐNG",
            "ĐANG HOẠT ĐỘNG"});
            this.checkTrangThaiMay.Location = new System.Drawing.Point(180, 84);
            this.checkTrangThaiMay.Name = "checkTrangThaiMay";
            this.checkTrangThaiMay.Size = new System.Drawing.Size(240, 54);
            this.checkTrangThaiMay.TabIndex = 4;
            // 
            // textSoMay
            // 
            this.textSoMay.Location = new System.Drawing.Point(180, 38);
            this.textSoMay.Name = "textSoMay";
            this.textSoMay.Size = new System.Drawing.Size(240, 30);
            this.textSoMay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TRẠNG THÁI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP SỐ MÁY";
            // 
            // data_ThongTinMay
            // 
            this.data_ThongTinMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThongTinMay.Location = new System.Drawing.Point(448, 76);
            this.data_ThongTinMay.Name = "data_ThongTinMay";
            this.data_ThongTinMay.RowHeadersWidth = 51;
            this.data_ThongTinMay.RowTemplate.Height = 24;
            this.data_ThongTinMay.Size = new System.Drawing.Size(345, 361);
            this.data_ThongTinMay.TabIndex = 8;
            // 
            // formThongTinMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_ThongTinMay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "formThongTinMay";
            this.Text = "ThongTinMay";
            this.Load += new System.EventHandler(this.formThongTinMay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_ThongTinMay;
        private System.Windows.Forms.Button BTN_Thoat;
        private System.Windows.Forms.Button BTN_TraCuu;
        private System.Windows.Forms.Button BTN_CapNhat;
        private System.Windows.Forms.CheckedListBox checkTrangThaiMay;
        private System.Windows.Forms.TextBox textSoMay;
    }
}