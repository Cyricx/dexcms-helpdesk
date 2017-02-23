using DexCMS.HelpDesk.Contexts;
using System.Linq;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class IssuePrioritiesReference
    {
        public int Low { get; set; }
        public int Medium { get; set; }
        public int High { get; set; }
        public int Urgent { get; set; }

        public IssuePrioritiesReference(IDexCMSHelpDeskContext Context)
        {
            Low = Context.IssuePriorities.Where(x => x.Name == "Low").Select(x => x.IssuePriorityID).SingleOrDefault();
            Medium = Context.IssuePriorities.Where(x => x.Name == "Medium").Select(x => x.IssuePriorityID).SingleOrDefault();
            High = Context.IssuePriorities.Where(x => x.Name == "High").Select(x => x.IssuePriorityID).SingleOrDefault();
            Urgent = Context.IssuePriorities.Where(x => x.Name == "Urgent").Select(x => x.IssuePriorityID).SingleOrDefault();
        }
    }
}
