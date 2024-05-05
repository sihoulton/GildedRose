using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
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

        [Fact]
        public void UpdaterShouldImproveTheQualityAfterDay()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 1 };

            AgedBrieUpdater agedBrieUpdater = new AgedBrieUpdater();
            agedBrieUpdater.UpdateItem(item);

            Assert.Equal(2, item.Quality);
        }

        [Fact]
        public void UpdaterShouldMaxQualityAt50()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 50 };

            AgedBrieUpdater agedBrieUpdater = new AgedBrieUpdater();
            agedBrieUpdater.UpdateItem(item);

            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void UpdaterShouldDoubleQualityAfter2()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 2 };

            AgedBrieUpdater agedBrieUpdater = new AgedBrieUpdater();
            agedBrieUpdater.UpdateItem(item);

            Assert.Equal(4, item.Quality);
        }

        [Fact]
        public void UpdaterShouldIncrementQualityBefore2()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 0 };

            AgedBrieUpdater agedBrieUpdater = new AgedBrieUpdater();
            agedBrieUpdater.UpdateItem(item);

            Assert.Equal(1, item.Quality);
        }
    }
}
