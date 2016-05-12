using System.Collections.Generic;

namespace MVVMExample.Model.Drink
{
    interface IDrinkList
    {
        List<DrinkObject> List { get; set; }

        void Init();
    }
}
