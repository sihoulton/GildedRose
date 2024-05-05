namespace GildedRoseKata
{
    public class BackstagePassUpdater : IInventoryUpdater
    {
        private IQualityUpdater _backstagePassUpdater;
        private ISellInUpdater _sellInUpdater;

        public BackstagePassUpdater()
        {
            _backstagePassUpdater = new BackstagePassQualityUpdater();
            _sellInUpdater = new StandardSellInUpdater();
        }

        public static string ItemNameToProcess() => "Backstage passes to a TAFKAL80ETC concert";

        public Item UpdateItem(Item item)
        {
            _backstagePassUpdater.UpdateQuality(item);
            _sellInUpdater.UpdateSellIn(item);

            return item;
        }


    }
}
