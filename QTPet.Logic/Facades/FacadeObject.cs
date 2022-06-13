//@CodeCopy
//MdStart

using QTPet.Logic.Controllers;

namespace QTPet.Logic.Facades
{
    public abstract partial class FacadeObject
    {
        internal ControllerObject ControllerObject { get; private set; }

        protected FacadeObject(ControllerObject controllerObject)
        {
            ControllerObject = controllerObject;
        }
    }
}

//MdEnd
