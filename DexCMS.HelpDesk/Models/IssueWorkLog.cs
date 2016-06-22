using System;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueWorkLog
    {
        [Key]
        public int IssueWorkLogID { get; set; }


        [Required]
        [StringLength(256)]
        public string UserID { get; set; }


        [Required]
        public int IssueID { get; set; }

        public virtual Issue Issue { get; set; }

        public DateTime DateEntered { get; set; }

        public TimeSpan Time { get; set; }

        public string Notes { get; set; }
    }
}
