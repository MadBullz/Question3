
namespace Question3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbNgayYeuCau = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.dtpNgayYeuCau = new System.Windows.Forms.DateTimePicker();
            this.listName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Location = new System.Drawing.Point(36, 31);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(86, 20);
            this.lbKhachHang.TabIndex = 0;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // lbNgayYeuCau
            // 
            this.lbNgayYeuCau.AutoSize = true;
            this.lbNgayYeuCau.Location = new System.Drawing.Point(251, 31);
            this.lbNgayYeuCau.Name = "lbNgayYeuCau";
            this.lbNgayYeuCau.Size = new System.Drawing.Size(98, 20);
            this.lbNgayYeuCau.TabIndex = 2;
            this.lbNgayYeuCau.Text = "Ngày yêu cầu";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(251, 104);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(126, 20);
            this.lbDiaChi.TabIndex = 3;
            this.lbDiaChi.Text = "Địa chỉ giao hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(384, 104);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(224, 135);
            this.txtDiaChi.TabIndex = 5;
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.Location = new System.Drawing.Point(467, 294);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(140, 36);
            this.btnTaoDonHang.TabIndex = 6;
            this.btnTaoDonHang.Text = "Tạo đơn hàng";
            this.btnTaoDonHang.UseVisualStyleBackColor = true;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // dtpNgayYeuCau
            // 
            this.dtpNgayYeuCau.Location = new System.Drawing.Point(384, 31);
            this.dtpNgayYeuCau.Name = "dtpNgayYeuCau";
            this.dtpNgayYeuCau.Size = new System.Drawing.Size(224, 27);
            this.dtpNgayYeuCau.TabIndex = 7;
            // 
            // listName
            // 
            this.listName.FormattingEnabled = true;
            this.listName.ItemHeight = 20;
            this.listName.Items.AddRange(new object[] {
            "Giáp Phương Thảo",
            "Hoàng Đức Chính",
            "Vũ Thu Phương",
            "Võ Lan Viên",
            "Đoàn Thanh Hải"});
            this.listName.Location = new System.Drawing.Point(36, 69);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(190, 244);
            this.listName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 351);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.dtpNgayYeuCau);
            this.Controls.Add(this.btnTaoDonHang);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbNgayYeuCau);
            this.Controls.Add(this.lbKhachHang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbNgayYeuCau;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.DateTimePicker dtpNgayYeuCau;
        private System.Windows.Forms.ListBox listName;
    }
}

