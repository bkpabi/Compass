﻿namespace Compass.Business.Entities
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class IssueActivityDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ActivityTypeId { get; set; }
        [DataMember]
        public int IssueId { get; set; }
        [DataMember]
        public System.DateTime DateOfActivity { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string UserName { get; set; }
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
