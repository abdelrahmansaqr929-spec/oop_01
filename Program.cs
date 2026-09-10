using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer1
            //1-it is struct so it will be a valu type so When a DeliveryAddress variable is copied to another variable and the copy is modified,
            //the original variable remains completely unchanged.
            //2- it is class so it will be refranse type so When a Customer variable is copied into another variable,
            //modifying the object through one variable will alter the object for both variables
            #endregion
            #region answer_02
            //1-No Validation so Anyone can assign invalid values directly(like a negative weight).
            //No Access Control: You cannot make a variable read-only or prevent modifications.
            //Breaks Data Hiding: Internal data is exposed, meaning any future changes to how data is stored will break the code
            //2-Private Fields: Hide the internal data and prevent direct external access.
            //Public Properties: Act as a gatekeeper to validate data before saving it, giving you full control over read and write permissions
            #endregion
            #region answer_03
            DeliveryAddress d1 = new DeliveryAddress("ss","ss",0) ;
            DeliveryAddress d2 = new DeliveryAddress("d","dd",1);
            d2 = d1;
            Console.WriteLine(d1.City,d1.BulidingNumber,d1.Street);
            Console.WriteLine(d2.City,d2.BulidingNumber,d2.Street);

            #endregion
            #region answer_04
            //changens in struct Shipment
            #endregion
            #region answer_05
            //changes in struct Shipment
            #endregion
            #region answer_06
            //changes in struct Shipment
            #endregion
            #region answer_07
            //changes in struct DeliveryCenter
            #endregion
            #region answer_08
            DeliveryCenter center = new DeliveryCenter(10);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"--- Enter Details for Shipment {i} ---");
                Console.Write("Tracking Code: ");
                string code = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Weight: ");
                decimal.TryParse(Console.ReadLine(), out decimal weight);
                Console.Write("Delivery Fee: ");
                decimal.TryParse(Console.ReadLine(), out decimal fee);
                Console.WriteLine("--- Enter Destination Details ---");
                Console.Write("City: ");
                string city = Console.ReadLine();
                Console.Write("Street: ");
                string street = Console.ReadLine();
                Console.Write("Building Number: ");
                int.TryParse(Console.ReadLine(), out int bldgNum);
                DeliveryAddress address = new DeliveryAddress(city, street, bldgNum);
                Shipment shipment = new Shipment(code, desc, weight, fee, address);
                center.AddShipment(shipment);
            }

            Console.Clear();
            Console.WriteLine("=== All Shipments ===\n");
            for (int i = 0; i < 3; i++)
            {
                Shipment s = center[i];
                if (s.TrackingCode != null)
                    s.PrintShipment();
            }
            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();
            Shipment foundShipment = center[searchCode];

            if (foundShipment.TrackingCode != null)
            {
                Console.WriteLine("\nShipment Found:");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("\nShipment not found.");
            }
            #endregion


        }
    }
}
