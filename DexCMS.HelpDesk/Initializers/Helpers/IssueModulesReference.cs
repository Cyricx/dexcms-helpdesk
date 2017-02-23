using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCMS.HelpDesk.Initializers.Helpers
{
    public class IssueModulesReference
    {
        public IssueModule Core { get; set; }
        public IssueModule Alerts { get; set; }
        public IssueModule Base { get; set; }
        public IssueModule Blogs { get; set; }
        public IssueModule Calendars { get; set; }
        public IssueModule Faqs { get; set; }
        public IssueModule HelpDesk { get; set; }
        public IssueModule HelpDeskClient { get; set; }
        public IssueModule Mileage { get; set; }
        public IssueModule Portfolios { get; set; }
        public IssueModule Tickets { get; set; }
        public IssueModule ExampleSite { get; set; }

        public IssueModulesReference(IDexCMSHelpDeskContext Context)
        {
            Core = Context.IssueModules.Where(x => x.Name == "Core").SingleOrDefault();
            Alerts = Context.IssueModules.Where(x => x.Name == "Alerts").SingleOrDefault();
            Base = Context.IssueModules.Where(x => x.Name == "Base").SingleOrDefault();
            Blogs = Context.IssueModules.Where(x => x.Name == "Blogs").SingleOrDefault();
            Calendars = Context.IssueModules.Where(x => x.Name == "Calendars").SingleOrDefault();
            Faqs = Context.IssueModules.Where(x => x.Name == "Faqs").SingleOrDefault();
            HelpDesk = Context.IssueModules.Where(x => x.Name == "HelpDesk").SingleOrDefault();
            HelpDeskClient = Context.IssueModules.Where(x => x.Name == "HelpDesk.Client").SingleOrDefault();
            Mileage = Context.IssueModules.Where(x => x.Name == "Mileage").SingleOrDefault();
            Portfolios = Context.IssueModules.Where(x => x.Name == "Portfolios").SingleOrDefault();
            Tickets = Context.IssueModules.Where(x => x.Name == "Tickets").SingleOrDefault();
            ExampleSite = Context.IssueModules.Where(x => x.Name == "ExampleSite").SingleOrDefault();
        }
    }
}
