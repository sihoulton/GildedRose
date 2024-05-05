using GildedRoseKata;
using Xunit;

namespace GildedRoseTests.AgedBrieTests
{
    public class AgedBrieUpdaterTests
    {
        AgedBrieUpdater _agedBrieUpdater;

        public AgedBrieUpdaterTests()
        {
            _agedBrieUpdater = new AgedBrieUpdater();
        }

        [Fact]
        public void UpdaterShouldImproveTheQualityAfterDay()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 1 };

            _agedBrieUpdater.UpdateItem(item);

            Assert.Equal(2, item.Quality);
        }

        [Fact]
        public void UpdaterShouldMaxQualityAt50()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 50 };

            _agedBrieUpdater.UpdateItem(item);

            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void UpdaterShouldDoubleQualityAfter2()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 2 };

            _agedBrieUpdater.UpdateItem(item);

            Assert.Equal(4, item.Quality);
        }

        [Fact]
        public void UpdaterShouldIncrementQualityBefore2()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 0 };

            _agedBrieUpdater.UpdateItem(item);

            Assert.Equal(1, item.Quality);
        }
    }
}
