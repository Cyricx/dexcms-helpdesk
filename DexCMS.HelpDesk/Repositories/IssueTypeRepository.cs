﻿using DexCMS.Core.Repositories;
using DexCMS.HelpDesk.Models;
using DexCMS.Core.Contexts;
using DexCMS.HelpDesk.Interfaces;

namespace DexCMS.HelpDesk.Repositories
{
    public class IssueTypeRepository : AbstractRepository<IssueType>, IIssueTypeRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSContext _ctx { get; set; }

        public IssueTypeRepository(IDexCMSContext ctx)
        {
            _ctx = ctx;
        }
    }
}
