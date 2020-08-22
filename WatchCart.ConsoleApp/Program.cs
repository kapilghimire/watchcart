using System;
using System.Runtime.CompilerServices;
using System.Threading;
using WatchCart.Models;
using WatchCart.Models.Constants;
using WatchCart.Orders;
using WatchCart.Repository;
using WatchCart.Service;

namespace WatchCart.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Prepare the instance of all dependencies and inject into respective objects.
             */

            // It should display a welcome message to the user followed by the options to select 
            // different criterias.

            // Display the details of matched watch with the help of ToString() method
            // Ask the user to confirm about the purchase of watch
            // 1. Yes -> Save the orderdetails into database using OrderRepository
            // 2. No -> Should exit the application
            
            Console.WriteLine("Watch Kisko");
           

           Console.WriteLine("Place order : 1 or exit 2 or restar 3");
            while (true)
            {
                var opiton = Convert.ToInt32(Console.ReadLine());

                if (opiton == 1)
                {
                    StartApp();
                    
                }
                if (opiton == 2)
                {
                    // exit application 
                }
                if (opiton == 3)
                {
                    // clear screen
                }

            }


        }


        private static void PrintWatchTypeMenu()
        {
            var option = 1;
            
            foreach (var item in Enum.GetNames(typeof(WatchTypes)))
            {
                
                Console.WriteLine("{0}:{1}",item,option++);
            }


        }


        private static void BrandTypeMenu()
        {

        }

        private static void StripeTypeMenu()
        {

        }
        private static void StripColorMenu()
        {

        }

        private static void SegmentColorMenu()
        {

        }


        private static void StartApp()
        {
            Console.WriteLine("Wacth Type Options: ");

            PrintWatchTypeMenu();
            Console.WriteLine("BrandName Options: ");
            BrandTypeMenu();
            Console.WriteLine("StrapType Options: ");
            StripeTypeMenu();
            Console.WriteLine("StrapColor Options: ");
            StripColorMenu();
            Console.WriteLine("Segment Options: ");
            SegmentColorMenu();

            var WatchCartApp = new WatchCartApp( new WatchService(new WatchRepository( new WatchCatalog())), new OrderRepository( new WatchStoreDbContext()));
            var Watch = WatchCartApp.GetWatchByUserChoice();

            Console.WriteLine("Place order or not ");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                WatchCartApp.ProcessOrder(Watch);
            }
            else
            {
                /// clean the console 
                ///  StartApp();
            }
        }
    }
}
