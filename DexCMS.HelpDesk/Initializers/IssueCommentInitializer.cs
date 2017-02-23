using DexCMS.Core.Extensions;
using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using DexCMS.HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCMS.HelpDesk.Initializers
{
    class IssueCommentInitializer : DexCMSInitializer<IDexCMSHelpDeskContext>
    {
        public IssueCommentInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override void Run(bool addDemoContent = true)
        {

        }
    }
}
