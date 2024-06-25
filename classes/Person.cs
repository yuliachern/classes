using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        // Field member
        private string _taxNumber;
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        public void PrintInitials()
        {
            var firstInitial = FirstName[0];
            var lastInitial = LastName[0];
            Console.WriteLine($"{firstInitial} {lastInitial}");
        }
        public void GenerateTaxNumber()
        {
            _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
        public string GetTaxNumber()
        { return _taxNumber; }
    }
}
