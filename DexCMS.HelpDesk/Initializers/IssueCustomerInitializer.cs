using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.Core.Initializers.Helpers;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Initializers.Helpers;
using DexCMS.HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueCustomerInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        private HelpDeskUsersReference Users;
        private StatesReference States;
        private IssueModulesReference Modules;

        public IssueCustomerInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
            Users = new HelpDeskUsersReference(context);
            States = new StatesReference(context);
            Modules = new IssueModulesReference(context);
        }

        public override void Run(bool addDemoContent = true)
        {
            if (addDemoContent)
            {
                Context.IssueCustomers.AddIfNotExists(x => x.CustomerName,
                    new IssueCustomer {
                        CustomerName = "Test Customer",
                        AddressLine1 = "123 Street",
                        City = "Some City",
                        StateID = States.KS,
                        ZipCode = "12345",
                        PhoneNumber = "123-456-7890",
                        UserID = Users.HelpDeskCustomer.Id,
                        IssueModules = new List<IssueModule>
                        {
                            Modules.Base,
                            Modules.Blogs,
                            Modules.Calendars,
                            Modules.Core,
                            Modules.HelpDeskClient
                        }
                    }
                );
                Context.SaveChanges();
            }
        }
    }
}
