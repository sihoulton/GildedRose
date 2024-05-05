using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests.AgedBrieTests
{
    public class AgedBrieSellInTests
    {
        [Fact]
        public void SellInUpdaterShouldDecreaseBy1()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 0 };

            var standardSellInUpdater = new StandardSellInUpdater();
            standardSellInUpdater.UpdateSellIn(item);

            Assert.Equal(29, item.SellIn);
        }
    }
}
