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
        DexterityVestUpdater _dexterityVestInventoryUpdater;
        ConjuredManaCakeUpdater _conjuredManaCakeUpdater;
        ElixorOfMongooseUpdater _elixorOfMongooseUpdater;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;

            _agedBrieUpdater = new AgedBrieUpdater();
            _backstagePassUpdater = new BackstagePassUpdater();
            _dexterityVestInventoryUpdater = new DexterityVestUpdater();
            _conjuredManaCakeUpdater = new ConjuredManaCakeUpdater();
            _elixorOfMongooseUpdater = new ElixorOfMongooseUpdater();
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
            else if (item.Name == "+5 Dexterity Vest")
            {
                item = _dexterityVestInventoryUpdater.UpdateItem(item);
                Items[i] = item;
            }
            else if (item.Name == "Conjured Mana Cake")
            {
                item = _conjuredManaCakeUpdater.UpdateItem(item);
                Items[i] = item;
            }
            else if (item.Name == "Elixir of the Mongoose")
            {
                item = _elixorOfMongooseUpdater.UpdateItem(item);
                Items[i] = item;
            }
            //else
            //{
            //    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //    {
            //        if (Items[i].Quality > 0)
            //        {
            //            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //            {
            //                Items[i].Quality = Items[i].Quality - 1;
            //            }
            //        }
            //    }


            //    if (Items[i].SellIn < 0)
            //    {
            //        if (Items[i].Name != "Aged Brie")
            //        {
            //            if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //            {
            //                if (Items[i].Quality > 0)
            //                {
            //                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //                    {
            //                        Items[i].Quality = Items[i].Quality - 1;
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //    {
            //        Items[i].SellIn = Items[i].SellIn - 1;
            //    }
            //}
        }
    }
}
