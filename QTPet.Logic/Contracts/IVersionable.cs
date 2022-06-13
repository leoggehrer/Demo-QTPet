//@CodeCopy
//MdStart

namespace QTPet.Logic.Contracts
{
    public partial interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
