//@CodeCopy
//MdStart
#if ACCOUNT_ON
using QTPet.Logic.Entities.Logging;

namespace QTPet.Logic.Controllers.Account
{
    internal sealed partial class ActionLogsController : GenericController<ActionLog>
    {
        public ActionLogsController()
        {
        }

        public ActionLogsController(ControllerObject other) : base(other)
        {
        }
    }
}
#endif
//MdEnd
