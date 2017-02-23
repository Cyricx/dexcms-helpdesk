using DexCMS.HelpDesk.Contexts;
using System.Linq;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class IssueEffortsReference
    {
        public int Low { get; set; }
        public int Medium { get; set; }
        public int High { get; set; }

        public IssueEffortsReference(IDexCMSHelpDeskContext Context)
        {
            Low = Context.IssueEfforts.Where(x => x.Name == "Low").Select(x => x.IssueEffortID).SingleOrDefault();
            Medium = Context.IssueEfforts.Where(x => x.Name == "Medium").Select(x => x.IssueEffortID).SingleOrDefault();
            High = Context.IssueEfforts.Where(x => x.Name == "High").Select(x => x.IssueEffortID).SingleOrDefault();
        }
    }
}
