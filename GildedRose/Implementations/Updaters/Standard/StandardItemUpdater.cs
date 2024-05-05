namespace GildedRoseKata
{
    public class StandardItemUpdater : IInventoryUpdater
    {
        private Item _item;
        private ISellInUpdater _sellInUpdater;

        public StandardItemUpdater()
        {
            _sellInUpdater = new StandardSellInUpdater();
        }

        public static string ItemNameToProcess() => "Standard Items";

        public Item UpdateItem(Item item)
        {
            _item = item;

            UpdateQuality();
            _sellInUpdater.UpdateSellIn(item);

            return _item;
        }

        public void UpdateQuality()
        {
            _item.Quality--;

            if (_item.Quality <= 1)
                _item.Quality = 0;
        }

    }
}
