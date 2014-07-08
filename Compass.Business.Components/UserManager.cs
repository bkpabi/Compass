namespace Compass.Business.Components
{
    using Compass.Business.Entities;
    using Compass.DataModel;
    using System.Collections.Generic;
    using System.Linq;
    public class UserManager
    {
        public int CreateNewUser(UserDetailDTO newUser, out string message)
        {
            using (var compassContext = new CompassEntities())
            {
                message = string.Empty;
                if (compassContext.CMP_UserDetails.Where(e=> e.Email == newUser.Email).ToList().Count > 0)
                {
                    message = "The specified email id is already in use, Try another one.";
                    return -1;
                }
                var dbUser = new CMP_UserDetails();
                dbUser.CreatedBy = newUser.CreatedBy;
                dbUser.CreatedOn = newUser.CreatedOn;
                dbUser.Email = newUser.Email;
                dbUser.IsActive = newUser.IsActive;
                dbUser.IsLocked = newUser.IsLocked;
                dbUser.MobileNumber = newUser.MobileNumber;
                dbUser.FirstName = newUser.FirstName;
                dbUser.LastName = newUser.LastName;
                dbUser.Password = newUser.Password;
                dbUser.RoleId = newUser.RoleId;
                compassContext.CMP_UserDetails.Add(dbUser);
                compassContext.SaveChanges();
                return dbUser.Id;
            }
        }

        public List<UserDetailDTO> GetAllActiveUser()
        {
            using (var compassContext = new CompassEntities())
            {
                List<UserDetailDTO> userCollection = new List<UserDetailDTO>();
                //var userList = compassContext.CMP_UserDetails.Where(e => e.IsActive == true).ToList();
                var userList = compassContext.CMP_UserDetails.Join(compassContext.CMP_RoleMaster, user => user.RoleId, role => role.Id, (user, role) => new { user = user, role = role }).Where(e => e.user.IsActive == true).ToList();
                foreach (var item in userList)
                {
                    UserDetailDTO userDTO = new UserDetailDTO();
                    userDTO.RoleId = item.user.RoleId;
                    userDTO.Password = item.user.Password;
                    userDTO.LastName = item.user.LastName;
                    userDTO.FirstName = item.user.FirstName;
                    userDTO.ModifiedOn = item.user.ModifiedOn;
                    userDTO.ModifiedBy = item.user.ModifiedBy;
                    userDTO.MobileNumber = item.user.MobileNumber;
                    userDTO.IsLocked = item.user.IsLocked;
                    userDTO.IsActive = item.user.IsActive;
                    userDTO.Id = item.user.Id;
                    userDTO.Email = item.user.Email;
                    userDTO.CreatedOn = item.user.CreatedOn;
                    userDTO.CreatedBy = item.user.CreatedBy;
                    userDTO.RoleName = item.role.RoleName;
                    userCollection.Add(userDTO);
                }
                return userCollection;
            }
        }

        public bool EditUserDetails(UserDetailDTO userDetails, out string message)
        {
            using (var compassContext = new CompassEntities())
            {
                message = string.Empty;
                bool isSuccess = false;
                var dbUser = compassContext.CMP_UserDetails.FirstOrDefault(e => e.Id == userDetails.Id);
                
                //Check if the user is trying to update user name
                if (dbUser.Email == userDetails.Email)
                {
                    dbUser.ModifiedBy = userDetails.ModifiedBy;
                    dbUser.CreatedOn = userDetails.ModifiedOn.Value;
                    dbUser.Email = userDetails.Email;
                    dbUser.IsActive = userDetails.IsActive;
                    dbUser.IsLocked = userDetails.IsLocked;
                    dbUser.MobileNumber = userDetails.MobileNumber;
                    dbUser.Password = userDetails.Password;
                    dbUser.LastName = userDetails.LastName;
                    dbUser.FirstName = userDetails.FirstName;
                    dbUser.RoleId = userDetails.RoleId;
                    compassContext.SaveChanges();
                    isSuccess = true;
                }
                else if (compassContext.CMP_UserDetails.Where(e => e.Email == userDetails.Email).ToList().Count > 0)
	            {
                    message = "The specified email id is already in use, Try another one.";
	            }

                return isSuccess;
            }
        }

        public  bool ChangePassword(string userId,string oldPassword, string newPassword, out string message)
        {
            using (var compassContext = new CompassEntities())
            {
                message = string.Empty;
                var dbUser = compassContext.CMP_UserDetails.FirstOrDefault(e => e.Email == userId);
                if (dbUser == null)
                {
                    message = "Invalid user details";
                    return false;
                }
                else if(dbUser.Password != oldPassword)
                {
                    message = "Invalid old password";
                    return false;
                }
                else
                {
                    dbUser.Password = newPassword;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public UserDetailDTO AuthenticateUser(string email,string password,out string message)
        {
            using (var compassContext = new CompassEntities())
            {
                message = string.Empty;
                UserDetailDTO userDTO = null;
                //var dbUser = compassContext.CMP_UserDetails.FirstOrDefault(e => e.Email == email && e.Password == password);
                var dbUser = compassContext.CMP_UserDetails.Join(compassContext.CMP_RoleMaster, user => user.RoleId, role => role.Id, (user, role) => new { user = user, role = role }).FirstOrDefault(e => e.user.Email == email && e.user.Password == password);
                if (dbUser == null)
                {
                    message = "Authntication failed";
                    return userDTO;
                }
                else if(!dbUser.user.IsActive)
                {
                    message = "User is not active";
                    return userDTO;
                }
                else if(dbUser.user.IsLocked)
                {
                    message = "User is locked";
                    return userDTO;
                }
                else
                {
                    userDTO.RoleId = dbUser.user.RoleId;
                    userDTO.Password = dbUser.user.Password;
                    userDTO.ModifiedOn = dbUser.user.ModifiedOn;
                    userDTO.ModifiedBy = dbUser.user.ModifiedBy;
                    userDTO.MobileNumber = dbUser.user.MobileNumber;
                    userDTO.FirstName = dbUser.user.FirstName;
                    userDTO.LastName = dbUser.user.LastName;
                    userDTO.IsLocked = dbUser.user.IsLocked;
                    userDTO.IsActive = dbUser.user.IsActive;
                    userDTO.Id = dbUser.user.Id;
                    userDTO.Email = dbUser.user.Email;
                    userDTO.CreatedOn = dbUser.user.CreatedOn;
                    userDTO.CreatedBy = dbUser.user.CreatedBy;
                    userDTO.RoleName = dbUser.role.RoleName;
                    return userDTO;
                }
            }
        }

        public bool UnlockUser(string userId,out string message)
        {
            using (var compassContext = new CompassEntities())
            {
                message = string.Empty;
                var dbUser = compassContext.CMP_UserDetails.FirstOrDefault(e => e.Email == userId);
                if (dbUser == null)
                {
                    message = "Invalid user details";
                    return false;
                }
                else
                {
                    dbUser.IsLocked = false;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }

        public bool ActivateUser(string userId,out string message)
        {
            using (var compassContext = new CompassEntities())
            {
                message = string.Empty;
                var dbUser = compassContext.CMP_UserDetails.FirstOrDefault(e => e.Email == userId);
                if (dbUser == null)
                {
                    message = "Invalid user details";
                    return false;
                }
                else
                {
                    dbUser.IsActive = true;
                    compassContext.SaveChanges();
                    return true;
                }
            }
        }
    }
}
