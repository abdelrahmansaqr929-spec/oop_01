using System;
using System.Collections.Generic;
using System.Text;

namespace oop_01
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BulidingNumber;
         
        public DeliveryAddress(string city,string street,int bn)
        {
            City = city;
            Street = street;
            BulidingNumber = bn;
        }
        

    }
}
