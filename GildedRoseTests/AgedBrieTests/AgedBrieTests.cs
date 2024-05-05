using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests.AgedBrieTests
{
    public class AgedBrieTests
    {
        [Fact]
        public void ShouldIncreaseInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void ShouldMaxQualityAt50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 30, Quality = 50 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(50, Items[0].Quality);
        }

    }
}
