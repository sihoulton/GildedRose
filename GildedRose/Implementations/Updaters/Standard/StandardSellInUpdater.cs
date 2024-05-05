namespace GildedRoseKata
{
    public class StandardSellInUpdater: ISellInUpdater
    {
        public void UpdateSellIn(Item item)
        {
            item.SellIn--;
        }
    }
}
