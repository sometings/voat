//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubmissionVoteTracker
    {
        public int ID { get; set; }
        public int SubmissionID { get; set; }
        public string UserName { get; set; }
        public Nullable<int> VoteStatus { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string IPAddress { get; set; }
    
        public virtual Submission Submission { get; set; }
    }
}
