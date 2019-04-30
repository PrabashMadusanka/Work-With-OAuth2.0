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
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*GoogleConnect.ClientId= ConfigurationManager.AppSettings["ClientId"];
            GoogleConnect.ClientSecret= ConfigurationManager.AppSettings["ClientSecret"];
            GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];
            GoogleConnect.API = EnumAPI.Drive;
            if (!string.IsNullOrEmpty(Request.QueryString["code"]))
            {
                string code = Request.QueryString["code"];
                string json = GoogleConnect.PostFile(code, (HttpPostedFile)Session["File"], Session["Description"].ToString());
                GoogleDriveFile file = (new JavaScriptSerializer()).Deserialize<GoogleDriveFile>(json);
                tblFileDetails.Visible = true;
                lblTitle.Text = file.Title;
                lblId.Text = file.Id;
                imgIcon.ImageUrl = file.IconLink;
                lblCreatedDate.Text = file.CreatedDate.ToString();
                lnkDownload.NavigateUrl = file.WebContentLink;
                if (!string.IsNullOrEmpty(file.ThumbnailLink))
                {
                    rowThumbnail.Visible = true;
                    imgThumbnail.ImageUrl = file.ThumbnailLink;
                }
            }
            if (Request.QueryString["error"] == "access_denied")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
            }*/
        }

        protected void UploadFile(object sender, EventArgs e)
        {
            Session["File"] = FileUpload1.PostedFile;
            Session["Description"] = txtDescription.Text;
            //GoogleConnect.Authorize("https://www.googleapis.com/auth/drive.file");

            string code = Session["Token"].ToString();
            string json = GoogleConnect.PostFile(code, (HttpPostedFile)Session["File"], Session["Description"].ToString());
            GoogleDriveFile file = (new JavaScriptSerializer()).Deserialize<GoogleDriveFile>(json);
            tblFileDetails.Visible = true;
            lblTitle.Text = file.Title;
            lblId.Text = file.Id;
            imgIcon.ImageUrl = file.IconLink;
            lblCreatedDate.Text = file.CreatedDate.ToString();
            lnkDownload.NavigateUrl = file.WebContentLink;
            if (!string.IsNullOrEmpty(file.ThumbnailLink))
            {
                rowThumbnail.Visible = true;
                imgThumbnail.ImageUrl = file.ThumbnailLink;
            }
        }
    }

    public class GoogleDriveFile
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string OriginalFilename { get; set; }
        public string ThumbnailLink { get; set; }
        public string IconLink { get; set; }
        public string WebContentLink { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}