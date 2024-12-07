using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.PassengarFac
{
    public interface IEntity
    {
        int PassengerId { get; set; }
        string PassengerName { get; set; }
        int PassengerAge { get; set; }
        string PassengerGender { get; set; }
        string PassengerPhone { get; set; }
        string PassengerEmail { get; set; }
        DateTime RegistrationDate { get; set; }
        DateTime DOB { get; set; }

        bool IsMembershipStatus { get; set; }
        string PassengerType { get; set; } 

        int CardNumber { get; set; }
    }
}
