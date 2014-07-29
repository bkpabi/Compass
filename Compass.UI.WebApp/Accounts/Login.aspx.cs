using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Compass.UI.WebApp.Accounts
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Newtonsoft.Json;
    using Compass.Business.Entities;
    using System.Threading.Tasks;
    using System.Web.Security;
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signin_Click(object sender, EventArgs e)
        {
            ValidateUser(userName.Text, password.Text).Wait();
        }

        public async Task ValidateUser(string userName,string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["apiURI"].ToString());

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/User/AuthenticateUser/"+userName+"/"+password).Result;
                if (response.IsSuccessStatusCode)
                {
                    var users = await response.Content.ReadAsAsync<UserDetailDTO>();
                    if (users != null)
                    {
                        // Success
                        FormsAuthentication.SetAuthCookie(userName,remember.Checked);
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, userName, DateTime.Now, DateTime.Now.AddMinutes(30), remember.Checked, users.RoleName);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                        Response.Cookies.Add(cookie);
                        string returnURL =string.Empty;
                        switch (users.RoleName)
                        {
                            case "Admin":
                                //returnURL = "/Admin/Overview.aspx";
                                returnURL = "/TeamLead/Overview.aspx";
                                break;
                            case "TeamLead":
                                returnURL = "/TeamLead/Overview.aspx";
                                break;
                            case "Developer":
                                returnURL = "/Developer/Overview.aspx";
                                break;
                            case "QA":
                                returnURL = "/QA/Overview.aspx";
                                break;
                            default:
                                break;
                        }

                        Response.Redirect(returnURL);

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}