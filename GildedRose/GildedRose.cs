using System;
using System.Collections.Generic;
using System.Reflection;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        AgedBrieUpdater _agedBrieUpdater;
        BackstagePassUpdater _backstagePassUpdater;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;

            _agedBrieUpdater = new AgedBrieUpdater();
            _backstagePassUpdater = new BackstagePassUpdater();
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                UpdateQualityOfItem(i);
            }
        }

        public void UpdateQualityOfItem(int i)
        {
            var item = Items[i];

            if (Items[i].Name == "Aged Brie")
            {
                item = _agedBrieUpdater.UpdateItem(item);
                Items[i] = item;
            }
            else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                item = _backstagePassUpdater.UpdateItem(item);
                Items[i] = item;
            }
            else
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
