using System.Collections.Generic;
using System.Linq;
using MVVMExample.Model.Coin;

namespace MVVMExample.Model.Provider
{
    class ProviderCoin : IProvider
    {
        private readonly ICoinList _coinList;

        public ProviderCoin(ICoinList coinList)
        {
            _coinList = coinList;
        }

        public List<ISubject> GetInformation()
        {
            return _coinList.List.Cast<ISubject>().ToList();
        }
    }
}
