using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Service.Fitbit
{
    public class FitbitParseException : Exception
    {
        private const string DefaultMessage = "Error occured while trying to parse JSON.";
        public FitbitParseException(Exception ex, string message = DefaultMessage) : base(message, ex)
        {

        }

        public FitbitParseException(string message = DefaultMessage) : base(message)
        {

        }
    }
}
