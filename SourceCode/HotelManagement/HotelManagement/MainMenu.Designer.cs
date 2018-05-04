namespace HotelManagement
{
    partial class MainMenu
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
            this.DangNhap = new System.Windows.Forms.Button();
            this.ChuoiDangKi = new System.Windows.Forms.Label();
            this.DangKi = new System.Windows.Forms.Button();
            this.menumaingb = new System.Windows.Forms.GroupBox();
            this.menumaingb.SuspendLayout();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.DangNhap.FlatAppearance.BorderSize = 0;
            this.DangNhap.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DangNhap.ForeColor = System.Drawing.Color.White;
            this.DangNhap.Location = new System.Drawing.Point(59, 121);
            this.DangNhap.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(150, 60);
            this.DangNhap.TabIndex = 0;
            this.DangNhap.Text = "Đăng Nhập";
            this.DangNhap.UseVisualStyleBackColor = false;
            // 
            // ChuoiDangKi
            // 
            this.ChuoiDangKi.AutoSize = true;
            this.ChuoiDangKi.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuoiDangKi.Location = new System.Drawing.Point(54, 207);
            this.ChuoiDangKi.Name = "ChuoiDangKi";
            this.ChuoiDangKi.Size = new System.Drawing.Size(353, 25);
            this.ChuoiDangKi.TabIndex = 1;
            this.ChuoiDangKi.Text = "Đối với tài khoản chưa đăng kí, mời";
            // 
            // DangKi
            // 
            this.DangKi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.DangKi.FlatAppearance.BorderSize = 0;
            this.DangKi.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DangKi.ForeColor = System.Drawing.Color.White;
            this.DangKi.Location = new System.Drawing.Point(413, 187);
            this.DangKi.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DangKi.Name = "DangKi";
            this.DangKi.Size = new System.Drawing.Size(150, 60);
            this.DangKi.TabIndex = 2;
            this.DangKi.Text = "Đăng Kí";
            this.DangKi.UseVisualStyleBackColor = false;
            // 
            // menumaingb
            // 
            this.menumaingb.Controls.Add(this.ChuoiDangKi);
            this.menumaingb.Controls.Add(this.DangKi);
            this.menumaingb.Controls.Add(this.DangNhap);
            this.menumaingb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumaingb.Location = new System.Drawing.Point(347, 116);
            this.menumaingb.Name = "menumaingb";
            this.menumaingb.Size = new System.Drawing.Size(600, 347);
            this.menumaingb.TabIndex = 3;
            this.menumaingb.TabStop = false;
            this.menumaingb.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.menumaingb);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menumaingb.ResumeLayout(false);
            this.menumaingb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.Label ChuoiDangKi;
        private System.Windows.Forms.Button DangKi;
        private System.Windows.Forms.GroupBox menumaingb;
    }
}