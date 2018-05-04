namespace HotelManagement
{
    partial class Login
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
            this.tendangnhaptb = new System.Windows.Forms.TextBox();
            this.tendangnhap = new System.Windows.Forms.Label();
            this.matkhautb = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.Label();
            this.DangNhap_Option = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tendangnhaptb
            // 
            this.tendangnhaptb.Location = new System.Drawing.Point(179, 55);
            this.tendangnhaptb.Multiline = true;
            this.tendangnhaptb.Name = "tendangnhaptb";
            this.tendangnhaptb.Size = new System.Drawing.Size(300, 30);
            this.tendangnhaptb.TabIndex = 4;
            // 
            // tendangnhap
            // 
            this.tendangnhap.AutoSize = true;
            this.tendangnhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendangnhap.ForeColor = System.Drawing.Color.Black;
            this.tendangnhap.Location = new System.Drawing.Point(66, 61);
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(111, 18);
            this.tendangnhap.TabIndex = 3;
            this.tendangnhap.Text = "Tên đăng nhập";
            // 
            // matkhautb
            // 
            this.matkhautb.Location = new System.Drawing.Point(179, 105);
            this.matkhautb.Multiline = true;
            this.matkhautb.Name = "matkhautb";
            this.matkhautb.Size = new System.Drawing.Size(300, 30);
            this.matkhautb.TabIndex = 6;
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ForeColor = System.Drawing.Color.Black;
            this.matkhau.Location = new System.Drawing.Point(106, 111);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(71, 18);
            this.matkhau.TabIndex = 5;
            this.matkhau.Text = "Mật khẩu";
            // 
            // DangNhap_Option
            // 
            this.DangNhap_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.DangNhap_Option.FlatAppearance.BorderSize = 0;
            this.DangNhap_Option.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.DangNhap_Option.ForeColor = System.Drawing.Color.White;
            this.DangNhap_Option.Location = new System.Drawing.Point(340, 158);
            this.DangNhap_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DangNhap_Option.Name = "DangNhap_Option";
            this.DangNhap_Option.Size = new System.Drawing.Size(150, 60);
            this.DangNhap_Option.TabIndex = 7;
            this.DangNhap_Option.Text = "Đăng Nhập";
            this.DangNhap_Option.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.DangNhap_Option);
            this.Controls.Add(this.matkhautb);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.tendangnhaptb);
            this.Controls.Add(this.tendangnhap);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tendangnhaptb;
        private System.Windows.Forms.Label tendangnhap;
        private System.Windows.Forms.TextBox matkhautb;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.Button DangNhap_Option;
    }
}