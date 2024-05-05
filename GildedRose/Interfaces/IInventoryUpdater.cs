using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public interface IInventoryUpdater
    {
        static abstract string ItemNameToProcess();
        Item UpdateItem(Item item);
    }
}
