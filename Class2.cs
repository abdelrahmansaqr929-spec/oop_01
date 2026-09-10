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
        public Shipment(string trackingCode)
        { 
            this.trackingCode = "DEFAULT"; 
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            Destination = new DeliveryAddress(); 
            TrackingCode = trackingCode;
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {

            this.trackingCode = "DEFAULT";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee; 
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight}kg");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}"); 
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}, Estimated Total Cost: {EstimatedCost:C}");
            Console.WriteLine(new string('-', 30));
        }
    }
}

