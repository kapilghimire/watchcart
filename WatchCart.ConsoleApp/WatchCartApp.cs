using AutoMapper;
using System;
using WatchCart.Models;
using WatchCart.Models.Constants;
using WatchCart.Orders;
using WatchCart.Service;

namespace WatchCart.ConsoleApp
{
    public class WatchCartApp
    {
        public WatchCartApp(IWatchService watchService, IOrderRepository repository){
            
        }
        /// <summary>
        /// This method is used to accept the user choice of WatchType, BrandName, StrapType, StrapColor and Segment
        /// by displaying a menu step by step. Every Menu should also have an option to exit at any time.
        /// </summary>
        /// <returns>Returns a Watch Basis upon the options selected</returns>
        public Watch GetWatchByUserChoice()
        {
            //implement the code to display the menu options
            //after getting all inputs, retreive the watch based upon the choice
            return null;
        }

        /// <summary>
        /// Helper method to transform Watch object into OrderDetails
        /// </summary>
        /// <param name="watch">Watch Object</param>
        /// <returns>OrderDetails</returns>
        private static OrderDetails MapToOrderDetails(Watch watch)
        {
            return null;
        }

        /// <summary>
        /// This method is used to save the order in Database with the help of orderRepository
        /// </summary>
        /// <param name="watch">Watch Object</param>
        /// <param name="placeOrder">user choice, Want to place order(1,2)?</param>
        public void ProcessOrder(Watch watch, string placeOrder)
        {
            
        }
    }
}
