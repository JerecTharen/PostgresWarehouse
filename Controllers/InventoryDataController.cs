using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularCSharp.Data;
using AngularCSharp;

namespace AngularCSharp.Controllers
{
    [Route("api/[controller]")]
    public class InventoryDataController: Controller
    {

        private readonly I_InventoryDB _inventory;

        public InventoryDataController(I_InventoryDB inventory)
        {
            this._inventory = inventory;
        }
        
        [HttpGet("[action]")]
        public IEnumerable<Inventory> AllItems()
        {
            return _inventory.GetInventory();
        }

        [HttpGet("[action]")]
        public IEnumerable<Inventory> ByName(string name)
        {
            return _inventory.GetItemByName(name);
        }
        [HttpGet("[action]")]
        public Inventory ById(long id)
        {
            return _inventory.GetItemById(id);
        }
        [HttpPost("[action]")]
        public int Update(Inventory item)
        {
            _inventory.UpdateItem(item);
            return _inventory.Commit();
        }
        [HttpPost("[action]")]
        public int Delete(long id)
        {
            _inventory.DeleteItem(id);
            return _inventory.Commit();
        }
        [HttpPost("[action]")]
        public Inventory AddItem(Inventory item)
        {
            _inventory.AddItem(item);
            var confirmed = _inventory.Commit();
            if(confirmed == 1){
                return item;
            }
            else{
                return new Inventory();
            }
        }
    }
}