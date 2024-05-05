namespace GildedRoseKata
{
    public class AgedBrieUpdater: IInventoryUpdater
    {
        private IQualityUpdater _agedBrieQualityUpdater;
        private ISellInUpdater _sellInUpdater;

        public AgedBrieUpdater()
        {
            _agedBrieQualityUpdater = new AgedBrieQualityUpdater();
            _sellInUpdater = new StandardSellInUpdater();
        }

        public static string ItemNameToProcess() => "Aged Brie";

        public Item UpdateItem(Item item)
        {
            _agedBrieQualityUpdater.UpdateQuality(item);
            _sellInUpdater.UpdateSellIn(item);

            return item;
        }

    }
}
