using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Service.Fitbit
{
    public class FitbitException : Exception
    {
        public List<ApiError> ApiErrors { get; set; }

        public FitbitException(string message, IEnumerable<ApiError> errors, Exception innerEx = null) : base(message, innerEx)
        {
            ApiErrors = errors != null ? new List<ApiError>(errors) : new List<ApiError>();
        }
    }
}
