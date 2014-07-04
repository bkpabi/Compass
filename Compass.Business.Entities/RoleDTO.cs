namespace Compass.Business.Entities
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class RoleDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string RoleName { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public System.DateTime CreatedOn { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
