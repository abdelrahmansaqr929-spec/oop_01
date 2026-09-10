using System;
using System.Collections.Generic;
using System.Text;

namespace oop_01
{
    public struct DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;

        public DeliveryCenter(int capacity = 10)
        {
            shipments = new Shipment[capacity];
            count = 0;
        }
        public Shipment this [int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= count)
                    return default(Shipment); 

                return shipments[index]; 
            }
            set
            {
                if (shipments != null && index >= 0 && index < count)
                {
                    shipments[index] = value; 
                }

            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments == null) return default(Shipment);

                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                        return shipments[i]; 
                }
                return default(Shipment);
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
                shipments = new Shipment[10];

            if (count < 10)
            {
                shipments[count] = shipment; 
                count++;
                return true;
            }
            return false; 
        }
    } 
}
    
