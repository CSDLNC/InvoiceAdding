using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class RoomSetting : Form
    {
        public RoomSetting()
        {
            InitializeComponent();
        }
        //load thong tin ten khach san vao combox1
        private void loadKhachSan(SqlConnection conn)
        {
            //
            string query = "SELECT tenKS FROM KhachSan";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tenKS");
            comboBox1.DisplayMember = "tenKS";
            comboBox1.DataSource = ds.Tables["tenKS"];
        }
        //load thong tin ten loai phong vao combox2
        private void loadLoaiPhong(SqlConnection conn)
        {
            string query = "SELECT tenLoaiPhong FROM LoaiPhong";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tenLoaiPhong");
            comboBox2.DisplayMember = "tenLoaiPhong";
            comboBox2.DataSource = ds.Tables["tenLoaiPhong"];
        }
        private void loadTable(SqlConnection conn)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_EmptyRoomStatistics", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@hotelname",comboBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@typeofroomname",comboBox2.Text));
            DateTime ngay = DateTime.Parse(dateTimePicker1.Text);
            cmd.Parameters.Add(new SqlParameter("@date", ngay));
            SqlDataReader rd = cmd.ExecuteReader();
                dt.Columns.Add("Mã khách sạn", typeof(String));
                dt.Columns.Add("Tên khách sạn", typeof(String));
                dt.Columns.Add("Mã loại phòng", typeof(String));
                dt.Columns.Add("Tên loại phòng", typeof(String));
                dt.Columns.Add("Thành phố", typeof(String));
                dt.Columns.Add("Số sao", typeof(String));
                dt.Columns.Add("Số phòng trống", typeof(String));
      
                DataRow row = null;
                //đọc dữ liệu từng dòng
                while (rd.Read())
                {
                    row = dt.NewRow();
                    row["Mã khách sạn"] = rd["maKS"];
                    row["Tên khách sạn"] = rd["tenKS"];
                    row["Mã loại phòng"] = rd["maLoaiPhong"];
                    row["Tên loại phòng"] = rd["tenLoaiPhong"];
                    row["Thành phố"] = rd["thanhPho"];
                    row["Số sao"] = rd["soSao"];
                    row["Số phòng trống"] = rd["soPhongTrong"];
                    dt.Rows.Add(row);
                }
                rd.Close();
            danhsachphongtrong.DataSource = dt;
            danhsachphongtrong.Columns[1].Width = 150;
            danhsachphongtrong.Columns[2].Width = 200;
            danhsachphongtrong.Columns[3].Width = 150;
            danhsachphongtrong.Columns[4].Width = 150;
            danhsachphongtrong.Columns[5].Width = 200;
            danhsachphongtrong.Columns[6].Width = 200;
        }

        private void RoomSetting_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K61FV16\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=SSPI;"))
            {
                try
                {
                    conn.Open();
                    loadKhachSan(conn);
                    loadLoaiPhong(conn);
                    loadTable(conn);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                    MessageBox.Show("Error!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K61FV16\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=SSPI;"))
            {
                try
                {
                    conn.Open();
                    loadTable(conn);
                }
                catch (Exception ex)
                {
                    throw ex;
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}
