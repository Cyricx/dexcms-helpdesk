using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DexCMS.Core.Initializers.Helpers;
using Microsoft.AspNet.Identity.EntityFramework;
using DexCMS.HelpDesk.Initializers.Helpers;

namespace DexCMS.HelpDesk.Initializers
{
    class ApplicationUserInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        private IdentityHelper IdentityHelper;
        private HelpDeskRolesReference Roles;

        public ApplicationUserInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
            IdentityHelper = new IdentityHelper(context);
            Roles = new HelpDeskRolesReference(context);
        }

        public override void Run(bool addDemoContent = true)
        {
            if (addDemoContent)
            {
                IdentityHelper.CreateUserIfNotExists("helpdeskcustomer@chrisbyram.com", "Dexcms@123", new IdentityRole[] { Roles.HelpDeskCustomer });
                IdentityHelper.CreateUserIfNotExists("helpdeskdeveloper@chrisbyram.com", "Dexcms@123", new IdentityRole[] { Roles.HelpDeskDeveloper });
            }
        }
    }
}
