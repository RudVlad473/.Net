using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }

        public bool IsNear(Address address)
        {
            return City == address.City && Street == address.Street;
        }

        public override string ToString()
        {
            return $"{City}, {Street}";
        }
    }
}
