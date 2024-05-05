using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace GildedRoseTests
{
    public class BackStagePassTests
    {
        [Fact]
        public void ShouldIncreaseInQualityBy2Between10And5Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 1 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(2, Items[0].Quality);
        }

        [Fact]
        public void ShouldIncreaseInQualityBy3Between5And0Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(4, Items[0].Quality);
        }

        [Fact]
        public void ShouldSetQualityToZeroAfterEvent()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality);
        }
    }
}
