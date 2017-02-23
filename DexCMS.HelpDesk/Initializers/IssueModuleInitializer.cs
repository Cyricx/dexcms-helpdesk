using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Models;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueModuleInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        public IssueModuleInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            Context.IssueModules.AddIfNotExists(x => x.Name,
                new IssueModule { Name = "Core", IsActive = true },
                new IssueModule { Name = "Alerts", IsActive = true },
                new IssueModule { Name = "Base", IsActive = true },
                new IssueModule { Name = "Blogs", IsActive = true },
                new IssueModule { Name = "Calendars", IsActive = true },
                new IssueModule { Name = "Faqs", IsActive = true },
                new IssueModule { Name = "HelpDesk", IsActive = true },
                new IssueModule { Name = "HelpDesk.Client", IsActive = true },
                new IssueModule { Name = "Mileage", IsActive = true },
                new IssueModule { Name = "Portfolios", IsActive = true },
                new IssueModule { Name = "Tickets", IsActive = true },
                new IssueModule { Name = "ExampleSite", IsActive = true });
            Context.SaveChanges();
        }
    }
}
