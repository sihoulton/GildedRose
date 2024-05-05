namespace GildedRoseKata
{
    public class AgedBrieUpdater: IInventoryUpdater
    {
        private Item _item;

        public static string ItemNameToProcess() => "Aged Brie";

        public Item UpdateItem(Item item)
        {
            _item = item;

            UpdateQuality();
            UpdateSellIn();

            return _item;
        }

        public void UpdateQuality()
        {
            if (_item.Quality < 2)
                _item.Quality++;
            else
                _item.Quality = _item.Quality + 2;

            if (_item.Quality > 50)
                _item.Quality = 50;
        }

        private void UpdateSellIn()
        {
            _item.SellIn--;
        }
    }
}
