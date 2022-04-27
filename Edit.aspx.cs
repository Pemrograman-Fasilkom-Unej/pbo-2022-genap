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
    public partial class Edit : System.Web.UI.Page
    {

        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        int employeeId;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["postgrePBO"].ToString();
            cmd = conn.CreateCommand();
            employeeId = int.Parse(Request.QueryString["id"]);

            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            conn.Open();
            cmd.CommandText = "SELECT * FROM employees WHERE id = @id";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", employeeId);

            NpgsqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                inputID.Text = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                inputFirstname.Text = reader.GetString(reader.GetOrdinal("firstname"));
                inputLastname.Text = reader.GetString(reader.GetOrdinal("lastname"));
                inputEmail.Text = reader.GetString(reader.GetOrdinal("email"));

                cmd.Dispose();
                conn.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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

            cmd.CommandText = "UPDATE employees SET firstname=@firstname, lastname=@lastname, email=@email WHERE id=@id";
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@id", employeeId);
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