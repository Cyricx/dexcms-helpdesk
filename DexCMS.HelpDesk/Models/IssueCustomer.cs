using DexCMS.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.HelpDesk.Models
{
    public class IssueCustomer
    {
        [Key]
        public int IssueCustomerID { get; set; }


        [Required]
        [StringLength(150)]
        public string CustomerName { get; set; }

        [StringLength(150)]
        public string AddressLine1 { get; set; }

        [StringLength(150)]
        public string AddressLine2 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [Required]
        public int StateID { get; set; }
        public virtual State State { get; set; }


        [StringLength(15)]
        public string ZipCode { get; set; }


        [StringLength(15)]
        public string PhoneNumber { get; set; }


        [StringLength(128)]
        public string UserID { get; set; }

        public virtual ApplicationUser User { get; set; }

        [DataType(DataType.Currency)]
        public decimal? HourlyRate { get; set; }

        public virtual ICollection<IssueModule> IssueModules { get; set; }
    }
}
