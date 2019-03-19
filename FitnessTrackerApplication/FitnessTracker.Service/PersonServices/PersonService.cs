using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Model;

namespace FitnessTracker.Service.PersonServices
{
    public class PersonService : ServiceBase,IServiceBase
    {
        public IObservable<Person> GetAll()
        {
            return null;
        }
    }
}
