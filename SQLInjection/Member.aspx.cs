
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLInjection
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoginOK"] == null)
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        string stringConnection = @"Data Source=HUNG-PC\HUNG;Initial Catalog=SQLInjection;Integrated Security=True";
        protected void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(stringConnection);
            sqlConn.Open();
            string query = "Select * from Member where UserName = '" + txtQuery.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(query, sqlConn);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            sqlConn.Close();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}