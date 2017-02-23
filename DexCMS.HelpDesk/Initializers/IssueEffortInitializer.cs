using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueEffortInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        public IssueEffortInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            Context.IssueEfforts.AddIfNotExists(x => x.Name,
                new IssueEffort { Name = "Low", IsActive = true, DisplayOrder = 0 },
                new IssueEffort { Name = "Medium", IsActive = true, DisplayOrder = 1 },
                new IssueEffort { Name = "High", IsActive = true, DisplayOrder = 2 });
            Context.SaveChanges();
        }
    }
}
