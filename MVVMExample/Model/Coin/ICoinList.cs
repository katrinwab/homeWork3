using System.Collections.Generic;

namespace MVVMExample.Model.Coin
{
    interface ICoinList
    {
        List<Coin> List { get; set; }

        void Init();
    }
}
