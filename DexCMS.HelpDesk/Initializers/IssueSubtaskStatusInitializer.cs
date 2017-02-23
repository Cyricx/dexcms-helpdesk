using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Models;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueSubtaskStatusInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        public IssueSubtaskStatusInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            Context.IssueSubtaskStatuses.AddIfNotExists(x => x.Name,
                new IssueSubtaskStatus { Name = "Entered", IsActive = true, DisplayOrder = 0 },
                new IssueSubtaskStatus { Name = "Started", IsActive = true, DisplayOrder = 1 },
                new IssueSubtaskStatus { Name = "Completed", IsActive = true, DisplayOrder = 2 }
                );
            Context.SaveChanges();
        }
    }
}
