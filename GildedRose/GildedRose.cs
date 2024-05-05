using System;
using System.Collections.Generic;
using System.Reflection;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        IUpdaterFactory _updaterFactory;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;

            _updaterFactory = new UpdaterFactory();
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                UpdateItem(i);
            }
        }

        public void UpdateItem(int i)
        {
            var item = Items[i];

            var updater = _updaterFactory.LoadAppropriateInventoryUpdater(item);

            if (updater == null)
                throw new Exception($"Unable to process item {item.Name}, may require a new Updater.");

            item = updater.UpdateItem(item);
            Items[i] = item;
           
        }
    }
}
