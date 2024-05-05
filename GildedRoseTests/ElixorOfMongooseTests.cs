using GildedRoseKata;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;

namespace GildedRoseTests
{
    public class ElixorOfMongooseTests
    {
        [Fact]
        public void ShouldDegradeQualityBeforeExpiry()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void ShouldDegradeQualityBy1AfterExpiry()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void UpdaterShouldDegradeQualityBeforeExpiry()
        {
            var item = new Item { Name = "Elixir of the Mongoose", SellIn = 1, Quality = 1 };
            var updater = new ElixorOfMongooseUpdater();

            item = updater.UpdateItem(item);

            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void UpdaterShouldDegradeQualityBy1AfterExpiry()
        {
            var item = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 2 };
            var updater = new ElixorOfMongooseUpdater();

            item = updater.UpdateItem(item);

            Assert.Equal(0, item.Quality);
        }
    }
}
