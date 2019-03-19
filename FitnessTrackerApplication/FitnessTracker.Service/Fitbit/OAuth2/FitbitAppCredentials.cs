using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Service.Fitbit.OAuth2
{
    public class FitbitAppCredentials
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public FitbitAppCredentials()
        {
            ClientId = "22DKN2";
            ClientSecret = "b93882a5a2f9803e677301ff0898906e";
        }
    }
}
