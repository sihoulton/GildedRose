using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
{
    public class BackStagePassTests
    {
        [Fact]
        public void ShouldIncreaseInQualityAfterDayWhenEventOver10DaysAway()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 1 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal(2, Items[0].Quality);
        }
    }
}
