using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialConsole.Models;

namespace socialConsole.views
{
    public class UserListView
    {
        static private string white = "\u001b[37m";
        static private string blue = "\u001b[34m";
        static private string green = "\u001b[32m";
        static private string yellow = "\u001b[33m";
        static private string magenta = "\u001b[35m";
        static private string red = "\u001b[31m";
        static private string resetColor = "\u001b[0m";
        static private string lightBlue = "\u001b[36m";
        static string orange = "\u001b[38;5;208m";
        public async Task DisplayUsers(List<User> users)
        {
            Console.WriteLine("User List:");
            foreach (var user in users)
            {
                Console.WriteLine($"{orange}User ID: {user.Id}{resetColor}");
                Console.WriteLine($"{orange}Name: {user.Name}");
                Console.WriteLine($"{orange}Username: {user.Username}");
                Console.WriteLine($"{orange}Email: {user.Email}");
                Console.WriteLine("{orange}Address:");
                Console.WriteLine($"{orange}  Street: {user.Address.Street}");
                Console.WriteLine($"{orange}  Suite: {user.Address.Suite}");
                Console.WriteLine($"{orange}  City: {user.Address.City}");
                Console.WriteLine($"{orange}  Zipcode: {user.Address.Zipcode}");
                Console.WriteLine($"{orange}  Latitude: {user.Address.Geo.Lat}");
                Console.WriteLine($"{orange}  Longitude: {user.Address.Geo.Lng}");
                Console.WriteLine($"{orange}Phone: {user.Phone}");
                Console.WriteLine($"{orange}Website: {user.Website}");
                Console.WriteLine("{orange}Company:");
                Console.WriteLine($"{orange}  Name: {user.Company.Name}");
                Console.WriteLine($"{orange}  Catch Phrase: {user.Company.CatchPhrase}");
                Console.WriteLine($"{orange}  Business: {user.Company.Bs}{resetColor}");
                Console.WriteLine();
            }
        }
    }
}