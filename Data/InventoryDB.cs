using System;
using System.Collections.Generic;
using AngularCSharp;
using Microsoft.EntityFrameworkCore;

namespace AngularCSharp.Data
{
    public class InventoryDB: I_InventoryDB
    {

        private readonly WarehouseContext _context;

        public InventoryDB(WarehouseContext _context)
        {
            this._context = _context;
        }



        public Inventory AddItem(Inventory item)
        {
            _context.Add(item);
            return item;
        }
        public IEnumerable<Inventory> GetInventory()
        {
            return _context.Inventory.FromSql<Inventory>("SELECT * FROM Inventory;");
        }
        public Inventory GetItemById(long id)
        {
            return new Inventory();
        }
        public Inventory UpdateItem(Inventory item)
        {
            return item;
        }
        public Inventory DeleteItem(long id)
        {
            return new Inventory();
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
