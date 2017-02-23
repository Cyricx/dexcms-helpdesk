using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DexCMS.Core.Initializers.Helpers;

namespace DexCMS.HelpDesk.Initializers
{
    class ApplicationRoleInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        private IdentityHelper IdentityHelper;

        public ApplicationRoleInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
            IdentityHelper = new IdentityHelper(context);
        }

        public override void Run(bool addDemoContent = true)
        {
            IdentityHelper.CreateRole("Help Desk Customer");
            IdentityHelper.CreateRole("Help Desk Developer");
        }
    }
}
