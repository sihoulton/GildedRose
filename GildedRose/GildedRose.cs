using System;
using System.Collections.Generic;
using System.Reflection;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;

        UpdaterFactory _updaterFactory;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;

            _updaterFactory = new UpdaterFactory();
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

            var updater = _updaterFactory.LoadAppropriateInveontoryUpdater(item);

            if (updater == null)
                return;

            item = updater.UpdateItem(item);
            Items[i] = item;
           
        }
    }
}
