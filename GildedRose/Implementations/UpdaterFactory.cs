using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class UpdaterFactory
    {
        public IInventoryUpdater LoadAppropriateInveontoryUpdater(Item item)
        {
            var interfaceType = typeof(IInventoryUpdater);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.IsAssignableTo(interfaceType) && type.Name != "IInventoryUpdater");

            foreach(var type in types)
            {
                var method = type.GetMethod("ItemNameToProcess");

                if (method == null)
                    break;

                string itemNameThatCanProcess = method.Invoke(null, null)
                                                    .ToString();

                if (string.Equals(itemNameThatCanProcess, item.Name) ||
                    HasWildCardMatchingOnName(itemNameThatCanProcess, item.Name))
                    return (IInventoryUpdater)Activator.CreateInstance(type, null);
            }

            return new StandardItemUpdater();
        }

        private bool HasWildCardMatchingOnName(string itemNameThatCanProcess, string itemName)
        {
            if (!itemNameThatCanProcess.Contains("*"))
                return false;

            string literalPartOfItemNameThatCanProcess = itemNameThatCanProcess.Substring(0, itemNameThatCanProcess.IndexOf("*"));

            return itemName.StartsWith(literalPartOfItemNameThatCanProcess);
        }
    }
}
