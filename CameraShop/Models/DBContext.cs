using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace CameraShop.Models
{
    public partial class DBContext : DbContext
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string str = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        public DBContext()
            : base("name=strconnect")
        {
            con = new SqlConnection(str);
        }
        public DataTable readData(string query)
        {
            con.Open();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void writeData(string query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.Anh)
                .IsUnicode(false);
        }
    }
}
