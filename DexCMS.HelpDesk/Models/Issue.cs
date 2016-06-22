using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class Issue
    {
        [Key]
        public int IssueID { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [Required]
        public int IssueModuleID { get; set; }

        public virtual IssueModule IssueModule { get; set; }

        [Required]
        [Range(1, 10)]
        public byte Priority { get; set; }

        [Required]
        public int IssueCustomerID { get; set; }
        public virtual IssueCustomer IssueCustomer { get; set; }


        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public string Details { get; set; }

        [Required]
        public int IssueStatusID { get; set; }
        public virtual IssueStatus IssueStatus { get; set; }

        [Required]
        public int IssueTypeID { get; set; }
        public virtual IssueType IssueType { get; set; }

        [Range(1, 10)]
        public byte? LevelOfEffort { get; set; }

        public virtual ICollection<IssueComment> IssueComments { get; set; }

        public virtual ICollection<IssueImage> IssueImages { get; set; }
    }
}
