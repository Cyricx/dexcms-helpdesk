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
    class IssuePriorityInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        public IssuePriorityInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            Context.IssuePriorities.AddIfNotExists(x => x.Name,
                new IssuePriority { Name = "Low", IsActive = true, DisplayOrder = 0 },
                new IssuePriority { Name = "Medium", IsActive = true, DisplayOrder = 0 },
                new IssuePriority { Name = "High", IsActive = true, DisplayOrder = 0 },
                new IssuePriority { Name = "Urgent", IsActive = true, DisplayOrder = 0 });
            Context.SaveChanges();
        }
    }
}
