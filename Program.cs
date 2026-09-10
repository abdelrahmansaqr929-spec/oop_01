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


        }
    }
}
