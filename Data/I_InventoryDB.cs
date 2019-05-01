using System;
using System.Collections.Generic;
using AngularCSharp;

namespace AngularCSharp.Data
{
    public interface I_InventoryDB
    {
        Inventory AddItem(Inventory item);
        IEnumerable<Inventory> GetInventory();
        Inventory GetItemById(long[] id);
        IEnumerable<Inventory> GetItemByName(string name);
        Inventory UpdateItem(Inventory item);
        Inventory DeleteItem(long[] id);
        int Commit();
    }
}