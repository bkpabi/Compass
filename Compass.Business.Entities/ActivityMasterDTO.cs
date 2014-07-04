namespace Compass.Business.Entities
{
    using System;
    using System.Runtime.Serialization;
    [DataContract]
    public class ActivityMasterDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ActivityName { get; set; }
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
