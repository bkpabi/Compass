using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compass.Business.Entities
{
    using System.Runtime.Serialization;
    [DataContract]
    public class TenantMasterDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TenantName { get; set; }
        [DataMember]
        public int ProjectId { get; set; }
        [DataMember]
        public string ProjectName { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public DateTime CreatedOn { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
        [DataMember]
        public Nullable<DateTime> ModifiedOn { get; set; }
    }
}
