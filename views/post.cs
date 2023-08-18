using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialConsole.Models;

namespace socialConsole.views
{
    public class UsersPost
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

        public static async Task DisplayUsers(List<Post> posts)
        {
            foreach (var post in posts)
            {
                Console.WriteLine($"{blue}ID: {post.Id}{resetColor}");
                Console.WriteLine($"{red}userID {post.UserId} {resetColor}");
                Console.WriteLine($"{green}Title: {post.Title}{resetColor}");
                Console.WriteLine($"{yellow}About: {post.Body}{resetColor}");
            } 
        }
    }
    
}