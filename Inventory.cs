using System;
using System.Collections.Generic;

namespace AngularCSharp
{
    public partial class Inventory
    {
        public long[] ItemId { get; set; }
        public string Name { get; set; }
        public int Aisle { get; set; }
        public int Shelf { get; set; }
        public long Quantity { get; set; }
    }
}
