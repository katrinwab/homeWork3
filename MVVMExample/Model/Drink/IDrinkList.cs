using System.Collections.Generic;

namespace MVVMExample.Model.Drink
{
    interface IDrinkList
    {
        List<Drink> List { get; set; }

        void Init();
    }
}
