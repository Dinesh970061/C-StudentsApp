using ShipAppLibrary.User;
using System;

namespace ShipAppLibrary
{
    public class ShipApp
    {
        public static string user_Id;
        static void Main(string[] args)
        {
            Consumer customer = new Consumer();

            IDP ID = new IDP();
            Console.WriteLine("Enter the user type");
            Console.WriteLine("customer");
            Console.WriteLine("driver");
            user_Id = Console.ReadLine();
            if (user_Id == "customer")
            {
                customer.Login();
                customer.Place_order();

            }
            else if (user_Id == "driver")
            {
                ID.Login();
                ID.Accept_order();
            }


            Console.ReadKey();
        }

    }
}
