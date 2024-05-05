using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
{
    public class UpdaterFactoryTests
    {
        [Fact]
        public void ShouldLoadABrieUpdater()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 1 } ;
            
            var factoryUpdater = new UpdaterFactory();
            var updater = factoryUpdater.LoadAppropriateInveontoryUpdater(item);

            Assert.Equal(typeof(ConjuredUpdater), updater.GetType());
        }

        [Fact]
        public void ShouldLoadStandardUpdaterForFoo()
        {
            Item item = new Item { Name = "foo", SellIn = 1, Quality = 1 };

            var factoryUpdater = new UpdaterFactory();
            var updater = factoryUpdater.LoadAppropriateInveontoryUpdater(item);

            Assert.Equal(typeof(StandardItemUpdater), updater.GetType());
        }

        [Fact]
        public void ShouldLoadConjuredUpdaterForConjuredManaCake()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 1 };

            var factoryUpdater = new UpdaterFactory();
            var updater = factoryUpdater.LoadAppropriateInveontoryUpdater(item);

            Assert.Equal(typeof(ConjuredUpdater), updater.GetType());
        }
    }
}
