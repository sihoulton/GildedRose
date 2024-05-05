namespace GildedRoseKata
{
    public class BackstagePassQualityUpdater : IQualityUpdater
    {
        Item _item;

        public void UpdateQuality(Item item)
        {
            _item = item;

            IncrementQuality();

            ProtectQualityParametersOrReset();
        }

        private void IncrementQuality()
        {
            _item.Quality++;

            if (_item.SellIn < 11)
            {
                _item.Quality++;
            }

            if (_item.SellIn < 6)
            {
                _item.Quality++;
            }

        }

        private void ProtectQualityParametersOrReset()
        {
            if (_item.Quality > 50)
                _item.Quality = 50;

            if (_item.SellIn < 1)
                _item.Quality = 0;
        }
    }
}
