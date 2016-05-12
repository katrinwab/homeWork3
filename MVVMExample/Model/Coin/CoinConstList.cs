using System.Collections.Generic;

namespace MVVMExample.Model.Coin
{
    class CoinConstList: ICoinList
    {
        public CoinConstList()
        {
            Init();
        }

        public List<CoinObject> List { get; set; }

        public void Init()
        {
            List = new List<CoinObject>();
            List.Add(new CoinObject(1, true));
            List.Add(new CoinObject(2, true));
            List.Add(new CoinObject(3, false));
            List.Add(new CoinObject(5, false));
            List.Add(new CoinObject(10, true));
            List.Add(new CoinObject(15, false));
        }
    }
}
