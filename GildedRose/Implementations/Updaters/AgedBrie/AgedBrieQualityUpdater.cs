namespace GildedRoseKata
{
    public class AgedBrieQualityUpdater: IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 2)
                item.Quality++;
            else
                item.Quality = item.Quality + 2;

            if (item.Quality > 50)
                item.Quality = 50;
        }
    }
}
