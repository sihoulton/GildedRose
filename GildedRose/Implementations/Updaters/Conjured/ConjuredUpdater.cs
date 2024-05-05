namespace GildedRoseKata
{
    public class ConjuredUpdater : IInventoryUpdater
    {
        private IQualityUpdater _conjuredUpdater;
        private ISellInUpdater _sellInUpdater;

        public ConjuredUpdater()
        {
            _conjuredUpdater = new ConjuredQaulityUpdater();
            _sellInUpdater = new StandardSellInUpdater();
        }

        public static string ItemNameToProcess() => "Conjured *";

        public Item UpdateItem(Item item)
        {
            _conjuredUpdater.UpdateQuality(item);
            _sellInUpdater.UpdateSellIn(item);

            return item;
        }

    }
}
