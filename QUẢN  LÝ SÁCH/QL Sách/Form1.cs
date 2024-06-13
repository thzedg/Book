using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;

namespace QL_Sách
{
    public partial class Form1 : Form
       
    {
        string connect = @"Data Source=DESKTOP-GIKJGC8; Initial Catalog = QLSach; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(connect);
            con.Open();
            Hienthi();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        public void Hienthi()
        {
            string sqlSElECT = "SELECT * FROM QLySach";
            SqlCommand cmd = new SqlCommand(sqlSElECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsSanPham.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT into QLySach(maSach,tenSach,nhaXuatBan,namXuatBan,giaTien) values ('" + txtMa.Text + "', N'" + txtTen.Text + "',N'" + txtNhXB.Text + "','" + txtNaXB.Text + "','" + txtGia.Text +"')  ";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsSanPham.DataSource = dt;
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlUPDATE = "UPDATE QLySach SET   tenSach = N'" + txtTen.Text + "',nhaXuatBan = N'" + txtNhXB.Text + "',namXuatBan = '" + txtNaXB.Text + "',giaTien = '" + txtGia.Text + "' where maSach  = '" + txtMa.Text + "'  ";
            SqlCommand cmd = new SqlCommand(sqlUPDATE, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsSanPham.DataSource = dt;
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDEL = "DELETE FROM QLySACH WHERE maSach = ('" +txtMa.Text+"') ";
            SqlCommand cmd = new SqlCommand(sqlDEL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsSanPham.DataSource = dt;
            Hienthi();
        }
    }
}
