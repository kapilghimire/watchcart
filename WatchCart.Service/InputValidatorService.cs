using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCart.Service
{
    public class InputValidatorService
    {
        public static int Validate(string input, int limit)
        {
            try
            {
                int inputToInt = Convert.ToInt32(input);
                if (inputToInt > 0 && inputToInt <= limit)
                    return inputToInt;

                throw new Exception();
            }
            catch(Exception ex)
            {
                var message = $"Invalid User Input: {input}, Please Try Again";
                throw new InvalidInputException(message);
            }
            
        }
    }
}
