using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compass.Business.Entities
{
    using System.Runtime.Serialization;
    [DataContract]
    public class UserDetailDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string MobileNumber { get; set; }

        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public string ModifiedBy { get; set; }

        [DataMember]
        public DateTime ModifiedOn { get; set; }
    }
}
