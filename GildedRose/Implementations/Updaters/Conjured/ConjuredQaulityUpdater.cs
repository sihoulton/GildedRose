namespace GildedRoseKata
{
    public class ConjuredQaulityUpdater : IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.Quality--;

            if (item.Quality <= 2)
                item.Quality--;

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
