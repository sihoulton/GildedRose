namespace GildedRoseKata
{
    public interface IInventoryUpdater
    {
        static abstract string ItemNameToProcess();
        Item UpdateItem(Item item);
    }
}
