﻿using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.HelpDesk.Models;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.HelpDesk.Interfaces;

namespace DexCMS.HelpDesk.Repositories
{
    public class IssueWorkLogRepository : AbstractRepository<IssueWorkLog>, IIssueWorkLogRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSContext _ctx { get; set; }

        public IssueWorkLogRepository(IDexCMSContext ctx)
        {
            _ctx = ctx;
        }
    }
}
