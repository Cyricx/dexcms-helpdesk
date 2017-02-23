using DexCMS.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueComment
    {
        [Key]
        public int IssueCommentID { get; set; }


        [Required]
        [StringLength(128)]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        public int IssueID { get; set; }
        public virtual Issue Issue { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Edited { get; set; }

        [StringLength(128)]
        public string EditedUserId { get; set; }
        public virtual ApplicationUser EditedUser { get; set; }


        public string Comment { get; set; }
    }
}
