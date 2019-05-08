using System;
using System.Collections.Generic;
using System.Linq;
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
            var item = _context.Inventory.Find(id);
            return item;
        }
        public IEnumerable<Inventory> GetItemByName(string name)
        {
            // var inventory = from i in _context.Inventory
            //                 where i.name.Contains(name)
            //                 orderby i.name
            //                 select i;
            // return inventory;
            var query = from i in _context.Inventory
                        where i.Name.Contains(name) || string.IsNullOrEmpty(name)
                        orderby i.Name
                        select i;
            return query;
        }
        public Inventory UpdateItem(Inventory item)
        {
            var entity = _context.Inventory.Attach(item);
            entity.State = EntityState.Modified;
            return item;
        }
        public Inventory DeleteItem(long id)
        {
            var item = this.GetItemById(id);
            _context.Remove(item);
            return item;
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
