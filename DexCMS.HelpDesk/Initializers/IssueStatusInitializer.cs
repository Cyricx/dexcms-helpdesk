using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Models;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueStatusInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        public IssueStatusInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            Context.IssueStatuses.AddIfNotExists(x => x.Name,
                new IssueStatus { Name = "Entered", IsActive = true, DisplayOrder = 0 },
                new IssueStatus { Name = "Gathering Requirements", IsActive = true, DisplayOrder = 1 },
                new IssueStatus { Name = "Ready to Schedule", IsActive = true, DisplayOrder = 2 },
                new IssueStatus { Name = "Scheduled", IsActive = true, DisplayOrder = 3 },
                new IssueStatus { Name = "Failed in Staging", IsActive = true, DisplayOrder = 4 },
                new IssueStatus { Name = "Failed in Production", IsActive = true, DisplayOrder = 5 },
                new IssueStatus { Name = "In Progress", IsActive = true, DisplayOrder = 6 },
                new IssueStatus { Name = "Ready for Staging", IsActive = true, DisplayOrder = 7 },
                new IssueStatus { Name = "Testing", IsActive = true, DisplayOrder = 8 },
                new IssueStatus { Name = "Ready to Deploy", IsActive = true, DisplayOrder = 9 },
                new IssueStatus { Name = "Deployed", IsActive = true, DisplayOrder = 10 },
                new IssueStatus { Name = "Confirming in Production", IsActive = true, DisplayOrder = 11 },
                new IssueStatus { Name = "Closed", IsActive = true, DisplayOrder = 12 },
                new IssueStatus { Name = "Canceled", IsActive = true, DisplayOrder = 13 });
            Context.SaveChanges();
        }
    }
}
