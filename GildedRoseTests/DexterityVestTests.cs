using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
{
    public class DexterityVestTests
    {
        [Fact]
        public void ShouldDegradeQualityBeforeExpiry()
        {
            IList<Item> items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void ShouldDegradeQualityBy2AfterExpiry()
        {
            IList<Item> items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void UpdaterShouldDegradeQualityBeforeExpiry()
        {
            Item item = new Item { Name = "+5 Dexterity Vest", SellIn = 1, Quality = 1 } ;

            var updater = new DexterityVestUpdater();

            item = updater.UpdateItem(item);

            Assert.Equal(0, item.SellIn);
            Assert.Equal(0, item.Quality);
        }
    }
}
