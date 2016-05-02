using System.Collections.Generic;

namespace MVVMExample.Model.Provider
{
    interface IProvider
    {
        List<ISubject> GetInformation();
    }
}
