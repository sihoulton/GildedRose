namespace GildedRoseKata
{
    public class ConjuredManaCakeUpdater : IInventoryUpdater
    {
        private Item _item;

        public static string ItemNameToProcess() => "Conjured Mana Cake";

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

            if (_item.Quality <= 2)
                _item.Quality--;

            if (_item.Quality < 0)
                _item.Quality = 0;
        }

        private void UpdateSellIn()
        {
            _item.SellIn--;
        }
    }
}
