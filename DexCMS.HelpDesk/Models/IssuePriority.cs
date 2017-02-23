using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssuePriority
    {
        [Key]
        public int IssuePriorityID { get; set; }
       
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }
    }
}
