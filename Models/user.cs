using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace socialConsole.Models
{
     public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Company Company { get; set; }

        public void printUser()
        {
            Console.WriteLine("User: " + Name);
            Console.WriteLine("Username: " + Username);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Address: " + Address.Street + " " + Address.Suite + " " + Address.City + " " + Address.Zipcode);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Website: " + Website);
            Console.WriteLine("Company: " + Company.Name);
        }
    }

}