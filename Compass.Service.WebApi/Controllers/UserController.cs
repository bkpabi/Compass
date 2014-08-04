namespace Compass.Service.WebApi.Controllers
{
    using Compass.Business.Components;
    using Compass.Business.Entities;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {
        [HttpPost]
        public int CreateNewUser(UserDetailDTO userDetails)
        {
            UserManager um = new UserManager();
            string message = string.Empty;
            int newUserId = um.CreateNewUser(userDetails, out message);
            return newUserId;
            /*if (message != string.Empty)
            {
                throw n
            }
            else
            {
                return newUserId;
            }*/
        }

        [HttpGet]
        public IEnumerable<UserDetailDTO> GetAllActiveUser()
        {
            UserManager um = new UserManager();
            return um.GetAllActiveUser();
        }
        
        [HttpPost]
        public HttpResponseMessage EditUserDetails(UserDetailDTO userDetails)
        {
            UserManager um = new UserManager();
            string message = string.Empty;
            if(um.EditUserDetails(userDetails,out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpPut]
        public HttpResponseMessage ChangePassword(string userId, string oldPassword, string newPassword)
        {

            UserManager um = new UserManager();
            string message = string.Empty;
            if (um.ChangePassword(userId, oldPassword, newPassword, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [Route("api/User/AuthenticateUser/{email}/{password}")]
        [HttpGet]
        public HttpResponseMessage AuthenticateUser(string email, string password)
        {
            UserManager um = new UserManager();
            string message = string.Empty;
            UserDetailDTO user = um.AuthenticateUser(email, password, out message);
            if (message == string.Empty)
            {
                return Request.CreateResponse(HttpStatusCode.OK,user);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpPost]
        public HttpResponseMessage UnlockUser(string userId)
        {
            UserManager um = new UserManager();
            string message = string.Empty;
            if (um.UnlockUser(userId, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpPost]
        public HttpResponseMessage ActivateUser(string userId)
        {
            UserManager um = new UserManager();
            string message = string.Empty;
            if (um.ActivateUser(userId, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
    }
}