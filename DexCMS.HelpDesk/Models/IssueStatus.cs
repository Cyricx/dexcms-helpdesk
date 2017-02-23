using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueStatus
    {
        [Key]
        public int IssueStatusID { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public bool IsActive { get; set; }


        public virtual ICollection<Issue> Issues { get; set; }

    }
}
