using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DexCMS.HelpDesk.Models
{
    public class IssueImage
    {
        [Key]
        public int IssueImageID { get; set; }


        [Required]
        public int IssueID { get; set; }
        public virtual Issue Issue { get; set; }

        [StringLength(250)]
        public string Thumbnail { get; set; }

        [StringLength(250)]
        public string FullImage { get; set; }

        [NotMapped]
        public string ReplacementFileName { get; set; }
        [NotMapped]
        public string TemporaryFileName { get; set; }
    }
}
