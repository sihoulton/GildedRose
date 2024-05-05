namespace GildedRoseKata
{
    public class DexterityVestUpdater : IInventoryUpdater
    {
        private IQualityUpdater _dexterityVestQualityUpdater;
        private ISellInUpdater _sellInUpdater;

        public DexterityVestUpdater()
        {
            _dexterityVestQualityUpdater = new DexterityVestQualityUpdater();
            _sellInUpdater = new StandardSellInUpdater();
        }

        public static string ItemNameToProcess() => "+5 Dexterity Vest";

        public Item UpdateItem(Item item)
        {
            _dexterityVestQualityUpdater.UpdateQuality(item);
            _sellInUpdater.UpdateSellIn(item);

            return item;
        }

    }
}
