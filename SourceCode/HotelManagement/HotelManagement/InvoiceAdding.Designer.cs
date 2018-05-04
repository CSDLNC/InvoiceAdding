namespace HotelManagement
{
    partial class InvoiceAdding
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
            this.QuayLaisv_Option = new System.Windows.Forms.Button();
            this.ThemHoaDon_Option = new System.Windows.Forms.Button();
            this.madatphonglb = new System.Windows.Forms.Label();
            this.tongtienlb = new System.Windows.Forms.Label();
            this.ngaythanhtoanlb = new System.Windows.Forms.Label();
            this.mahdlb = new System.Windows.Forms.Label();
            this.mahdtb = new System.Windows.Forms.TextBox();
            this.ngaythanhtoandt = new System.Windows.Forms.DateTimePicker();
            this.tongtientb = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuaHoaDon_Option = new System.Windows.Forms.Button();
            this.XoaHoaDon_Option = new System.Windows.Forms.Button();
            this.quanlyhoadongb = new System.Windows.Forms.GroupBox();
            this.danhsachhoadongb = new System.Windows.Forms.GroupBox();
            this.danhsachhoadon = new System.Windows.Forms.DataGridView();
            this.quanlyhoadongb.SuspendLayout();
            this.danhsachhoadongb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // QuayLaisv_Option
            // 
            this.QuayLaisv_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.QuayLaisv_Option.FlatAppearance.BorderSize = 0;
            this.QuayLaisv_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.QuayLaisv_Option.ForeColor = System.Drawing.Color.White;
            this.QuayLaisv_Option.Location = new System.Drawing.Point(1174, 118);
            this.QuayLaisv_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.QuayLaisv_Option.Name = "QuayLaisv_Option";
            this.QuayLaisv_Option.Size = new System.Drawing.Size(100, 30);
            this.QuayLaisv_Option.TabIndex = 34;
            this.QuayLaisv_Option.Text = "Quay Lại";
            this.QuayLaisv_Option.UseVisualStyleBackColor = false;
            // 
            // ThemHoaDon_Option
            // 
            this.ThemHoaDon_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.ThemHoaDon_Option.FlatAppearance.BorderSize = 0;
            this.ThemHoaDon_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.ThemHoaDon_Option.ForeColor = System.Drawing.Color.White;
            this.ThemHoaDon_Option.Location = new System.Drawing.Point(615, 59);
            this.ThemHoaDon_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ThemHoaDon_Option.Name = "ThemHoaDon_Option";
            this.ThemHoaDon_Option.Size = new System.Drawing.Size(100, 30);
            this.ThemHoaDon_Option.TabIndex = 33;
            this.ThemHoaDon_Option.Text = "Thêm";
            this.ThemHoaDon_Option.UseVisualStyleBackColor = false;
            this.ThemHoaDon_Option.Click += new System.EventHandler(this.ThemHoaDon_Option_Click);
            // 
            // madatphonglb
            // 
            this.madatphonglb.AutoSize = true;
            this.madatphonglb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madatphonglb.Location = new System.Drawing.Point(461, 39);
            this.madatphonglb.Name = "madatphonglb";
            this.madatphonglb.Size = new System.Drawing.Size(103, 18);
            this.madatphonglb.TabIndex = 31;
            this.madatphonglb.Text = "Mã đặt phòng";
            // 
            // tongtienlb
            // 
            this.tongtienlb.AutoSize = true;
            this.tongtienlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtienlb.Location = new System.Drawing.Point(311, 39);
            this.tongtienlb.Name = "tongtienlb";
            this.tongtienlb.Size = new System.Drawing.Size(72, 18);
            this.tongtienlb.TabIndex = 30;
            this.tongtienlb.Text = "Tổng tiền";
            // 
            // ngaythanhtoanlb
            // 
            this.ngaythanhtoanlb.AutoSize = true;
            this.ngaythanhtoanlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythanhtoanlb.Location = new System.Drawing.Point(163, 39);
            this.ngaythanhtoanlb.Name = "ngaythanhtoanlb";
            this.ngaythanhtoanlb.Size = new System.Drawing.Size(119, 18);
            this.ngaythanhtoanlb.TabIndex = 28;
            this.ngaythanhtoanlb.Text = "Ngày thanh toán";
            this.ngaythanhtoanlb.Click += new System.EventHandler(this.ngaythanhtoanlb_Click);
            // 
            // mahdlb
            // 
            this.mahdlb.AutoSize = true;
            this.mahdlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahdlb.Location = new System.Drawing.Point(15, 39);
            this.mahdlb.Name = "mahdlb";
            this.mahdlb.Size = new System.Drawing.Size(92, 18);
            this.mahdlb.TabIndex = 26;
            this.mahdlb.Text = "Mã hóa đơn";
            // 
            // mahdtb
            // 
            this.mahdtb.Location = new System.Drawing.Point(18, 59);
            this.mahdtb.Name = "mahdtb";
            this.mahdtb.Size = new System.Drawing.Size(120, 26);
            this.mahdtb.TabIndex = 36;
            this.mahdtb.TextChanged += new System.EventHandler(this.mahdtb_TextChanged);
            // 
            // ngaythanhtoandt
            // 
            this.ngaythanhtoandt.Location = new System.Drawing.Point(166, 59);
            this.ngaythanhtoandt.Name = "ngaythanhtoandt";
            this.ngaythanhtoandt.Size = new System.Drawing.Size(120, 26);
            this.ngaythanhtoandt.TabIndex = 38;
            this.ngaythanhtoandt.ValueChanged += new System.EventHandler(this.ngaythanhtoandt_ValueChanged);
            // 
            // tongtientb
            // 
            this.tongtientb.Location = new System.Drawing.Point(314, 59);
            this.tongtientb.Name = "tongtientb";
            this.tongtientb.Size = new System.Drawing.Size(120, 26);
            this.tongtientb.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 26);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SuaHoaDon_Option
            // 
            this.SuaHoaDon_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.SuaHoaDon_Option.FlatAppearance.BorderSize = 0;
            this.SuaHoaDon_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.SuaHoaDon_Option.ForeColor = System.Drawing.Color.White;
            this.SuaHoaDon_Option.Location = new System.Drawing.Point(731, 59);
            this.SuaHoaDon_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.SuaHoaDon_Option.Name = "SuaHoaDon_Option";
            this.SuaHoaDon_Option.Size = new System.Drawing.Size(100, 30);
            this.SuaHoaDon_Option.TabIndex = 41;
            this.SuaHoaDon_Option.Text = "Sửa";
            this.SuaHoaDon_Option.UseVisualStyleBackColor = false;
            this.SuaHoaDon_Option.Click += new System.EventHandler(this.SuaHoaDon_Option_Click);
            // 
            // XoaHoaDon_Option
            // 
            this.XoaHoaDon_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.XoaHoaDon_Option.FlatAppearance.BorderSize = 0;
            this.XoaHoaDon_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.XoaHoaDon_Option.ForeColor = System.Drawing.Color.White;
            this.XoaHoaDon_Option.Location = new System.Drawing.Point(846, 59);
            this.XoaHoaDon_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.XoaHoaDon_Option.Name = "XoaHoaDon_Option";
            this.XoaHoaDon_Option.Size = new System.Drawing.Size(100, 30);
            this.XoaHoaDon_Option.TabIndex = 42;
            this.XoaHoaDon_Option.Text = "Xóa";
            this.XoaHoaDon_Option.UseVisualStyleBackColor = false;
            this.XoaHoaDon_Option.Click += new System.EventHandler(this.XoaHoaDon_Option_Click);
            // 
            // quanlyhoadongb
            // 
            this.quanlyhoadongb.Controls.Add(this.mahdlb);
            this.quanlyhoadongb.Controls.Add(this.XoaHoaDon_Option);
            this.quanlyhoadongb.Controls.Add(this.mahdtb);
            this.quanlyhoadongb.Controls.Add(this.SuaHoaDon_Option);
            this.quanlyhoadongb.Controls.Add(this.ngaythanhtoanlb);
            this.quanlyhoadongb.Controls.Add(this.comboBox1);
            this.quanlyhoadongb.Controls.Add(this.ThemHoaDon_Option);
            this.quanlyhoadongb.Controls.Add(this.ngaythanhtoandt);
            this.quanlyhoadongb.Controls.Add(this.tongtientb);
            this.quanlyhoadongb.Controls.Add(this.tongtienlb);
            this.quanlyhoadongb.Controls.Add(this.madatphonglb);
            this.quanlyhoadongb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlyhoadongb.Location = new System.Drawing.Point(44, 43);
            this.quanlyhoadongb.Name = "quanlyhoadongb";
            this.quanlyhoadongb.Size = new System.Drawing.Size(999, 105);
            this.quanlyhoadongb.TabIndex = 43;
            this.quanlyhoadongb.TabStop = false;
            this.quanlyhoadongb.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // danhsachhoadongb
            // 
            this.danhsachhoadongb.Controls.Add(this.danhsachhoadon);
            this.danhsachhoadongb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachhoadongb.Location = new System.Drawing.Point(44, 172);
            this.danhsachhoadongb.Name = "danhsachhoadongb";
            this.danhsachhoadongb.Size = new System.Drawing.Size(1230, 505);
            this.danhsachhoadongb.TabIndex = 44;
            this.danhsachhoadongb.TabStop = false;
            this.danhsachhoadongb.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // danhsachhoadon
            // 
            this.danhsachhoadon.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.danhsachhoadon.ColumnHeadersHeight = 30;
            this.danhsachhoadon.Location = new System.Drawing.Point(10, 22);
            this.danhsachhoadon.Name = "danhsachhoadon";
            this.danhsachhoadon.Size = new System.Drawing.Size(1205, 472);
            this.danhsachhoadon.TabIndex = 0;
            this.danhsachhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachhoadon_CellClick);
            // 
            // InvoiceAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1317, 739);
            this.Controls.Add(this.danhsachhoadongb);
            this.Controls.Add(this.quanlyhoadongb);
            this.Controls.Add(this.QuayLaisv_Option);
            this.Name = "InvoiceAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceAdding";
            this.Load += new System.EventHandler(this.InvoiceAdding_Load);
            this.quanlyhoadongb.ResumeLayout(false);
            this.quanlyhoadongb.PerformLayout();
            this.danhsachhoadongb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuayLaisv_Option;
        private System.Windows.Forms.Button ThemHoaDon_Option;
        private System.Windows.Forms.Label madatphonglb;
        private System.Windows.Forms.Label tongtienlb;
        private System.Windows.Forms.Label ngaythanhtoanlb;
        private System.Windows.Forms.Label mahdlb;
        private System.Windows.Forms.TextBox mahdtb;
        private System.Windows.Forms.DateTimePicker ngaythanhtoandt;
        private System.Windows.Forms.TextBox tongtientb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SuaHoaDon_Option;
        private System.Windows.Forms.Button XoaHoaDon_Option;
        private System.Windows.Forms.GroupBox quanlyhoadongb;
        private System.Windows.Forms.GroupBox danhsachhoadongb;
        private System.Windows.Forms.DataGridView danhsachhoadon;
    }
}