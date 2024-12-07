using Metro.PassengarFac;
using Metro.PassengerRepo;
using Metro.Uitlity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    internal class Program
    {
        static void Main(string[] args)
        {           
          //create passenger repository
            var repositotyPassenger = new PassengerRepository();
            //create passenger factory 
            var factoryPassenger = new PassengerFac();
            //show all instruction info method
            CommandInfo.allInfoText();
            bool isTrue = true;
            while (isTrue)
            {
                try
                {

                    string UserCommand = string.Empty;
                    Console.Write("=====================\nWrite Your command : ");
                    UserCommand = Console.ReadLine().ToLower();
                    Console.WriteLine("=====================");

                    if (UserCommand == "x")
                    {
                        Console.WriteLine("exit successed");
                        isTrue = false;
                    }
                    else if (UserCommand == "a")
                    {
                        CommandInfo.allInfoText();
                    }
                    else if (UserCommand == "c")
                    {
                        var passenger = factoryPassenger.CreateEntity() as Passenger;

                        Console.Write("Enter Passenger Name : ");
                        string passengerName = Console.ReadLine();

                        Console.Write("Enter Passenger Age : ");
                        int passengerAge = int.Parse(Console.ReadLine());

                        Console.Write("Enter Passenger Gender only Male and FeMale : ");
                        string passengerGender = Console.ReadLine();
                        string typeCastGender = passengerGender.ToLower();
                        if (typeCastGender != PassengerGenderEnum.male.ToString())
                        {
                            if (typeCastGender != PassengerGenderEnum.female.ToString())
                            {
                                while (true)
                                {
                                    Console.Write("again Passenger Gender only Male and FeMale : ");
                                    passengerGender = Console.ReadLine();
                                    if (passengerGender == "male" || passengerGender == "female")
                                    {
                                        break;
                                    }
                                }
                            }

                        }
                        Console.Write("Write passenger Phone number : ");
                        string passengerPhone = Console.ReadLine();

                        if (passengerPhone.ToString().Length != 11)
                        {
                            while (true)
                            {
                                Console.Write("Write passenger Phone number : ");
                                passengerPhone = Console.ReadLine();
                                if (passengerPhone.ToString().Length == 11)
                                {
                                    break;
                                }
                            }
                        }

                       
                        Console.Write("Enter Passenger Email : ");
                        string passengerEmail = Console.ReadLine();
                        DateTime dateTime = DateTime.Now;
                        Console.Write("Enter Passenger birth of Date (yyyy/mm/dd) : ");
                        DateTime dob = DateTime.Parse(Console.ReadLine());
                        Console.Write("MRT Pass Passenger 'yes' otherwise 'no' : ");
                        string MrtPass = Console.ReadLine().ToLower();
                        bool isMembershipStatus = MrtPass.Contains("yes");
                        Console.Write("Passenger type Only 'Child', 'Adul', 'MRT PASS', 'Rapid Pass', 'Staf' : ");
                        string passengerType = Console.ReadLine();
                        Console.Write("Enter the passenger Card Number : ");
                        int cardNumber = int.Parse(Console.ReadLine());                        
                        passenger.PassengerName = passengerName;
                        passenger.PassengerAge = passengerAge;
                        passenger.PassengerGender = passengerGender;
                        passenger.PassengerPhone = passengerPhone;
                        passenger.PassengerEmail = passengerEmail;
                        passenger.RegistrationDate = dateTime;
                        passenger.DOB = dob;
                        passenger.IsMembershipStatus = isMembershipStatus;
                        passenger.PassengerType = passengerType;
                        passenger.CardNumber = cardNumber;


                        repositotyPassenger.Create(passenger);

                        Console.WriteLine("=========================\nCreate successfully\n=========================");


                    }
                    else if (UserCommand == "r")
                    {
                        Console.Write("Enter id you can see passenger details : ");
                        int pId = int.Parse(Console.ReadLine());
                        var p = repositotyPassenger.Read(pId) as Passenger;
                        if (p != null)
                        {
                        
        Console.WriteLine($"==========================\nPassenger Id : {p.PassengerId} \nPassenger Name : {p.PassengerName} " +
                                $"\nPassenger Age : {p.PassengerAge}\nPassenger Gender : {p.PassengerGender} " +
                                $"\nPassenger Phone No : {p.PassengerPhone}\nEmail : {p.PassengerEmail}" +
                                $"\nRegistration Date : {p.RegistrationDate}\nDate of Brith : {p.DOB}" +
                                $"\nMember Ship Status : {p.IsMembershipStatus}\nPassenger Type : {p.PassengerType}" +
                                $"\nCard Number : {p.CardNumber}\n==========================");

                        }
                        else
                        {
                            Console.WriteLine("=========================\nNot exists passenger\n=========================");
                        }
                    }
                    else if (UserCommand == "u")
                    {
                        Console.Write("Enter Update id : ");
                        int pId = int.Parse(Console.ReadLine());
                        var passenger = repositotyPassenger.Read(pId) as Passenger;
                        if (passenger != null)
                        {
                            Console.WriteLine($"=========================\nPassenger Id : {passenger.PassengerId} \nPassenger Name : {passenger.PassengerName} " +
                                $"\nPassenger Age : {passenger.PassengerAge}\nPassenger Gender : {passenger.PassengerGender} " +
                                $"\nPassenger Phone No : {passenger.PassengerPhone}\n=========================\n");

                            Console.Write("Enter Passenger Name : ");
                            string passengerName = Console.ReadLine();
                            Console.Write("Enter Passenger Age : ");
                            int passengerAge = int.Parse(Console.ReadLine());
                            Console.Write("Enter Passenger Gender only Male and FeMale : ");
                            string passengerGender = Console.ReadLine();
                            string typeCastGender = passengerGender.ToLower();
                            if (typeCastGender != PassengerGenderEnum.male.ToString())
                            {
                                if (typeCastGender != PassengerGenderEnum.female.ToString())
                                {
                                    while (true)
                                    {
                                        Console.Write("again Passenger Gender only Male and FeMale : ");
                                        passengerGender = Console.ReadLine();
                                        if (passengerGender == "male" || passengerGender == "female")
                                        {
                                            break;
                                        }
                                    }
                                }

                            }
                            Console.Write("Write passenger Phone number : ");
                            string passengerPhone = Console.ReadLine();

                            if (passengerPhone.ToString().Length != 11)
                            {
                                while (true)
                                {
                                    Console.Write("Phone number is an must be 11 digit : ");
                                    passengerPhone = Console.ReadLine();
                                    if (passengerPhone.ToString().Length == 11)
                                    {
                                        break;
                                    }
                                }
                            }


                            Console.Write("Enter Passenger Email : ");
                            string passengerEmail = Console.ReadLine();
                            DateTime dateTime = DateTime.Now;
                            Console.Write("Enter Passenger birth of Date (yyyy/mm/dd) : ");
                            DateTime dob = DateTime.Parse(Console.ReadLine());
                            Console.Write("MRT Pass Passenger 'yes' otherwise 'no' : ");
                            string MrtPass = Console.ReadLine().ToLower();
                            bool isMembershipStatus = MrtPass.Contains("yes");
                            Console.Write("Passenger type Only 'Child', 'Adul', 'MRT PASS', 'Rapid Pass', 'Staf' : ");
                            string passengerType = Console.ReadLine();
                            Console.Write("Enter the passenger Card Number : ");
                            int cardNumber = int.Parse(Console.ReadLine());
                            passenger.PassengerName = passengerName;
                            passenger.PassengerAge = passengerAge;
                            passenger.PassengerGender = passengerGender;
                            passenger.PassengerPhone = passengerPhone;
                            passenger.PassengerEmail = passengerEmail;
                            passenger.RegistrationDate = dateTime;
                            passenger.DOB = dob;
                            passenger.IsMembershipStatus = isMembershipStatus;
                            passenger.PassengerType = passengerType;
                            passenger.CardNumber = cardNumber;


                            repositotyPassenger.Update(passenger);

                            Console.WriteLine("=========================\nUpdate successfully\n=========================");
                            
                        }
                        else
                        {
                            Console.WriteLine("=========================\nNot exists passenger\n=========================");
                        }
                    }
                    else if (UserCommand == "d")
                    {

                        Console.Write("Write Id you can deleted : ");
                        int uId = int.Parse(Console.ReadLine());
                        var passenger = repositotyPassenger;
                        var pId = passenger.Read(uId) as Passenger;
                        //Console.WriteLine(passengerd.PassengerId+" " + passengerd.PassengerName);

                        if (pId != null)
                        {

                            Console.WriteLine($"====================\nPassenger Id : {pId.PassengerId} \nPassenger Name : {pId.PassengerName} " +
                                 $"\nPassenger Age : {pId.PassengerAge}\nPassenger Gender : {pId.PassengerGender} " +
                                 $"\nPassenger Phone No : {pId.PassengerPhone}\nEmail : {pId.PassengerEmail}" +
                                 $"\nRegistration Date : {pId.RegistrationDate}\nDate of Brith : {pId.DOB}" +
                                 $"\nMember Ship Status : {pId.IsMembershipStatus}\nPassenger Type : {pId.PassengerType}" +
                                 $"\nCard Number : {pId.CardNumber}\n======================");

                            passenger.Delete(uId);
                            Console.WriteLine("=========================\ndelete successfully\n=========================");

                        }
                        else
                        {
                            Console.WriteLine("=========================\nNot exists passenger\n=========================");
                        }
                    }
                    else {
                        Console.WriteLine("=========================\nInvalid Command please give me rigth Command :\n=========================");
                        CommandInfo.allInfoText();
                    }
                }catch (Exception ex) { 
                    Console.WriteLine($"=========================\n{ex.Message}\n=========================");
                    CommandInfo.allInfoText();                
                }
                
            }          

            Console.Read();
        }
    }
}
