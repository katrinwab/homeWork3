using System.Collections.Generic;
using System.Linq;
using MVVMExample.Model.Coin;

namespace MVVMExample
{
    class ProviderCoin
    {
        private readonly ICoinList _coinList;

        public ProviderCoin(ICoinList coinList)
        {
            _coinList = coinList;
        }

        public List<CoinObject> GetInformation()
        {
            return _coinList.List;
        }
    }
}
