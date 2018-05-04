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
    public partial class InvoiceAdding : Form
    {
        public InvoiceAdding()
        {
            InitializeComponent();
           
        }
        private void loadCombobox(SqlConnection conn)
        {
            string query = "SELECT maDP FROM DatPhong";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "maDP");
            comboBox1.DisplayMember = "maDP";
            comboBox1.DataSource = ds.Tables["maDP"];
        }
        private void loadTable()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K61FV16\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=SSPI;"))
            {
                try
                {
                    conn.Open();
                    //chon tat ca cot trong HoaDon
                    String query= "SELECT * FROM HoaDon";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    DataTable dt = new DataTable();
                    SqlDataReader rd = cmd.ExecuteReader();
                    //dat ten cac cot
                    dt.Columns.Add("Mã hóa đơn", typeof(String));
                    dt.Columns.Add("Ngày thanh toán", typeof(String));
                    dt.Columns.Add("Tổng tiền", typeof(String));
                    dt.Columns.Add("Mã đặt phòng", typeof(String));
                    DataRow row = null;
                    //đọc dữ liệu them vao tung cot tuong ung
                    while (rd.Read())
                    {
                        row = dt.NewRow();
                        row["Mã hóa đơn"] = rd["maHD"];
                        row["Ngày thanh toán"] = rd["ngayThanhToan"];
                        row["Tổng tiền"] = rd["tongTien"];
                        row["Mã đặt phòng"] = rd["maDP"];
                        dt.Rows.Add(row);
                    }
                    rd.Close();
                    conn.Close();
                    danhsachhoadon.DataSource = dt;
                    //chinh do rong cac cot
                    danhsachhoadon.Columns[0].Width = 150;
                    danhsachhoadon.Columns[1].Width = 200;
                    danhsachhoadon.Columns[2].Width = 150;
                    danhsachhoadon.Columns[3].Width = 150;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error!");
                }
            }
        }
       
        private void ngaythanhtoanlb_Click(object sender, EventArgs e)
        {

        }

        private void ngaythanhtoandt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mahdtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemHoaDon_Option_Click(object sender, EventArgs e)
        {
            try
            {
                //ket noi database
                SqlDataReader rd = null;
                String connString = @"Data Source=DESKTOP-K61FV16\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(connString); 
                //ket noi command den procedure muon xai
                SqlCommand cmd = new SqlCommand("SP_CreateBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them bien maDP cho procedure theo combobox
                cmd.Parameters.Add(new SqlParameter("@maDP", Int32.Parse(comboBox1.Text)));
                conn.Open();
                //thuc thi
                rd = cmd.ExecuteReader();
                //load lai bang
                loadTable();
                conn.Close();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceAdding_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K61FV16\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=SSPI;"))
            {
                try
                {
                    conn.Open();
                    loadCombobox(conn);
                    loadTable();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void danhsachhoadon_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void danhsachhoadon_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void SuaHoaDon_Option_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K61FV16\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=SSPI;"))
            {
                try
                {
                    //query de update
                    
                    String query = "UPDATE HoaDon SET ngayThanhToan=@ngayThanhToan, tongTien=@tongTien where maDP=@maDP ";
                    //mo ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maDP", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@maHD", mahdtb.Text);
                    //doi ra ngay
                    DateTime ngaythanhtoan = DateTime.Parse(ngaythanhtoandt.Text);
                    cmd.Parameters.AddWithValue("@ngayThanhToan", ngaythanhtoan);
                    cmd.Parameters.AddWithValue("@tongTien", tongtientb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    conn.Close();
                    //Reset lai bang sau khi update
                    loadTable();

                }
                catch (Exception ex)
                {
                    throw ex;
                    MessageBox.Show("Error!");
                }
            }
        }

        private void XoaHoaDon_Option_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K61FV16\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=SSPI;"))
            {
                try
                {
                    //query de delete

                    String query = "DELETE FROM HoaDon WHERE maDP=@maDP";
                    //mo ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // nhan gia tri MaDP tu Combobox
                    cmd.Parameters.AddWithValue("@maDP", Int32.Parse(comboBox1.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    
                    conn.Close();
                    //Reset lai bang sau khi update
                    loadTable();

                }
                catch (Exception ex)
                {
                    throw ex;
                    MessageBox.Show("Error!");
                }
            }
        }

        private void danhsachhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Chon cac dong cua bang theo click chuot
                DataGridViewRow row = this.danhsachhoadon.Rows[e.RowIndex];
                mahdtb.Text = row.Cells[0].Value.ToString();
                ngaythanhtoandt.Text = row.Cells[1].Value.ToString();
                tongtientb.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
