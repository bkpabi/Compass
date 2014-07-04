using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compass.Business.Components
{
    using Compass.Business.Entities;
    using Compass.DataModel;
    using System.Data.Entity;
    public class UserManager
    {
        public int CreateNewUser(UserDetailDTO newUser)
        {
            using (var compassContext = new CompassEntities())
            {
                var dbUser = new CMP_UserDetails();
                dbUser.CreatedBy = "bkpabi@gmail.com";
                dbUser.CreatedOn = DateTime.Now;
                dbUser.Email = "bkpabi@gmail.com";
                dbUser.IsActive = true;
                dbUser.IsLocked = false;
                dbUser.MobileNumber = "9538927046";
                dbUser.Password = "pAbitra";
                dbUser.RoleId = 1;
                compassContext.CMP_UserDetails.Add(dbUser);
                compassContext.SaveChanges();
                return 1;
            }
        }
    }
}
