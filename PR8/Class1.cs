using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8
{
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    interface IPrint
    {
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string ReturnInformation();
    }
    class Person : IPerson, IPrint
        {
        public string FirstName {  set; get; }
        public string LastName { set; get; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Person(string firstName,string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public string ReturnInformation()
        {
            string FullInformation = "Имя:" + FirstName + "Фамилия:" + LastName + "Email:" + Email + "Телефон:" + PhoneNumber;
            return FullInformation;
        }
    }
}
