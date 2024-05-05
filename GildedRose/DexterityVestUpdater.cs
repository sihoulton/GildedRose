using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class DexterityVestUpdater : IInventoryUpdater
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
            if (_item.Quality > 10)
                _item.Quality--;
            else if (_item.Quality <= 10)
                _item.Quality = _item.Quality - 2;

            if (_item.Quality < 0)
                _item.Quality = 0;
        }

        private void UpdateSellIn()
        {
            _item.SellIn--;
        }
    }
}
