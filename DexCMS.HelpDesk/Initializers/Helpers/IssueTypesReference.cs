using DexCMS.HelpDesk.Contexts;
using System.Linq;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class IssueTypesReference
    {
        public int Bug { get; set; }
        public int Question { get; set; }
        public int Enhancement { get; set; }
        public int NewFeature { get; set; }
        public int OtherRequest { get; set; }

        public IssueTypesReference(IDexCMSHelpDeskContext Context)
        {
            Bug = Context.IssueTypes.Where(x => x.Name == "Bug").Select(x => x.IssueTypeID).SingleOrDefault();
            Question = Context.IssueTypes.Where(x => x.Name == "Question").Select(x => x.IssueTypeID).SingleOrDefault();
            Enhancement = Context.IssueTypes.Where(x => x.Name == "Enhancement").Select(x => x.IssueTypeID).SingleOrDefault();
            NewFeature = Context.IssueTypes.Where(x => x.Name == "New Feature").Select(x => x.IssueTypeID).SingleOrDefault();
            OtherRequest = Context.IssueTypes.Where(x => x.Name == "Other Request").Select(x => x.IssueTypeID).SingleOrDefault();
        }
    }
}
