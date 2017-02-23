using DexCMS.Core.Globals;
using DexCMS.HelpDesk.Contexts;
using System;
using System.Collections.Generic;


namespace DexCMS.HelpDesk.Initializers
{
    public class HelpDeskInitializer : DexCMSLibraryInitializer<IDexCMSHelpDeskContext>
    {
        public HelpDeskInitializer(IDexCMSHelpDeskContext context) : base(context)
        {
        }

        public override List<Type> Initializers
        {
            get
            {
                return new List<Type> {
                    typeof(IssueEffortInitializer),
                    typeof(IssueModuleInitializer),
                    typeof(IssuePriorityInitializer),
                    typeof(IssueStatusInitializer),
                    typeof(IssueSubtaskStatusInitializer),
                    typeof(IssueTypeInitializer)
                };
            }
        }
    }
}
