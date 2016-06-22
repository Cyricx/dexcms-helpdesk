using DexCMS.Core.Infrastructure.Models;
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


        [StringLength(256)]
        public string PrimaryContact { get; set; }

        [DataType(DataType.Currency)]
        public decimal? HourlyRate { get; set; }
    }
}
