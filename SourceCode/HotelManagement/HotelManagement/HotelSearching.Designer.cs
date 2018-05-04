namespace HotelManagement
{
    partial class HotelSearching
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
            this.usernamelink = new System.Windows.Forms.LinkLabel();
            this.tientucbb = new System.Windows.Forms.ComboBox();
            this.tientulb = new System.Windows.Forms.Label();
            this.dentienlb = new System.Windows.Forms.Label();
            this.dentiencbb = new System.Windows.Forms.ComboBox();
            this.hangsaolb = new System.Windows.Forms.Label();
            this.hangsaocbb = new System.Windows.Forms.ComboBox();
            this.thanhpholb = new System.Windows.Forms.Label();
            this.thanhphotb = new System.Windows.Forms.TextBox();
            this.TimKiemKhachSan_Option = new System.Windows.Forms.Button();
            this.QuayLaicl_Option = new System.Windows.Forms.Button();
            this.dangxuatlink = new System.Windows.Forms.LinkLabel();
            this.timkiemkhachsangb = new System.Windows.Forms.GroupBox();
            this.danhsachkhachsangb = new System.Windows.Forms.GroupBox();
            this.danhsachkhachsan = new System.Windows.Forms.DataGridView();
            this.DatPhongKhachSan_Option = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timkiemkhachsangb.SuspendLayout();
            this.danhsachkhachsangb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachkhachsan)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelink
            // 
            this.usernamelink.ActiveLinkColor = System.Drawing.Color.Black;
            this.usernamelink.AutoSize = true;
            this.usernamelink.DisabledLinkColor = System.Drawing.Color.Red;
            this.usernamelink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelink.Location = new System.Drawing.Point(1120, 9);
            this.usernamelink.Name = "usernamelink";
            this.usernamelink.Size = new System.Drawing.Size(80, 20);
            this.usernamelink.TabIndex = 12;
            this.usernamelink.TabStop = true;
            this.usernamelink.Text = "username";
            this.usernamelink.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // tientucbb
            // 
            this.tientucbb.FormattingEnabled = true;
            this.tientucbb.Items.AddRange(new object[] {
            "Chọn",
            "500.000",
            "1.000.000",
            "1.500.000",
            "2.000.000",
            "2.500.000",
            "3.000.000"});
            this.tientucbb.Location = new System.Drawing.Point(28, 59);
            this.tientucbb.Name = "tientucbb";
            this.tientucbb.Size = new System.Drawing.Size(100, 26);
            this.tientucbb.TabIndex = 13;
            // 
            // tientulb
            // 
            this.tientulb.AutoSize = true;
            this.tientulb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tientulb.Location = new System.Drawing.Point(25, 39);
            this.tientulb.Name = "tientulb";
            this.tientulb.Size = new System.Drawing.Size(52, 18);
            this.tientulb.TabIndex = 14;
            this.tientulb.Text = "Giá từ";
            // 
            // dentienlb
            // 
            this.dentienlb.AutoSize = true;
            this.dentienlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dentienlb.Location = new System.Drawing.Point(156, 39);
            this.dentienlb.Name = "dentienlb";
            this.dentienlb.Size = new System.Drawing.Size(37, 18);
            this.dentienlb.TabIndex = 16;
            this.dentienlb.Text = "Đến";
            // 
            // dentiencbb
            // 
            this.dentiencbb.FormattingEnabled = true;
            this.dentiencbb.Items.AddRange(new object[] {
            "Chọn",
            "1.000.000",
            "1.500.000",
            "2.000.000",
            "2.500.000",
            "3.000.000",
            "3.500.000",
            "4.000.000"});
            this.dentiencbb.Location = new System.Drawing.Point(159, 59);
            this.dentiencbb.Name = "dentiencbb";
            this.dentiencbb.Size = new System.Drawing.Size(100, 26);
            this.dentiencbb.TabIndex = 15;
            // 
            // hangsaolb
            // 
            this.hangsaolb.AutoSize = true;
            this.hangsaolb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangsaolb.Location = new System.Drawing.Point(288, 39);
            this.hangsaolb.Name = "hangsaolb";
            this.hangsaolb.Size = new System.Drawing.Size(75, 18);
            this.hangsaolb.TabIndex = 18;
            this.hangsaolb.Text = "Hạng sao";
            // 
            // hangsaocbb
            // 
            this.hangsaocbb.FormattingEnabled = true;
            this.hangsaocbb.Items.AddRange(new object[] {
            "Chọn",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.hangsaocbb.Location = new System.Drawing.Point(291, 59);
            this.hangsaocbb.Name = "hangsaocbb";
            this.hangsaocbb.Size = new System.Drawing.Size(100, 26);
            this.hangsaocbb.TabIndex = 17;
            // 
            // thanhpholb
            // 
            this.thanhpholb.AutoSize = true;
            this.thanhpholb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhpholb.Location = new System.Drawing.Point(419, 39);
            this.thanhpholb.Name = "thanhpholb";
            this.thanhpholb.Size = new System.Drawing.Size(80, 18);
            this.thanhpholb.TabIndex = 20;
            this.thanhpholb.Text = "Thành phố";
            // 
            // thanhphotb
            // 
            this.thanhphotb.Location = new System.Drawing.Point(422, 59);
            this.thanhphotb.Name = "thanhphotb";
            this.thanhphotb.Size = new System.Drawing.Size(100, 26);
            this.thanhphotb.TabIndex = 21;
            // 
            // TimKiemKhachSan_Option
            // 
            this.TimKiemKhachSan_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.TimKiemKhachSan_Option.FlatAppearance.BorderSize = 0;
            this.TimKiemKhachSan_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.TimKiemKhachSan_Option.ForeColor = System.Drawing.Color.White;
            this.TimKiemKhachSan_Option.Location = new System.Drawing.Point(551, 57);
            this.TimKiemKhachSan_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TimKiemKhachSan_Option.Name = "TimKiemKhachSan_Option";
            this.TimKiemKhachSan_Option.Size = new System.Drawing.Size(100, 30);
            this.TimKiemKhachSan_Option.TabIndex = 22;
            this.TimKiemKhachSan_Option.Text = "Tìm Kiếm";
            this.TimKiemKhachSan_Option.UseVisualStyleBackColor = false;
            // 
            // QuayLaicl_Option
            // 
            this.QuayLaicl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.QuayLaicl_Option.FlatAppearance.BorderSize = 0;
            this.QuayLaicl_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.QuayLaicl_Option.ForeColor = System.Drawing.Color.White;
            this.QuayLaicl_Option.Location = new System.Drawing.Point(1147, 118);
            this.QuayLaicl_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.QuayLaicl_Option.Name = "QuayLaicl_Option";
            this.QuayLaicl_Option.Size = new System.Drawing.Size(100, 30);
            this.QuayLaicl_Option.TabIndex = 23;
            this.QuayLaicl_Option.Text = "Quay Lại";
            this.QuayLaicl_Option.UseVisualStyleBackColor = false;
            // 
            // dangxuatlink
            // 
            this.dangxuatlink.ActiveLinkColor = System.Drawing.Color.Black;
            this.dangxuatlink.AutoSize = true;
            this.dangxuatlink.DisabledLinkColor = System.Drawing.Color.Red;
            this.dangxuatlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangxuatlink.Location = new System.Drawing.Point(1206, 9);
            this.dangxuatlink.Name = "dangxuatlink";
            this.dangxuatlink.Size = new System.Drawing.Size(82, 20);
            this.dangxuatlink.TabIndex = 25;
            this.dangxuatlink.TabStop = true;
            this.dangxuatlink.Text = "Đăng xuất";
            this.dangxuatlink.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // timkiemkhachsangb
            // 
            this.timkiemkhachsangb.Controls.Add(this.tientucbb);
            this.timkiemkhachsangb.Controls.Add(this.tientulb);
            this.timkiemkhachsangb.Controls.Add(this.dentiencbb);
            this.timkiemkhachsangb.Controls.Add(this.dentienlb);
            this.timkiemkhachsangb.Controls.Add(this.TimKiemKhachSan_Option);
            this.timkiemkhachsangb.Controls.Add(this.hangsaocbb);
            this.timkiemkhachsangb.Controls.Add(this.thanhphotb);
            this.timkiemkhachsangb.Controls.Add(this.hangsaolb);
            this.timkiemkhachsangb.Controls.Add(this.thanhpholb);
            this.timkiemkhachsangb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemkhachsangb.Location = new System.Drawing.Point(44, 43);
            this.timkiemkhachsangb.Name = "timkiemkhachsangb";
            this.timkiemkhachsangb.Size = new System.Drawing.Size(685, 105);
            this.timkiemkhachsangb.TabIndex = 26;
            this.timkiemkhachsangb.TabStop = false;
            this.timkiemkhachsangb.Text = "TÌM KIẾM KHÁCH SẠN";
            // 
            // danhsachkhachsangb
            // 
            this.danhsachkhachsangb.Controls.Add(this.danhsachkhachsan);
            this.danhsachkhachsangb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachkhachsangb.Location = new System.Drawing.Point(44, 172);
            this.danhsachkhachsangb.Name = "danhsachkhachsangb";
            this.danhsachkhachsangb.Size = new System.Drawing.Size(1203, 495);
            this.danhsachkhachsangb.TabIndex = 27;
            this.danhsachkhachsangb.TabStop = false;
            this.danhsachkhachsangb.Text = "DANH SÁCH KHÁCH SẠN";
            // 
            // danhsachkhachsan
            // 
            this.danhsachkhachsan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.danhsachkhachsan.ColumnHeadersHeight = 30;
            this.danhsachkhachsan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tenKS,
            this.soSao,
            this.soNha,
            this.duong,
            this.quan,
            this.thanhPho,
            this.giaTB,
            this.moTa});
            this.danhsachkhachsan.Location = new System.Drawing.Point(11, 25);
            this.danhsachkhachsan.Name = "danhsachkhachsan";
            this.danhsachkhachsan.RowHeadersWidth = 90;
            this.danhsachkhachsan.Size = new System.Drawing.Size(1181, 459);
            this.danhsachkhachsan.TabIndex = 0;
            // 
            // DatPhongKhachSan_Option
            // 
            this.DatPhongKhachSan_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.DatPhongKhachSan_Option.FlatAppearance.BorderSize = 0;
            this.DatPhongKhachSan_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.DatPhongKhachSan_Option.ForeColor = System.Drawing.Color.White;
            this.DatPhongKhachSan_Option.Location = new System.Drawing.Point(1023, 118);
            this.DatPhongKhachSan_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DatPhongKhachSan_Option.Name = "DatPhongKhachSan_Option";
            this.DatPhongKhachSan_Option.Size = new System.Drawing.Size(100, 30);
            this.DatPhongKhachSan_Option.TabIndex = 28;
            this.DatPhongKhachSan_Option.Text = "Đặt Phòng";
            this.DatPhongKhachSan_Option.UseVisualStyleBackColor = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // tenKS
            // 
            this.tenKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenKS.HeaderText = "Tên khách sạn";
            this.tenKS.Name = "tenKS";
            this.tenKS.Width = 133;
            // 
            // soSao
            // 
            this.soSao.HeaderText = "Số sao";
            this.soSao.Name = "soSao";
            // 
            // soNha
            // 
            this.soNha.HeaderText = "Địa chỉ số";
            this.soNha.Name = "soNha";
            // 
            // duong
            // 
            this.duong.HeaderText = "Trên đường";
            this.duong.Name = "duong";
            // 
            // quan
            // 
            this.quan.HeaderText = "Thuộc quận";
            this.quan.Name = "quan";
            // 
            // thanhPho
            // 
            this.thanhPho.HeaderText = "Thành phố";
            this.thanhPho.Name = "thanhPho";
            // 
            // giaTB
            // 
            this.giaTB.HeaderText = "Giá cả";
            this.giaTB.Name = "giaTB";
            // 
            // moTa
            // 
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            // 
            // HotelSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.DatPhongKhachSan_Option);
            this.Controls.Add(this.danhsachkhachsangb);
            this.Controls.Add(this.timkiemkhachsangb);
            this.Controls.Add(this.dangxuatlink);
            this.Controls.Add(this.QuayLaicl_Option);
            this.Controls.Add(this.usernamelink);
            this.Name = "HotelSearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelSearching";
            this.timkiemkhachsangb.ResumeLayout(false);
            this.timkiemkhachsangb.PerformLayout();
            this.danhsachkhachsangb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachkhachsan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel usernamelink;
        private System.Windows.Forms.ComboBox tientucbb;
        private System.Windows.Forms.Label tientulb;
        private System.Windows.Forms.Label dentienlb;
        private System.Windows.Forms.ComboBox dentiencbb;
        private System.Windows.Forms.Label hangsaolb;
        private System.Windows.Forms.ComboBox hangsaocbb;
        private System.Windows.Forms.Label thanhpholb;
        private System.Windows.Forms.TextBox thanhphotb;
        private System.Windows.Forms.Button TimKiemKhachSan_Option;
        private System.Windows.Forms.Button QuayLaicl_Option;
        private System.Windows.Forms.LinkLabel dangxuatlink;
        private System.Windows.Forms.GroupBox timkiemkhachsangb;
        private System.Windows.Forms.GroupBox danhsachkhachsangb;
        private System.Windows.Forms.DataGridView danhsachkhachsan;
        private System.Windows.Forms.Button DatPhongKhachSan_Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSao;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn duong;
        private System.Windows.Forms.DataGridViewTextBoxColumn quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}