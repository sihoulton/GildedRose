namespace GildedRoseKata
{
    public class DexterityVestQualityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 10)
                item.Quality--;
            else if (item.Quality <= 10)
                item.Quality = item.Quality - 2;

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
