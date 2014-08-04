using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Compass.Service.WebApi.Controllers
{
    using Compass.Business.Entities;
    using Compass.Business.Components;
    using System.Web.Cors;
    using System.Web.Http.Cors;
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class IssueController : ApiController
    {
        #region-- Activity Type
        [HttpPost]
        public int AddNewActivityType(ActivityMasterDTO newActivityType)
        {
            IssueManager manager = new IssueManager();
            return manager.AddNewActivityType(newActivityType);
        }

        [HttpPut]
        public HttpResponseMessage EditActivityType(ActivityMasterDTO ActivityType)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if(manager.EditActivityType(ActivityType,out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteActivityType(int activityTypeId)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.DeleteActivityType(activityTypeId, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpGet]
        public IEnumerable<ActivityMasterDTO> GetAllIssueActivityType()
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllIssueActivityType();
        }
        #endregion

        #region-- Category Type
        [HttpPost]
        public int AddNewIssueCategoryType(CategoryMaster newIssueCategory)
        {
            IssueManager manager = new IssueManager();
            return manager.AddNewIssueCategoryType(newIssueCategory);
        }

        [HttpPut]
        public HttpResponseMessage EditIssueCategoryType(CategoryMaster CategoryType)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if(manager.EditIssueCategoryType(CategoryType,out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
        
        [HttpDelete]
        public HttpResponseMessage DeleteIssueCategoryType(int categoryTypeId)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.DeleteIssueCategoryType(categoryTypeId, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,message);
            }
        }

        [Route("api/Issue/GetAllIssueCategoryType")]
        [HttpGet]
        public IEnumerable<CategoryMaster> GetAllIssueCategoryType()
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllIssueCategoryType();
        }
        #endregion

        #region-- Status Type
        [HttpPost]
        public int AddNewIssueStatusType(IssueStatusDTO newStatusType)
        {
            IssueManager manager = new IssueManager();
            return manager.AddNewIssueStatusType(newStatusType);
        }
        [HttpPut]
        public HttpResponseMessage EditIssueSatusType(IssueStatusDTO statusType)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.EditIssueSatusType(statusType, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIssueStatusType(int statusTypeId)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.DeleteIssueStatusType(statusTypeId, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
        [HttpGet]
        public IEnumerable<IssueStatusDTO> GetAllIssueStatusType()
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllIssueStatusType();
        }
        #endregion

        #region-- Issue
        [Route("api/Issue/AddNewIssue")]
        [HttpPost]
        public int AddNewIssue(IssueDTO newIssueDetails)
        {
            IssueManager manager = new IssueManager();
            newIssueDetails.CategoryId = 1; // By default the issue will be of type Need to work
            newIssueDetails.StatusId = 1;
            newIssueDetails.CreatedOn = DateTime.Now;
            //return 1;
            return manager.AddNewIssue(newIssueDetails);
        }
        [HttpPut]
        public HttpResponseMessage EditIssueDetails(IssueDTO issueDetails)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.EditIssueDetails(issueDetails, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteIssueById(int issueId)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.DeleteIssueById(issueId, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
        [Route("api/Issue/GetAllIssuesByProject/{projectName}")]
        [HttpGet]
        public IEnumerable<IssueDTO> GetAllIssuesByProject(string projectName)
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllIssuesByProject(projectName);
        }
        [Route("api/Issue/GetIssueDetailsById/{issueId}")]
        [HttpGet]
        public IssueDTO GetIssueDetailsById(int issueId)
        {
            IssueManager manager = new IssueManager();
            return manager.GetIssueDetailsById(issueId);
        }
        [HttpGet]
        public IEnumerable<IssueDTO> GetAllIssueByCategory(int categoryType)
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllIssueByCategory(categoryType);
        }
        
        [HttpGet]
        public IEnumerable<IssueDTO> GetAllIssueByDate(DateTime date)
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllIssueByDate(date);
        }

        public IEnumerable<IssueDTO> GetIssueByFilterCondition(string filter)
        {
            List<IssueDTO> issuesCollection = new List<IssueDTO>();
            switch (filter)
            {
                case "Reopen Issue":
                    return issuesCollection;
                case "This weeks issues":
                    return issuesCollection;
                case "All":
                    return issuesCollection;
                default:
                    throw new ArgumentException("Given filter condition is not supported.");
            }
        }
        #endregion

        #region-- Issue Assignment
        [HttpPost]
        public HttpResponseMessage AssignIssue(IssueAssignmentDTO issueAssignment)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.AssignIssue(issueAssignment, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
        [HttpPut]
        public HttpResponseMessage EditAssignedIssue(IssueAssignmentDTO issueAssignment)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.AssignIssue(issueAssignment, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteAssignedIssue(int issueId)
        {
            string message = string.Empty;
            IssueManager manager = new IssueManager();
            if (manager.DeleteAssignedIssue(issueId, out message))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }
        [HttpGet]
        public IEnumerable<IssueAssignmentDTO> GetAllIssuesAssignedToAUser(string userId)
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllIssuesAssignedToAUser(userId);
        }
        #endregion

        #region-- Activity
        [HttpPost]
        public int AddNewIssueActivity(IssueActivityDTO newActivity)
        {
            IssueManager manager = new IssueManager();
            return manager.AddNewIssueActivity(newActivity);
        }
        [HttpGet]
        public IEnumerable<IssueActivityDTO> GetAllActivityByIssue(int issueId)
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllActivityByIssue(issueId);
        }
        [HttpGet]
        public IEnumerable<IssueActivityDTO> GetAllActivityByUser(string userId)
        {
            IssueManager manager = new IssueManager();
            return manager.GetAllActivityByUser(userId);
        }
        #endregion

        #region--Tenent
        [Route("api/Issue/GetTenantByProject/{ProjectName}")]
        [HttpGet]
        public IEnumerable<TenantMasterDTO> GetTenantByProject(string ProjectName)
        {
            IssueManager manager = new IssueManager();
            return manager.GetTenantsByProject(ProjectName).ToList();
        }
        #endregion
    }
}