using DexCMS.Core.Initializers.Helpers;
using DexCMS.Core.Models;
using DexCMS.HelpDesk.Contexts;
using Microsoft.AspNet.Identity;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class HelpDeskUsersReference
    {
        public ApplicationUser HelpDeskCustomer { get; set; }
        public ApplicationUser HelpDeskDeveloper { get; set; }

        public HelpDeskUsersReference(IDexCMSHelpDeskContext Context)
        {
            HelpDeskCustomer = Context.UserManager.FindByEmail("helpdeskcustomer@chrisbyram.com");
            HelpDeskDeveloper = Context.UserManager.FindByEmail("helpdeskdeveloper@chrisbyram.com");

        }
    }
}
