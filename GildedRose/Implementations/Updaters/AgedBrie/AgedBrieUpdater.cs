namespace GildedRoseKata
{
    public class AgedBrieUpdater: IInventoryUpdater
    {
        private Item _item;
        private AgedBrieQualityUpdater _agedBrieQualityUpdater = new AgedBrieQualityUpdater();
        private ISellInUpdater _sellInUpdater;

        public AgedBrieUpdater()
        {
            _sellInUpdater = new StandardSellInUpdater();
        }

        public static string ItemNameToProcess() => "Aged Brie";

        public Item UpdateItem(Item item)
        {
            _item = item;

            _agedBrieQualityUpdater.UpdateQuality(item);
            _sellInUpdater.UpdateSellIn(item);

            return _item;
        }

    }
}
