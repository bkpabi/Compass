using System;
using System.Web.Security;
namespace Compass.UI.WebApp.Accounts
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Clear();
            Response.Redirect(Request.UrlReferrer.ToString());
        }
    }
}