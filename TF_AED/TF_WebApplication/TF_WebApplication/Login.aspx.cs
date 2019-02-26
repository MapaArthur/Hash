using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TF_WebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
            {
                Response.Redirect("Default.aspx");                
            }
            else
            {
                Session["Login"] = null; //defini uma sessão de nome login
                if (Request.Cookies["username"] != null)
                {
                    txt_userName.Text = Request.Cookies["username"].Value;
                }
            }

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (VerificaCredenciais(txt_userName.Text, txt_userPassword.Text))
            {
                Response.Cookies.Add(new HttpCookie("username", txt_userName.Text));
                Session.Add("Login", true);
                Response.Redirect("Default.aspx");
                //btn_login.PostBackUrl = "~/Default.aspx";
            }
            else
            {
                lbl_CredencialIncorreta.Visible = true;
                txt_userPassword.Text = "";
            }
           
           
        }
        private Boolean VerificaCredenciais(string user, string password)
        {
            string filePath = HostingEnvironment.MapPath("~/App_Data/Table_login.csv");
            if (File.Exists(filePath))
            {

            string[] aux;
                using (StreamReader arq = new StreamReader(filePath))
                {
                    while (!arq.EndOfStream)
                    {
                        aux = arq.ReadLine().Split(';');
                        if (user == aux[0] && password == aux[1])
                        {
                            return true;
                        }
                    }
                    arq.Close();
                }
                return false;
            }
            else throw new FileNotFoundException("O Arquivo '~/App_Data/Table_login.csv' não existe ");                
                         
        }
    }
}