using DexCMS.HelpDesk.Models;
using DexCMS.Core.Infrastructure.Contexts;
using System.Data.Entity;

namespace DexCMS.HelpDesk.Contexts
{
    public interface IDexCMSHelpDeskContext : IDexCMSContext
    {
        DbSet<Issue> Issues { get; set; }
        DbSet<IssueComment> IssueComments { get; set; }
        DbSet<IssueCustomer> IssueCustomers { get; set; }
        DbSet<IssueImage> IssueImages { get; set; }
        DbSet<IssueModule> IssueModules { get; set; }
        DbSet<IssueStatus> IssueStatuses { get; set; }
        DbSet<IssueType> IssueTypes { get; set; }
        DbSet<IssueWorkLog> IssueWorkLogs { get; set; }
    }
}
