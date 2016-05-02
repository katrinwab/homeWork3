using System.Collections.Generic;
using System.Linq;
using MVVMExample.Model.Drink;

namespace MVVMExample.Model.Provider
{
    class ProviderDrink: IProvider
    {
        private readonly IDrinkList _drinkList;

        public ProviderDrink(IDrinkList drinkList)
        {
            _drinkList = drinkList;
        }

        public List<ISubject> GetInformation()
        {
            return _drinkList.List.Cast<ISubject>().ToList();
        }
    }
}
