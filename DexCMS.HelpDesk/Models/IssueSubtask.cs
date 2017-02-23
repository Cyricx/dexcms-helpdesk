using DexCMS.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueSubtask
    {
        [Key]
        public int IssueSubtaskID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public string Details { get; set; }

        public DateTime Created { get; set; }
        
        [StringLength(128)]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        public int IssueID { get; set; }
        public virtual Issue Issue { get; set; }

        [Required]
        public int IssueSubtaskStatusID { get; set; }
        public virtual IssueSubtaskStatus IssueSubtaskStatus { get; set; }

    }
}
