using DexCMS.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class Issue
    {
        [Key]
        public int IssueID { get; set; }

        public DateTime Created { get; set; }

        [StringLength(128)]
        public string CreatedByID { get; set; }
        public virtual ApplicationUser CreatedBy { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? IssuePriorityID { get; set; }

        public virtual IssuePriority IssuePriority { get; set; }

        public int? IssueCustomerID { get; set; }
        public virtual IssueCustomer IssueCustomer { get; set; }

        [StringLength(250)]
        public string OtherModule { get; set; }

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

        public int? IssueEffortID { get; set; }

        public virtual IssueEffort IssueEffort { get; set; }

        public virtual ICollection<IssueComment> IssueComments { get; set; }

        public virtual ICollection<IssueImage> IssueImages { get; set; }

        public virtual ICollection<IssueModule> IssueModules { get; set; }
        public virtual ICollection<IssueSubtask> IssueSubtasks { get; set; }
    }
}
