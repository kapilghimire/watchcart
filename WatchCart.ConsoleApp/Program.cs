using System;
using WatchCart.Models;
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
        }    
    }
}
