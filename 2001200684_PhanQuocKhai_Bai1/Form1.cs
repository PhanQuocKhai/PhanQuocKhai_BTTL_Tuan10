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

namespace _2001200684_PhanQuocKhai_Bai1
{
    public partial class Form1 : Form
    {
        private SqlConnection consql;
        private SqlDataAdapter myAdapt;
        private SqlCommand com;
        private DataSet ds;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
            consql = new SqlConnection("DataSource=A209PC46;Initial Catalog =QLySinhVien;Intergrated Security=true");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            var sql = "Select * from CRUD";
            com = new SqlCommand(sql, consql);
            consql.Open();
            com.ExecuteNonQuery();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT MaKhoa FROM Khoa";
            SqlCommand command = new SqlCommand(query, consql);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            cboKhoa.DataSource = dataTable;
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DisplayMember = "MaKhoa";

        }
       
    }
}
