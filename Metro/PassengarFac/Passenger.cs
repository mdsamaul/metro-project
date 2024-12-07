using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.PassengarFac
{
    public class Passenger : IEntity
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public int PassengerAge { get; set; }
        public string PassengerGender { get; set; }
        public string PassengerPhone { get; set; }
        public string PassengerEmail { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DOB { get; set; }
        public bool IsMembershipStatus { get; set; }
        public string PassengerType { get; set; }
        public int CardNumber { get; set; }

    }
}
