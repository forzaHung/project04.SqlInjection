/* FileName: Default.aspx.cs
Project Name: 
Date Created: 9/30/2014
Description: Auto-generated
Version: 1.0.0.0
Author:	Lê Thanh Tuấn - Khoa CNTT
Author Email: tuanitpro@gmail.com
Author Mobile: 0976060432
Author URI: http://tuanitpro.com
License: 

*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLInjection
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string stringConnection = @"Data Source=HUNG-PC\HUNG;Initial Catalog=SQLInjection;Integrated Security=True";
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int ok = -1;
            SqlConnection sqlConn = new SqlConnection(stringConnection);
            sqlConn.Open();
            //string query = "Select top 1 * from Member where UserName = @UserName AND password = @Password";
            string query = "Select top 1 * from Member where UserName = '" + UserName.Text + "' AND Password = '"+Password.Text+"'";
            SqlCommand sqlCmd = new SqlCommand(query, sqlConn);
            //SqlParameter param = new SqlParameter("@UserName", UserName.Text);
            //SqlParameter param1 = new SqlParameter("@Password", Password.Text);
            //sqlCmd.Parameters.Add(param);
            //sqlCmd.Parameters.Add(param1);


            SqlDataReader reader = sqlCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (reader.HasRows)
                ok = 1;
            else ok = -1;
            sqlConn.Close();
            if (ok > 0)
            {
                Session["LoginOK"] = true;
                Response.Redirect("Member.aspx");
            }
            else
                FailureText.Text = "Đăng nhập thất bại!!!";
        }         
    }
}