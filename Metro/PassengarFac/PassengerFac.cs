using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.PassengarFac
{
    internal class PassengerFac : IEntityFactory
    {
        public IEntity CreateEntity()
        {
            return new Passenger();
        }
    }
}
