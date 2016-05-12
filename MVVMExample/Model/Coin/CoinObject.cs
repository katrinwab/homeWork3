namespace MVVMExample.Model.Coin
{
    class CoinObject
    {
        public CoinObject(int rating, bool isBlocked)
        {
            Rating = rating;
            IsBlocked = isBlocked;
        }

        public int Rating { get; private set; }
        public bool IsBlocked { get; private set; }
    }
}
