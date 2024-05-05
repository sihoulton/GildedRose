using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BackstagePassUpdater : IInventoryUpdater
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
            IncrementQuality();

            ProtectQualityParametersOrReset();
        }

        private void IncrementQuality()
        {
            _item.Quality++;

            if (_item.SellIn < 11)
            {
                _item.Quality++;
            }

            if (_item.SellIn < 6)
            {
                _item.Quality++;
            }

        }

        private void ProtectQualityParametersOrReset()
        {
            if (_item.Quality > 50)
                _item.Quality = 50;

            if (_item.SellIn < 1)
                _item.Quality = 0;
        }

        private void UpdateSellIn()
        {
            _item.SellIn--;
        }
    }
}
