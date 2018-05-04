namespace HotelManagement
{
    partial class Option_cl
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
            this.TimKiemVaDatKhachSan = new System.Windows.Forms.Button();
            this.dangxuatlink = new System.Windows.Forms.LinkLabel();
            this.usernamelink = new System.Windows.Forms.LinkLabel();
            this.datkhachsanclient = new System.Windows.Forms.GroupBox();
            this.datkhachsanclient.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimKiemVaDatKhachSan
            // 
            this.TimKiemVaDatKhachSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.TimKiemVaDatKhachSan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiemVaDatKhachSan.ForeColor = System.Drawing.Color.White;
            this.TimKiemVaDatKhachSan.Location = new System.Drawing.Point(75, 45);
            this.TimKiemVaDatKhachSan.Name = "TimKiemVaDatKhachSan";
            this.TimKiemVaDatKhachSan.Size = new System.Drawing.Size(500, 35);
            this.TimKiemVaDatKhachSan.TabIndex = 0;
            this.TimKiemVaDatKhachSan.Text = "Tìm kiếm và đặt khách sạn";
            this.TimKiemVaDatKhachSan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimKiemVaDatKhachSan.UseVisualStyleBackColor = false;
            this.TimKiemVaDatKhachSan.Click += new System.EventHandler(this.TimKiemKhachSan_Click);
            // 
            // dangxuatlink
            // 
            this.dangxuatlink.ActiveLinkColor = System.Drawing.Color.Black;
            this.dangxuatlink.AutoSize = true;
            this.dangxuatlink.DisabledLinkColor = System.Drawing.Color.Red;
            this.dangxuatlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangxuatlink.Location = new System.Drawing.Point(1223, 9);
            this.dangxuatlink.Name = "dangxuatlink";
            this.dangxuatlink.Size = new System.Drawing.Size(82, 20);
            this.dangxuatlink.TabIndex = 27;
            this.dangxuatlink.TabStop = true;
            this.dangxuatlink.Text = "Đăng xuất";
            this.dangxuatlink.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // usernamelink
            // 
            this.usernamelink.ActiveLinkColor = System.Drawing.Color.Black;
            this.usernamelink.AutoSize = true;
            this.usernamelink.DisabledLinkColor = System.Drawing.Color.Red;
            this.usernamelink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelink.Location = new System.Drawing.Point(1137, 9);
            this.usernamelink.Name = "usernamelink";
            this.usernamelink.Size = new System.Drawing.Size(80, 20);
            this.usernamelink.TabIndex = 26;
            this.usernamelink.TabStop = true;
            this.usernamelink.Text = "username";
            this.usernamelink.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // datkhachsanclient
            // 
            this.datkhachsanclient.Controls.Add(this.TimKiemVaDatKhachSan);
            this.datkhachsanclient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datkhachsanclient.Location = new System.Drawing.Point(265, 130);
            this.datkhachsanclient.Name = "datkhachsanclient";
            this.datkhachsanclient.Size = new System.Drawing.Size(795, 178);
            this.datkhachsanclient.TabIndex = 28;
            this.datkhachsanclient.TabStop = false;
            this.datkhachsanclient.Text = "WEBSITE ĐẶT KHÁCH SẠN IVIVU";
            // 
            // Option_cl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1317, 739);
            this.Controls.Add(this.datkhachsanclient);
            this.Controls.Add(this.dangxuatlink);
            this.Controls.Add(this.usernamelink);
            this.Name = "Option_cl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option_cl";
            this.Load += new System.EventHandler(this.Option_cl_Load);
            this.datkhachsanclient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimKiemVaDatKhachSan;
        private System.Windows.Forms.LinkLabel dangxuatlink;
        private System.Windows.Forms.LinkLabel usernamelink;
        private System.Windows.Forms.GroupBox datkhachsanclient;
    }
}