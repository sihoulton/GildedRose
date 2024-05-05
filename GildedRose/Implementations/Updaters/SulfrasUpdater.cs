using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class SulfrasUpdater: IInventoryUpdater
    {
        public static string ItemNameToProcess() => "Sulfuras, Hand of Ragnaros";

        public Item UpdateItem(Item item) => item;
    }
}
