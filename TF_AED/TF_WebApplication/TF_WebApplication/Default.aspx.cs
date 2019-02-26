using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TF_WebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Response.Redirect("Login.aspx");                
            }
            //Label1.Text = Request.Form["txt_userName"];
            //Label2.Text = Request.Form["txt_userPassword"];
            //Label1.Text = ((TextBox)Page.PreviousPage.FindControl("txt_userName")).Text;
        }

        protected void btn_sair_Click(object sender, EventArgs e)
        {
            //Session.Remove("Login");
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}