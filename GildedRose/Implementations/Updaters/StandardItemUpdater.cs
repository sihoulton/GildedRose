namespace GildedRoseKata
{
    public class StandardItemUpdater : IInventoryUpdater
    {
        private Item _item;

        public static string ItemNameToProcess() => "Standard Items";

        public Item UpdateItem(Item item)
        {
            _item = item;

            UpdateQuality();
            UpdateSellIn();

            return _item;
        }

        public void UpdateQuality()
        {
            _item.Quality--;

            if (_item.Quality <= 1)
                _item.Quality = 0;
        }

        private void UpdateSellIn()
        {
            _item.SellIn--;
        }
    }
}
