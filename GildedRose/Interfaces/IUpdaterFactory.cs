namespace GildedRoseKata
{
    public interface IUpdaterFactory
    {
        IInventoryUpdater LoadAppropriateInventoryUpdater(Item item);
    }
}
