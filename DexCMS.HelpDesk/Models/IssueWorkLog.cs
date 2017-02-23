using DexCMS.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueWorkLog
    {
        [Key]
        public int IssueWorkLogID { get; set; }


        [Required]
        [StringLength(128)]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }


        [Required]
        public int IssueID { get; set; }

        public virtual Issue Issue { get; set; }

        public DateTime Entered { get; set; }

        public TimeSpan Time { get; set; }

        public string Notes { get; set; }
    }
}
