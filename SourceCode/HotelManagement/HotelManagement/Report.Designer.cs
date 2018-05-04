namespace HotelManagement
{
    partial class Report
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
            this.quanlybaocaogb = new System.Windows.Forms.GroupBox();
            this.thanglb = new System.Windows.Forms.Label();
            this.namlb = new System.Windows.Forms.Label();
            this.tenkslb = new System.Windows.Forms.Label();
            this.tenkstb = new System.Windows.Forms.TextBox();
            this.thangtb = new System.Windows.Forms.TextBox();
            this.namtb = new System.Windows.Forms.TextBox();
            this.ChonBaoCao_Option = new System.Windows.Forms.Button();
            this.danhsachbaocao = new System.Windows.Forms.DataGridView();
            this.danhsachbaocaogb = new System.Windows.Forms.GroupBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuayLaisv_Option = new System.Windows.Forms.Button();
            this.quanlybaocaogb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbaocao)).BeginInit();
            this.danhsachbaocaogb.SuspendLayout();
            this.SuspendLayout();
            // 
            // quanlybaocaogb
            // 
            this.quanlybaocaogb.Controls.Add(this.ChonBaoCao_Option);
            this.quanlybaocaogb.Controls.Add(this.namtb);
            this.quanlybaocaogb.Controls.Add(this.thangtb);
            this.quanlybaocaogb.Controls.Add(this.tenkstb);
            this.quanlybaocaogb.Controls.Add(this.thanglb);
            this.quanlybaocaogb.Controls.Add(this.namlb);
            this.quanlybaocaogb.Controls.Add(this.tenkslb);
            this.quanlybaocaogb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlybaocaogb.Location = new System.Drawing.Point(44, 43);
            this.quanlybaocaogb.Name = "quanlybaocaogb";
            this.quanlybaocaogb.Size = new System.Drawing.Size(651, 105);
            this.quanlybaocaogb.TabIndex = 28;
            this.quanlybaocaogb.TabStop = false;
            this.quanlybaocaogb.Text = "QUẢN LÝ BÁO CÁO";
            // 
            // thanglb
            // 
            this.thanglb.AutoSize = true;
            this.thanglb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanglb.Location = new System.Drawing.Point(165, 39);
            this.thanglb.Name = "thanglb";
            this.thanglb.Size = new System.Drawing.Size(51, 18);
            this.thanglb.TabIndex = 14;
            this.thanglb.Text = "Tháng";
            // 
            // namlb
            // 
            this.namlb.AutoSize = true;
            this.namlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namlb.Location = new System.Drawing.Point(315, 39);
            this.namlb.Name = "namlb";
            this.namlb.Size = new System.Drawing.Size(41, 18);
            this.namlb.TabIndex = 16;
            this.namlb.Text = "Năm";
            // 
            // tenkslb
            // 
            this.tenkslb.AutoSize = true;
            this.tenkslb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkslb.Location = new System.Drawing.Point(15, 39);
            this.tenkslb.Name = "tenkslb";
            this.tenkslb.Size = new System.Drawing.Size(108, 18);
            this.tenkslb.TabIndex = 18;
            this.tenkslb.Text = "Tên khách sạn";
            // 
            // tenkstb
            // 
            this.tenkstb.Location = new System.Drawing.Point(18, 59);
            this.tenkstb.Name = "tenkstb";
            this.tenkstb.Size = new System.Drawing.Size(130, 26);
            this.tenkstb.TabIndex = 19;
            // 
            // thangtb
            // 
            this.thangtb.Location = new System.Drawing.Point(168, 59);
            this.thangtb.Name = "thangtb";
            this.thangtb.Size = new System.Drawing.Size(130, 26);
            this.thangtb.TabIndex = 20;
            // 
            // namtb
            // 
            this.namtb.Location = new System.Drawing.Point(318, 59);
            this.namtb.Name = "namtb";
            this.namtb.Size = new System.Drawing.Size(130, 26);
            this.namtb.TabIndex = 21;
            // 
            // ChonBaoCao_Option
            // 
            this.ChonBaoCao_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.ChonBaoCao_Option.FlatAppearance.BorderSize = 0;
            this.ChonBaoCao_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.ChonBaoCao_Option.ForeColor = System.Drawing.Color.White;
            this.ChonBaoCao_Option.Location = new System.Drawing.Point(508, 57);
            this.ChonBaoCao_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ChonBaoCao_Option.Name = "ChonBaoCao_Option";
            this.ChonBaoCao_Option.Size = new System.Drawing.Size(100, 30);
            this.ChonBaoCao_Option.TabIndex = 29;
            this.ChonBaoCao_Option.Text = "Chọn";
            this.ChonBaoCao_Option.UseVisualStyleBackColor = false;
            // 
            // danhsachbaocao
            // 
            this.danhsachbaocao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.danhsachbaocao.ColumnHeadersHeight = 30;
            this.danhsachbaocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maKS,
            this.tenKS,
            this.Thang,
            this.Nam,
            this.doanhThu});
            this.danhsachbaocao.Location = new System.Drawing.Point(11, 25);
            this.danhsachbaocao.Name = "danhsachbaocao";
            this.danhsachbaocao.RowHeadersWidth = 90;
            this.danhsachbaocao.Size = new System.Drawing.Size(1181, 459);
            this.danhsachbaocao.TabIndex = 0;
            // 
            // danhsachbaocaogb
            // 
            this.danhsachbaocaogb.Controls.Add(this.danhsachbaocao);
            this.danhsachbaocaogb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachbaocaogb.Location = new System.Drawing.Point(44, 172);
            this.danhsachbaocaogb.Name = "danhsachbaocaogb";
            this.danhsachbaocaogb.Size = new System.Drawing.Size(1203, 495);
            this.danhsachbaocaogb.TabIndex = 29;
            this.danhsachbaocaogb.TabStop = false;
            this.danhsachbaocaogb.Text = "DANH SÁCH BÁO CÁO";
            // 
            // STT
            // 
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // maKS
            // 
            this.maKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maKS.Frozen = true;
            this.maKS.HeaderText = "Mã khách sạn";
            this.maKS.Name = "maKS";
            this.maKS.Width = 129;
            // 
            // tenKS
            // 
            this.tenKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenKS.Frozen = true;
            this.tenKS.HeaderText = "Tên khách sạn";
            this.tenKS.Name = "tenKS";
            this.tenKS.Width = 133;
            // 
            // Thang
            // 
            this.Thang.Frozen = true;
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            // 
            // Nam
            // 
            this.Nam.Frozen = true;
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            // 
            // doanhThu
            // 
            this.doanhThu.Frozen = true;
            this.doanhThu.HeaderText = "Doanh thu";
            this.doanhThu.Name = "doanhThu";
            // 
            // QuayLaisv_Option
            // 
            this.QuayLaisv_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.QuayLaisv_Option.FlatAppearance.BorderSize = 0;
            this.QuayLaisv_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.QuayLaisv_Option.ForeColor = System.Drawing.Color.White;
            this.QuayLaisv_Option.Location = new System.Drawing.Point(1147, 118);
            this.QuayLaisv_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.QuayLaisv_Option.Name = "QuayLaisv_Option";
            this.QuayLaisv_Option.Size = new System.Drawing.Size(100, 30);
            this.QuayLaisv_Option.TabIndex = 30;
            this.QuayLaisv_Option.Text = "Quay Lại";
            this.QuayLaisv_Option.UseVisualStyleBackColor = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1301, 700);
            this.Controls.Add(this.QuayLaisv_Option);
            this.Controls.Add(this.danhsachbaocaogb);
            this.Controls.Add(this.quanlybaocaogb);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.quanlybaocaogb.ResumeLayout(false);
            this.quanlybaocaogb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbaocao)).EndInit();
            this.danhsachbaocaogb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quanlybaocaogb;
        private System.Windows.Forms.Label thanglb;
        private System.Windows.Forms.Label namlb;
        private System.Windows.Forms.Label tenkslb;
        private System.Windows.Forms.TextBox namtb;
        private System.Windows.Forms.TextBox thangtb;
        private System.Windows.Forms.TextBox tenkstb;
        private System.Windows.Forms.Button ChonBaoCao_Option;
        private System.Windows.Forms.DataGridView danhsachbaocao;
        private System.Windows.Forms.GroupBox danhsachbaocaogb;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhThu;
        private System.Windows.Forms.Button QuayLaisv_Option;
    }
}