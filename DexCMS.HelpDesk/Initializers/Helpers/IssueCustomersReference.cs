using DexCMS.Core.Initializers.Helpers;
using DexCMS.Core.Models;
using DexCMS.HelpDesk.Contexts;
using Microsoft.AspNet.Identity;
using System.Linq;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class IssueCustomersReference : RolesReference
    {
        public int TestCustomer { get; set; }

        public IssueCustomersReference(IDexCMSHelpDeskContext Context):base(Context)
        {
            TestCustomer = Context.IssueCustomers.Where(x => x.CustomerName == "Test Customer").Select(x => x.IssueCustomerID).SingleOrDefault();
        }
    }
}
