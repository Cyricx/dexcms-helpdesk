using DexCMS.HelpDesk.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class IssueStatusesReference
    {
        public int Entered { get; set; } 
        public int GatheringRequirements { get; set; } 
        public int ReadyToSchedule { get; set; } 
        public int Scheduled { get; set; } 
        public int FailedInStaging { get; set; } 
        public int FailedInProduction { get; set; } 
        public int InProgress { get; set; } 
        public int DevelopmentTesting { get; set; } 
        public int ReadyForStaging { get; set; } 
        public int Testing { get; set; } 
        public int ReadyToDeploy { get; set; } 
        public int Deployed { get; set; } 
        public int ConfirmingInProduction { get; set; } 
        public int Closed { get; set; }
        public int Canceled { get; set; }

        public IssueStatusesReference(IDexCMSHelpDeskContext Context)
        {
            Entered = Context.IssueStatuses.Where(x => x.Name == "Entered").Select(x => x.IssueStatusID).SingleOrDefault();
            GatheringRequirements = Context.IssueStatuses.Where(x => x.Name == "Gathering Requirements").Select(x => x.IssueStatusID).SingleOrDefault();
            ReadyToSchedule = Context.IssueStatuses.Where(x => x.Name == "Ready to Schedule").Select(x => x.IssueStatusID).SingleOrDefault();
            Scheduled = Context.IssueStatuses.Where(x => x.Name == "Scheduled").Select(x => x.IssueStatusID).SingleOrDefault();
            FailedInStaging = Context.IssueStatuses.Where(x => x.Name == "Failed in Staging").Select(x => x.IssueStatusID).SingleOrDefault();
            FailedInProduction = Context.IssueStatuses.Where(x => x.Name == "Failed in Production").Select(x => x.IssueStatusID).SingleOrDefault();
            InProgress = Context.IssueStatuses.Where(x => x.Name == "In Progress").Select(x => x.IssueStatusID).SingleOrDefault();
            ReadyForStaging = Context.IssueStatuses.Where(x => x.Name == "Ready for Staging").Select(x => x.IssueStatusID).SingleOrDefault();
            Testing = Context.IssueStatuses.Where(x => x.Name == "Testing").Select(x => x.IssueStatusID).SingleOrDefault();
            ReadyToDeploy = Context.IssueStatuses.Where(x => x.Name == "Ready to Deploy").Select(x => x.IssueStatusID).SingleOrDefault();
            Deployed = Context.IssueStatuses.Where(x => x.Name == "Deployed").Select(x => x.IssueStatusID).SingleOrDefault();
            ConfirmingInProduction = Context.IssueStatuses.Where(x => x.Name == "Confirming in Production").Select(x => x.IssueStatusID).SingleOrDefault();
            Closed = Context.IssueStatuses.Where(x => x.Name == "Closed").Select(x => x.IssueStatusID).SingleOrDefault();
            Canceled = Context.IssueStatuses.Where(x => x.Name == "Canceled").Select(x => x.IssueStatusID).SingleOrDefault();
        }
    }
}
