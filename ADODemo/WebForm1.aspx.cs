using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ADODemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string str = @"Data Source=DESKTOP-JG8PD29\SQLEXPRESS;Initial Catalog=AdoDemo;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            Txtid.Text = "";
            Txtname.Text = "";
            Txtemail.Text = "";
            Txtaddress.Text = "";
        }

        protected void Btncreate_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Student(Name,Email,Address)values(@Name,@Email,@Address)",con);
                cmd.Parameters.AddWithValue("@Name", Txtname.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", Txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", Txtaddress.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Information Submitted')</script>");
                clear();
                
            }

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Student set Name=@Name,Email=@Email,Address=@Address where Id='"+Txtid.Text+"'", con);
                cmd.Parameters.AddWithValue("@Name", Txtname.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", Txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", Txtaddress.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Information Submitted')</script>");
                clear();

            }
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student where Id like'" + Txtid.Text + "%'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    Txtname.Text = sdr.GetValue(1).ToString();
                    Txtemail.Text = sdr.GetValue(2).ToString();
                    Txtaddress.Text = sdr.GetValue(3).ToString();
                }
                con.Close();

                
            }
        }

        protected void Btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Student where Id like'" + Txtid.Text + "'",con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Information Deleted')</script>");
                clear();
            }
        }

        protected void Btndisplay_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student",con);
                SqlDataReader sdr = cmd.ExecuteReader();
                GridView1.DataSource = sdr;
                GridView1.DataBind();
                con.Close();
            }

        }
    }
}