using DexCMS.Core.Contexts;
using DexCMS.Core.Repositories;
using DexCMS.HelpDesk.Interfaces;
using DexCMS.HelpDesk.Models;

namespace DexCMS.HelpDesk.Repositories
{
    public class IssueRepository : AbstractRepository<Issue>, IIssueRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSContext _ctx { get; set; }

        public IssueRepository(IDexCMSContext ctx)
        {
            _ctx = ctx;
        }
    }
}
