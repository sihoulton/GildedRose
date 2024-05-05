﻿using GildedRoseKata;
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
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void ShouldMaxQualityAt50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 30, Quality = 50 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal(50, Items[0].Quality);
        }
    }
}
