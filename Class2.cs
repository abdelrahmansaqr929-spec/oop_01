using System;
using System.Collections.Generic;
using System.Text;

namespace oop_01
{
    internal struct Shipment

    {
            private string trackingCode;
            private string description;
            private decimal weight;
            private decimal deliveryFee;

            
            public DeliveryAddress Destination { get; set; }

            
            public string TrackingCode
            {
                get { return trackingCode; }
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        trackingCode = value;
                }
            }

            public string Description
            {
                get { return description; }
                set 
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        description = value;
                }
            }

            public decimal Weight
            {
                get { return weight; }
                set 
                {
                    if (value > 0)
                        weight = value;
                }
            }

            public decimal DeliveryFee
            {
                get { return deliveryFee; }
                private set 
                {
                    if (value > 0)
                        deliveryFee = value;
                }
            }

            
            public decimal EstimatedCost
            {
                get { return DeliveryFee + (Weight * 5); }
            }

        }
}
