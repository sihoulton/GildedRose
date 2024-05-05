using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
{
    public class ConjuredManaCakeTests
    {
        [Fact]
        public void ShouldDegradeQualityBeforeExpiry()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void ShouldDegradeQualityBy2AfterExpiry()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void UpdaterShouldDegradeQualityBeforeExpiry()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 1 } ;
            var updater = new ConjuredManaCakeUpdater();

            item = updater.UpdateItem(item);

            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void UpdaterShouldDegradeQualityBy2AfterExpiry()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 2 };
            var updater = new ConjuredManaCakeUpdater();

            item = updater.UpdateItem(item);

            Assert.Equal(1, item.Quality);
        }
    }
}
