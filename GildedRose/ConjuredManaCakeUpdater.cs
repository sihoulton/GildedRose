using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class ConjuredManaCakeUpdater : IInventoryUpdater
    {
        private Item _item;

        public Item UpdateItem(Item item)
        {
            _item = item;

            UpdateQuality();
            UpdateSellIn();

            return _item;
        }

        private void UpdateQuality()
        {
            _item.Quality--;

            if (_item.Quality == 2)
                _item.Quality--;

            if (_item.Quality < 0)
                _item.Quality = 0;
        }

        private void UpdateSellIn()
        {
            _item.SellIn--;
        }
    }
}
