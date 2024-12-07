using Metro.PassengarFac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.PassengerRepo
{
    internal class PassengerRepository:IRepository
    {
        private readonly Dictionary<int, Passenger> _passenger= new Dictionary<int, Passenger>(); 
       private int _countId =1;
        public void Create(IEntity entity)
        {
            var pasanger = entity as Passenger;
            pasanger.PassengerId = _countId++;
            _passenger[pasanger.PassengerId] = pasanger;
        }

       public IEntity Read(int id)
        {
            _passenger.TryGetValue(id, out var passenger);
            return passenger;

        }


        public void Update(IEntity entity) { 
        var passenger = entity as Passenger;
            _passenger[passenger.PassengerId]=passenger;
        }
        public void Delete(int id) { 
            _passenger.Remove(id);
            _countId--;
        }
    }
}
