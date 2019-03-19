using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Model
{
    public enum FitenessDevice
    {
        AppleWatch,
        Fitbit,
        Garmin
    }

    public class Person : ModelBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string LoginId { get; set; }

        public FitenessDevice FitnessDevice { get; set; }
    }
}
