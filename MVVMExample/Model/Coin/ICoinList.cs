using System.Collections.Generic;

namespace MVVMExample.Model.Coin
{
    interface ICoinList
    {
        List<CoinObject> List { get; set; }

        void Init();
    }
}
