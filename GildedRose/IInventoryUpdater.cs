﻿using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public interface IInventoryUpdater
    {
        Item UpdateItem(Item item);
    }
}
