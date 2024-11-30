using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public required string Name { get; set; }
        public required List<Vendor> Vendors { get; set; }
        public required List<Item> Items { get; set; }
    }
}
