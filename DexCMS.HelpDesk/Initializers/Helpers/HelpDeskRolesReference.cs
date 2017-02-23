using DexCMS.Core.Initializers.Helpers;
using DexCMS.Core.Models;
using DexCMS.HelpDesk.Contexts;
using Microsoft.AspNet.Identity;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class HelpDeskRolesReference:RolesReference
    {
        public ApplicationRole HelpDeskCustomer { get; set; }
        public ApplicationRole HelpDeskDeveloper { get; set; }

        public HelpDeskRolesReference(IDexCMSHelpDeskContext Context):base(Context)
        {
            HelpDeskCustomer = Context.RoleManager.FindByName("Help Desk Customer");
            HelpDeskDeveloper = Context.RoleManager.FindByName("Help Desk Developer");
        }
    }
}

