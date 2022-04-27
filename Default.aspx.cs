using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Configuration;
using System.Data;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["postgrePBO"].ToString();

            //cmd = new NpgsqlCommand();
            //cmd.Connection = conn;

            cmd = conn.CreateCommand();

            try
            {
                conn.Open();

                cmd.CommandText = "SELECT * FROM employees";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                cmd.Dispose();
                conn.Close();

                EmployeeGridView.DataSource = dt;
                EmployeeGridView.DataBind();

            } catch (Exception ex) { }
        }
    }
}