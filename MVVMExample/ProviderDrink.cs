using System.Collections.Generic;
using MVVMExample.Model.Drink;

namespace MVVMExample
{
    class ProviderDrink
    {
        private readonly IDrinkList _drinkList;

        public ProviderDrink(IDrinkList drinkList)
        {
            _drinkList = drinkList;
        }

        public List<DrinkObject> GetInformation()
        {
            return _drinkList.List;
        }
    }
}
