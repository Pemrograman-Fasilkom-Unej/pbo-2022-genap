using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace WebApplication3
{
    public partial class Add : System.Web.UI.Page
    {

        NpgsqlConnection conn;
        NpgsqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["postgrePBO"].ToString();
            cmd = conn.CreateCommand();
        }

        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            string firstname = inputFirstname.Text;
            string lastname = inputLastname.Text;
            string email = inputEmail.Text;

            if (firstname == "" || lastname == "" || email == "")
            {
                lblmsg.Text = "Harap isi semua kolom";
                lblmsg.ForeColor = System.Drawing.Color.Red;
                return;
            }

            conn.Open();

            cmd.CommandText = "INSERT INTO employees (firstname, lastname, email) VALUES (@firstname, @lastname, @email)";
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

            Response.Redirect("~/Default");
        }
    }
}