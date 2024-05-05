using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests.AgedBrieTests
{
    public class AgedBrieQualityTests
    {
        [Fact]
        public void QualityUpdaterShouldIncreaseBy1()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 30, Quality = 0 };

            var qualityUpdater = new AgedBrieQualityUpdater();
            qualityUpdater.UpdateQuality(item);

            Assert.Equal(1, item.Quality);
        }
    }
}
