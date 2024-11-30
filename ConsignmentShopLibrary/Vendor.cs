using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public double Commission { get; set; }
    }
}
