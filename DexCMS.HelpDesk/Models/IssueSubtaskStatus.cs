using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueSubtaskStatus
    {
        [Key]
        public int IssueSubtaskStatusID { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public bool IsActive { get; set; }


        public virtual ICollection<IssueSubtask> IssueSubtasks { get; set; }

    }
}
