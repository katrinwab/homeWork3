using System.Collections.Generic;

namespace MVVMExample.Model.Drink
{
    class DrinkConstList: IDrinkList
    {
        public DrinkConstList()
        {
            Init();
        }

        public List<Drink> List { get; set; }

        public void Init()
        {
            List = new List<Drink>();
            List.Add(new Drink(10, 5, "Чай", "\\image\\tea.png"));
            List.Add(new Drink(15, 3, "Кофе", "\\image\\coffee.png"));
            List.Add(new Drink(12, 10, "Молоко", "\\image\\milk.png"));
            List.Add(new Drink(15, 7, "Какао", "\\image\\cocao.png"));
            List.Add(new Drink(11, 15, "Сок", "\\image\\juice.png"));
            List.Add(new Drink(5, 6, "Вода", "\\image\\water.png"));
            List.Add(new Drink(20, 12, "Горячий шоколад", "\\image\\chocolate.png"));
            List.Add(new Drink(14, 8, "Йогурт", "\\image\\yogurt.png"));
            List.Add(new Drink(15, 20, "Газировка", "\\image\\cola.png"));
            List.Add(new Drink(15, 7, "Кефир", "\\image\\kefir.png"));
        }
    }
}
