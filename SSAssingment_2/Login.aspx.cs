using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.GoogleAPI;
using System.Web.Script.Serialization;
using System.Configuration;

namespace SSAssingment_2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GoogleConnect.ClientId = ConfigurationManager.AppSettings["ClientId"];
            GoogleConnect.ClientSecret = ConfigurationManager.AppSettings["ClientSecret"];
            GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];
            GoogleConnect.API = EnumAPI.Drive;
            
            if (!string.IsNullOrEmpty(Request.QueryString["code"]))
            {
                string code = Request.QueryString["code"];
                Session["Token"] = code;
                Response.Redirect("FileUpload.aspx");
            }
            if (Request.QueryString["error"] == "access_denied")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            GoogleConnect.Authorize("https://www.googleapis.com/auth/drive.file");
        }
    }
}