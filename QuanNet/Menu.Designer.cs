namespace QuanNet
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.NguoiDung = new System.Windows.Forms.Button();
            this.TTMay = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NguoiDung
            // 
            this.NguoiDung.Location = new System.Drawing.Point(251, 114);
            this.NguoiDung.Name = "NguoiDung";
            this.NguoiDung.Size = new System.Drawing.Size(202, 99);
            this.NguoiDung.TabIndex = 0;
            this.NguoiDung.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.NguoiDung.UseVisualStyleBackColor = true;
            this.NguoiDung.Click += new System.EventHandler(this.button1_Click);
            // 
            // TTMay
            // 
            this.TTMay.Location = new System.Drawing.Point(548, 114);
            this.TTMay.Name = "TTMay";
            this.TTMay.Size = new System.Drawing.Size(202, 99);
            this.TTMay.TabIndex = 1;
            this.TTMay.Text = "MÁY CHỦ";
            this.TTMay.UseVisualStyleBackColor = true;
            this.TTMay.Click += new System.EventHandler(this.TTMay_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(408, 282);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(202, 99);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Thoat";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 170);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ QUÁN NET";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TTMay);
            this.Controls.Add(this.NguoiDung);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NguoiDung;
        private System.Windows.Forms.Button TTMay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

