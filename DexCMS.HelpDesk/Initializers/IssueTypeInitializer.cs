using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Models;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueTypeInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        public IssueTypeInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {
            Context.IssueTypes.AddIfNotExists(x => x.Name,
                new IssueType { Name = "Bug", IsActive = true, DisplayOrder = 0 },
                new IssueType { Name = "Question", IsActive = true, DisplayOrder = 1 },
                new IssueType { Name = "Enhancement", IsActive = true, DisplayOrder = 2 },
                new IssueType { Name = "New Feature", IsActive = true, DisplayOrder = 3 },
                new IssueType { Name = "Other Request", IsActive = true, DisplayOrder = 4 }
            );
            Context.SaveChanges();
        }
    }
}
