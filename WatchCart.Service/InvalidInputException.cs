using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCart.Service
{
    public class InvalidInputException: Exception
    {
        public InvalidInputException()
        {

        }

        public InvalidInputException(string message) : base( message)
        {
        
        }
    }
}
