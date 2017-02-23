using DexCMS.HelpDesk.Contexts;
using System.Linq;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class IssueSubtaskStatusesReference
    {
        public int Entered { get; set; } 
        public int Started { get; set; } 
        public int Completed { get; set; } 

        public IssueSubtaskStatusesReference(IDexCMSHelpDeskContext Context)
        {
            Entered = Context.IssueSubtaskStatuses.Where(x => x.Name == "Entered").Select(x => x.IssueSubtaskStatusID).SingleOrDefault();
            Started = Context.IssueSubtaskStatuses.Where(x => x.Name == "Started").Select(x => x.IssueSubtaskStatusID).SingleOrDefault();
            Completed = Context.IssueSubtaskStatuses.Where(x => x.Name == "Completed").Select(x => x.IssueSubtaskStatusID).SingleOrDefault();
        }
    }
}
