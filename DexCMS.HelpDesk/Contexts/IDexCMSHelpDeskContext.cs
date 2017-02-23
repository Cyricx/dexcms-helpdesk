using DexCMS.HelpDesk.Models;
using DexCMS.Core.Contexts;
using System.Data.Entity;

namespace DexCMS.HelpDesk.Contexts
{
    public interface IDexCMSHelpDeskContext : IDexCMSCoreContext
    {
        DbSet<Issue> Issues { get; set; }
        DbSet<IssueComment> IssueComments { get; set; }
        DbSet<IssueCustomer> IssueCustomers { get; set; }
        DbSet<IssueEffort> IssueEfforts { get; set; }
        DbSet<IssueImage> IssueImages { get; set; }
        DbSet<IssueModule> IssueModules { get; set; }
        DbSet<IssuePriority> IssuePriorities { get; set; }
        DbSet<IssueStatus> IssueStatuses { get; set; }
        DbSet<IssueSubtask> IssueSubtasks { get; set; }
        DbSet<IssueSubtaskStatus> IssueSubtaskStatuses { get; set; }
        DbSet<IssueType> IssueTypes { get; set; }
        DbSet<IssueWorkLog> IssueWorkLogs { get; set; }
    }
}
