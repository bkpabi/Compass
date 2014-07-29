using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compass.Business.Components
{
    using Compass.DataModel;
    using Compass.Business.Entities;
    public class IssueManager
    {
        #region--Issue Activity
        public int AddNewActivityType(ActivityMasterDTO newActivityType)
        {
            if (newActivityType == null)
	        {
                throw new ArgumentNullException("newActivityType", "Please provide activity details");
	        }

            using (var compassContext = new CompassEntities())
            {
                var dbActivity = new CMP_ActivityMaster();
                dbActivity.ActivityName = newActivityType.ActivityName;
                dbActivity.CreatedBy = newActivityType.CreatedBy;
                dbActivity.CreatedOn = newActivityType.CreatedOn;
                compassContext.CMP_ActivityMaster.Add(dbActivity);
                compassContext.SaveChanges();
                return dbActivity.Id;
            }
        }

        public bool EditActivityType(ActivityMasterDTO ActivityType,out string message)
        {
            message = string.Empty;
            if (ActivityType == null)
            {
                message = "ActivityType is blank, Please provide activity details";
                return false;
            }

            using (var compassContext = new CompassEntities())
            {
                var dbActivity = compassContext.CMP_ActivityMaster.FirstOrDefault(e => e.Id == ActivityType.Id);
                if (dbActivity == null)
                {
                    message = "Activity type donot exists";
                    return false;
                }
                else
                {
                    dbActivity.ModifiedBy = ActivityType.ModifiedBy;
                    dbActivity.ModifiedOn = ActivityType.ModifiedOn;
                    dbActivity.ActivityName = ActivityType.ActivityName;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteActivityType(int activityTypeId, out string message)
        {
            message = string.Empty;
            using (var compassContext = new CompassEntities())
            {
                var dbActivity = compassContext.CMP_ActivityMaster.FirstOrDefault(e => e.Id == activityTypeId);
                if (dbActivity == null)
                {
                    message = "Activity type donot exists";
                    return false;
                }
                else
                {
                    // TODO : Check if the activity is used in any issue
                    compassContext.CMP_ActivityMaster.Remove(dbActivity);
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public IEnumerable<ActivityMasterDTO> GetAllIssueActivityType()
        {
            using (var compassContext = new CompassEntities())
            {
                List<ActivityMasterDTO> activityTypeCollection = new List<ActivityMasterDTO>();
                var dbActivities = compassContext.CMP_ActivityMaster.ToList();
                foreach (var item in dbActivities)
                {
                    ActivityMasterDTO activity = new ActivityMasterDTO();
                    activity.ActivityName = item.ActivityName;
                    activity.CreatedBy = item.CreatedBy;
                    activity.CreatedOn = item.CreatedOn;
                    activity.Id = item.Id;
                    activity.ModifiedBy = item.ModifiedBy;
                    activity.ModifiedOn = item.ModifiedOn;
                    activityTypeCollection.Add(activity);
                }

                return activityTypeCollection;
            }
        }
        #endregion

        #region--Issue Category
        public int AddNewIssueCategoryType(CategoryMaster newIssueCategory)
        {
            if (newIssueCategory == null)
            {
                throw new ArgumentNullException("newIssueCategory", "Please provide category details");
            }

            using (var compassContext = new CompassEntities())
            {
                var dbCategory = new CMP_CategoryMaster();
                dbCategory.CategoryName = newIssueCategory.CategoryName;
                dbCategory.CreatedBy = newIssueCategory.CreatedBy;
                dbCategory.CreatedOn = newIssueCategory.CreatedOn;
                compassContext.CMP_CategoryMaster.Add(dbCategory);
                compassContext.SaveChanges();
                return dbCategory.Id;
            }
        }
        public bool EditIssueCategoryType(CategoryMaster CategoryType, out string message)
        {
            message = string.Empty;
            if (CategoryType == null)
            {
                message = "CategoryType is blank, Please provide activity details";
                return false;
            }

            using (var compassContext = new CompassEntities())
            {
                var dbCategory = compassContext.CMP_CategoryMaster.FirstOrDefault(e => e.Id == CategoryType.Id);
                if (dbCategory == null)
                {
                    message = "Category type donot exists";
                    return false;
                }
                else
                {
                    dbCategory.ModifiedBy = CategoryType.ModifiedBy;
                    dbCategory.ModifiedOn = CategoryType.ModifiedOn;
                    dbCategory.CategoryName = CategoryType.CategoryName;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }
        public bool DeleteIssueCategoryType(int categoryTypeId, out string message)
        {
            message = string.Empty;
            using (var compassContext = new CompassEntities())
            {
                var dbCategory = compassContext.CMP_CategoryMaster.FirstOrDefault(e => e.Id == categoryTypeId);
                if (dbCategory == null)
                {
                    message = "Category type donot exists";
                    return false;
                }
                else
                {
                    // TODO : Check if the category is used in any issue
                    compassContext.CMP_CategoryMaster.Remove(dbCategory);
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }
        public IEnumerable<CategoryMaster> GetAllIssueCategoryType()
        {
            using (var compassContext = new CompassEntities())
            {
                List<CategoryMaster> categoryTypeCollection = new List<CategoryMaster>();
                var dbCategories = compassContext.CMP_CategoryMaster.ToList();
                foreach (var item in dbCategories)
                {
                    CategoryMaster category = new CategoryMaster();
                    category.CategoryName = item.CategoryName;
                    category.CreatedBy = item.CreatedBy;
                    category.CreatedOn = item.CreatedOn;
                    category.Id = item.Id;
                    category.ModifiedBy = item.ModifiedBy;
                    category.ModifiedOn = item.ModifiedOn;
                    categoryTypeCollection.Add(category);
                }

                return categoryTypeCollection;
            }
        }
        #endregion

        #region-- Issue Status
        public int AddNewIssueStatusType(IssueStatusDTO newStatusType)
        {
            if (newStatusType == null)
            {
                throw new ArgumentNullException("newStatusType", "Please provide status details");
            }

            using (var compassContext = new CompassEntities())
            {
                var dbStatus = new CMP_IssueStatusMaster();
                dbStatus.IssueStatus = newStatusType.IssueStatus;
                dbStatus.CreatedBy = newStatusType.CreatedBy;
                dbStatus.CreatedOn = newStatusType.CreatedOn;
                compassContext.CMP_IssueStatusMaster.Add(dbStatus);
                compassContext.SaveChanges();
                return dbStatus.Id;
            }
        }

        public bool EditIssueSatusType(IssueStatusDTO statusType, out string message)
        {
            message = string.Empty;
            if (statusType == null)
            {
                message = "IssueType is blank, Please provide activity details";
                return false;
            }

            using (var compassContext = new CompassEntities())
            {
                var dbStatus = compassContext.CMP_IssueStatusMaster.FirstOrDefault(e => e.Id == statusType.Id);
                if (dbStatus == null)
                {
                    message = "Issue type donot exists";
                    return false;
                }
                else
                {
                    dbStatus.ModifiedBy = statusType.ModifiedBy;
                    dbStatus.ModifiedOn = statusType.ModifiedOn;
                    dbStatus.IssueStatus = statusType.IssueStatus;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteIssueStatusType(int statusTypeId, out string message)
        {
            message = string.Empty;
            using (var compassContext = new CompassEntities())
            {
                var dbStatus = compassContext.CMP_IssueStatusMaster.FirstOrDefault(e => e.Id == statusTypeId);
                if (dbStatus == null)
                {
                    message = "Status type donot exists";
                    return false;
                }
                else
                {
                    // TODO : Check if the status is used in any issue
                    compassContext.CMP_IssueStatusMaster.Remove(dbStatus);
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public IEnumerable<IssueStatusDTO> GetAllIssueStatusType()
        {
            using (var compassContext = new CompassEntities())
            {
                List<IssueStatusDTO> statusTypeCollection = new List<IssueStatusDTO>();
                var dbStatus = compassContext.CMP_IssueStatusMaster.ToList();
                foreach (var item in dbStatus)
                {
                    IssueStatusDTO status = new IssueStatusDTO();
                    status.IssueStatus = item.IssueStatus;
                    status.CreatedBy = item.CreatedBy;
                    status.CreatedOn = item.CreatedOn;
                    status.Id = item.Id;
                    status.ModifiedBy = item.ModifiedBy;
                    status.ModifiedOn = item.ModifiedOn;
                    statusTypeCollection.Add(status);
                }

                return statusTypeCollection;
            }
        }
        #endregion

        #region--Issue
        public int AddNewIssue(IssueDTO newIssueDetails)
        {
            if (newIssueDetails == null)
            {
                throw new ArgumentNullException("newIssueDetails", "Please provide issue details");
            }

            using (var compassContext = new CompassEntities())
            {
                var dbIssue = new CMP_IssueDetails();
                dbIssue.CategoryId = newIssueDetails.CategoryId;
                dbIssue.CreatedBy = newIssueDetails.CreatedBy;
                dbIssue.CreatedOn = newIssueDetails.CreatedOn;
                dbIssue.ExternalId = newIssueDetails.ExternalId;
                dbIssue.IssueType = newIssueDetails.IssueType;
                dbIssue.StatusId = dbIssue.StatusId;
                dbIssue.Summary = dbIssue.Summary;
                compassContext.CMP_IssueDetails.Add(dbIssue);
                compassContext.SaveChanges();
                return dbIssue.Id;
            }
        }

        public bool EditIssueDetails(IssueDTO issueDetails, out string message)
        {
            message = string.Empty;
            if (issueDetails == null)
            {
                message = "Issue detail is blank, Please provide issue details";
                return false;
            }

            using (var compassContext = new CompassEntities())
            {
                var dbIssue = compassContext.CMP_IssueDetails.FirstOrDefault(e => e.Id == issueDetails.Id);
                if (dbIssue == null)
                {
                    message = "Issue donot exists";
                    return false;
                }
                else
                {
                    dbIssue.ModifiedBy = issueDetails.ModifiedBy;
                    dbIssue.ModifiedOn = issueDetails.ModifiedOn;
                    dbIssue.Summary = issueDetails.Summary;
                    dbIssue.StatusId = issueDetails.StatusId;
                    dbIssue.IssueType = issueDetails.IssueType;
                    dbIssue.ExternalId = issueDetails.ExternalId;
                    dbIssue.CategoryId = issueDetails.CategoryId;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }
        
        public bool DeleteIssueById(int issueId,out string message)
        {
            message = string.Empty;
            using (var compassContext = new CompassEntities())
            {
                var dbIssue = compassContext.CMP_IssueDetails.FirstOrDefault(e => e.Id == issueId);
                if (dbIssue == null)
                {
                    message = "Issue donot exists";
                    return false;
                }
                else
                {
                    // TODO : Check if the status is used in any issue
                    compassContext.CMP_IssueDetails.Remove(dbIssue);
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public IEnumerable<IssueDTO> GetAllIssues()
        {
            using (var compassContext = new CompassEntities())
            {
                List<IssueDTO> issueCollection = new List<IssueDTO>();
                var dbIssueCollection = (from issue in compassContext.CMP_IssueDetails
                                         join cate in compassContext.CMP_CategoryMaster on issue.CategoryId equals cate.Id
                                         join stat in compassContext.CMP_IssueStatusMaster on issue.StatusId equals stat.Id
                                         join tent in compassContext.CMP_TenantMaster on issue.TenantId equals tent.Id
                                         select new { issue, cate, stat, tent }).ToList();
                foreach (var item in dbIssueCollection)
                {
                    IssueDTO theIssue = new IssueDTO();
                    theIssue.CategoryId = item.issue.CategoryId;
                    theIssue.CategoryName = item.cate.CategoryName;
                    theIssue.CreatedBy = item.issue.CreatedBy;
                    theIssue.CreatedOn = item.issue.CreatedOn;
                    theIssue.ExternalId = item.issue.ExternalId;
                    theIssue.Id = item.issue.Id;
                    theIssue.IssueType = item.issue.IssueType;
                    theIssue.ModifiedBy = item.issue.ModifiedBy;
                    theIssue.ModifiedOn = item.issue.ModifiedOn;
                    theIssue.StatusId = item.issue.StatusId;
                    theIssue.Status = item.stat.IssueStatus;
                    theIssue.Summary = item.issue.Summary;
                    theIssue.TenantId = item.issue.TenantId;
                    theIssue.TenantName = item.tent.TenantName;
                    issueCollection.Add(theIssue);
                }
                return issueCollection;
            }   
        }

        public IEnumerable<IssueDTO> GetAllIssueByCategory(int categoryType)
        { throw new NotImplementedException(); }
        public IEnumerable<IssueDTO> GetAllIssueByDate(DateTime date)
        { throw new NotImplementedException(); }
        #endregion

        #region--Assign Issue
        public bool AssignIssue(IssueAssignmentDTO issueAssignment, out string message)
        {
            message = string.Empty;
            if (issueAssignment == null)
            {
                message = "Please provide assignment details";
                return false;
            }

            using (var compassContext = new CompassEntities())
            {
                var dbAssignment = new CMP_IssueAssignmentDetails();
                dbAssignment.AssignedBy = issueAssignment.AssignedBy;
                dbAssignment.AssignedOn = issueAssignment.AssignedOn;
                dbAssignment.AssignedTo = issueAssignment.AssignedTo;
                dbAssignment.IsCurrent = issueAssignment.IsCurrent;
                dbAssignment.IssueId = issueAssignment.IssueId;
                dbAssignment.CreatedBy = issueAssignment.CreatedBy;
                dbAssignment.CreatedOn = issueAssignment.CreatedOn;
                compassContext.CMP_IssueAssignmentDetails.Add(dbAssignment);
                compassContext.SaveChanges();
                return true;
            }
        }

        public bool EditAssignedIssue(IssueAssignmentDTO issueAssignment, out string message)
        {
            message = string.Empty;
            if (issueAssignment == null)
            {
                message = "issueAssignment is blank, Please provide assignment details";
                return false;
            }

            using (var compassContext = new CompassEntities())
            {
                var dbIssueAssignment = compassContext.CMP_IssueAssignmentDetails.FirstOrDefault(e => e.Id == issueAssignment.Id);
                if (dbIssueAssignment == null)
                {
                    message = "Assignment donot exists";
                    return false;
                }
                else
                {
                    dbIssueAssignment.IssueId = issueAssignment.IssueId;
                    dbIssueAssignment.IsCurrent = issueAssignment.IsCurrent;
                    dbIssueAssignment.AssignedBy = issueAssignment.AssignedBy;
                    dbIssueAssignment.AssignedOn = issueAssignment.AssignedOn;
                    dbIssueAssignment.AssignedTo = issueAssignment.AssignedTo;
                    dbIssueAssignment.ModifiedBy = issueAssignment.ModifiedBy;
                    dbIssueAssignment.ModifiedOn = issueAssignment.ModifiedOn;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public bool DeleteAssignedIssue(int issueId, out string message)
        {
            message = string.Empty;
            using (var compassContext = new CompassEntities())
            {
                var dbAssignment = compassContext.CMP_IssueAssignmentDetails.FirstOrDefault(e => e.Id == issueId);
                if (dbAssignment == null)
                {
                    message = "Assignment type donot exists";
                    return false;
                }
                else
                {
                    // TODO : Check if the activity is used in any issue
                    compassContext.CMP_IssueAssignmentDetails.Remove(dbAssignment);
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }
        
        public IEnumerable<IssueAssignmentDTO> GetAllIssuesAssignedToAUser(string userId)
        {
            using (var compassContext = new CompassEntities())
            {
                List<IssueAssignmentDTO> assignmentCollection = new List<IssueAssignmentDTO>();
                var dbAssignedIssues = compassContext.CMP_IssueAssignmentDetails.Join(compassContext.CMP_UserDetails, assignment => assignment.AssignedTo, user => user.Id, (assignment, user) => new { assignment = assignment, user = user }).Where(e => e.user.Email == userId).ToList();
                foreach (var item in dbAssignedIssues)
                {
                    IssueAssignmentDTO assignedIssue = new IssueAssignmentDTO();
                    assignedIssue.AssignedByDisplay = item.user.Email;
                    assignedIssue.AssignedBy = item.assignment.AssignedBy;
                    assignedIssue.AssignedOn = item.assignment.AssignedOn;
                    assignedIssue.AssignedTo = item.assignment.AssignedTo;
                    //assignedIssue.AssignedToDisplay = item.user.
                    assignedIssue.CreatedBy = item.assignment.CreatedBy;
                    assignedIssue.CreatedOn = item.assignment.CreatedOn;
                    assignedIssue.IsCurrent = item.assignment.IsCurrent;
                    assignedIssue.ModifiedBy = item.assignment.ModifiedBy;
                    assignedIssue.ModifiedOn = item.assignment.ModifiedOn;
                    assignmentCollection.Add(assignedIssue);
                }
                return assignmentCollection;
            }
        }

        #endregion

        #region--Issue Activity
        public int AddNewIssueActivity(IssueActivityDTO newActivity)
        {
            if (newActivity == null)
            {
                throw new ArgumentNullException("newActivity", "Please provide activity details");
            }
            using (var compassContext = new CompassEntities())
            {
                var dbActivity = new CMP_IssueActivityDetails();
                dbActivity.ActivityTypeId = newActivity.ActivityTypeId;
                dbActivity.CreatedBy = newActivity.CreatedBy;
                dbActivity.CreatedOn = newActivity.CreatedOn;
                dbActivity.DateOfActivity = newActivity.DateOfActivity;
                dbActivity.IssueId = newActivity.IssueId;
                dbActivity.UserId = newActivity.UserId;
                compassContext.CMP_IssueActivityDetails.Add(dbActivity);
                compassContext.SaveChanges();
                return dbActivity.Id;
            }
        }

        public IEnumerable<IssueActivityDTO> GetAllActivityByIssue(int issueId)
        {
            using (var compassContext = new CompassEntities())
            {
                List<IssueActivityDTO> activityCollection = new List<IssueActivityDTO>();
                //var dbAssignedIssues = compassContext.CMP_IssueAssignmentDetails.Join(compassContext.CMP_UserDetails, assignment => assignment.AssignedTo, user => user.Id, (assignment, user) => new { assignment = assignment, user = user }).Where(e => e.user.Email == userId).ToList();
                var dbActivities = compassContext.CMP_IssueActivityDetails.Join(compassContext.CMP_UserDetails, activity => activity.UserId, user => user.Id, (activity, user) => new { activity = activity, user = user }).Where(e => e.activity.IssueId == issueId).ToList();
                foreach (var item in dbActivities)
                {
                    IssueActivityDTO activity = new IssueActivityDTO();
                    activity.UserId = item.activity.UserId;
                    activity.UserName = item.user.Email;
                    activity.IssueId = item.activity.IssueId;
                    activity.Id = item.activity.IssueId;
                    activity.DateOfActivity = item.activity.DateOfActivity;
                    activity.ActivityTypeId = item.activity.ActivityTypeId;
                    // TODO : Add activity name by joining activity master 
                    //assignedIssue.AssignedToDisplay = item.user.
                    activity.CreatedBy = item.activity.CreatedBy;
                    activity.CreatedOn = item.activity.CreatedOn;
                    activity.ModifiedBy = item.activity.ModifiedBy;
                    activity.ModifiedOn = item.activity.ModifiedOn;
                    activityCollection.Add(activity);
                }
                return activityCollection;
            }
        }

        public IEnumerable<IssueActivityDTO> GetAllActivityByUser(string userId)
        {
            using (var compassContext = new CompassEntities())
            {
                List<IssueActivityDTO> activityCollection = new List<IssueActivityDTO>();
                //var dbAssignedIssues = compassContext.CMP_IssueAssignmentDetails.Join(compassContext.CMP_UserDetails, assignment => assignment.AssignedTo, user => user.Id, (assignment, user) => new { assignment = assignment, user = user }).Where(e => e.user.Email == userId).ToList();
                var dbActivities = compassContext.CMP_IssueActivityDetails.Join(compassContext.CMP_UserDetails, activity => activity.UserId, user => user.Id, (activity, user) => new { activity = activity, user = user }).Where(e => e.user.Email == userId).ToList();
                foreach (var item in dbActivities)
                {
                    IssueActivityDTO activity = new IssueActivityDTO();
                    activity.UserId = item.activity.UserId;
                    activity.UserName = item.user.Email;
                    activity.IssueId = item.activity.IssueId;
                    activity.Id = item.activity.IssueId;
                    activity.DateOfActivity = item.activity.DateOfActivity;
                    activity.ActivityTypeId = item.activity.ActivityTypeId;
                    // TODO : Add activity name by joining activity master 
                    //assignedIssue.AssignedToDisplay = item.user.
                    activity.CreatedBy = item.activity.CreatedBy;
                    activity.CreatedOn = item.activity.CreatedOn;
                    activity.ModifiedBy = item.activity.ModifiedBy;
                    activity.ModifiedOn = item.activity.ModifiedOn;
                    activityCollection.Add(activity);
                }
                return activityCollection;
            }
        }
        #endregion
    }
}
