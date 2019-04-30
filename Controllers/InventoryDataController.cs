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
    }
}