namespace GildedRoseKata
{
    public class SulfrasUpdater: IInventoryUpdater
    {
        public static string ItemNameToProcess() => "Sulfuras, Hand of Ragnaros";

        public Item UpdateItem(Item item)
        {
            return item;
        }

        public void UpdateQuality()
        {

        }
    }
}
