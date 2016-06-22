using System;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueComment
    {
        [Key]
        public int IssueCommentID { get; set; }


        [Required]
        [StringLength(256)]
        public string UserID { get; set; }


        [Required]
        public int IssueID { get; set; }
        public virtual Issue Issue { get; set; }

        public DateTime DatePosted { get; set; }
        public DateTime? DateEdited { get; set; }

        [StringLength(256)]
        public string EditedBy { get; set; }

        public string Comment { get; set; }
    }
}
