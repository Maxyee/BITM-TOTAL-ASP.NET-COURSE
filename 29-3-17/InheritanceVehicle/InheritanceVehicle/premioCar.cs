using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVehicle
{
    class premioCar:Car
    {
        Vehicle car1 = new Vehicle();

        public Vehicle Car1
        {
            get { return car1; }
            set { car1 = value; }
        }
    }
}
