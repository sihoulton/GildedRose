﻿using GildedRoseKata;
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

            Assert.Equal(typeof(ConjuredManaCakeUpdater), updater.GetType());
        }
    }
}