using System.Collections.Generic;

namespace MVVMExample.Model.Coin
{
    class CoinConstList: ICoinList
    {
        public CoinConstList()
        {
            Init();
        }

        public List<Coin> List { get; set; }

        public void Init()
        {
            List = new List<Coin>();
            List.Add(new Coin(1, true));
            List.Add(new Coin(2, true));
            List.Add(new Coin(3, false));
            List.Add(new Coin(5, false));
            List.Add(new Coin(10, true));
            List.Add(new Coin(15, false));
        }
    }
}
