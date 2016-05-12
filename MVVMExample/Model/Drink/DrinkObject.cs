namespace MVVMExample.Model.Drink
{
    class DrinkObject
    {
        public DrinkObject(int cost, int count, string name, string imageUri)
        {
            Name = name;
            Count = count;
            Cost = cost;
            ImageUri = imageUri;
        }

        public int Buy()
        {
            Count--;
            return Cost;
        }

        public int Cost { get; private set; }
        public int Count { get; private set; }
        public string Name { get; private set; }
        public string ImageUri { get; set; }
    }
}
