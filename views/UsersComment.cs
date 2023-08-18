using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialConsole.Models;

namespace socialConsole.views
{
    public class UsersComment
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
    //         {
    //     "postId": 1,
    //     "id": 1,
    //     "name": "id labore ex et quam laborum",
    //     "email": "Eliseo@gardner.biz",
    //     "body": "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
    // },
    // {
        public static async Task DisplayComments(List<Comment> comments)
        {
            Console.WriteLine("Comments:");
            foreach (var comment in comments)
            {
                Console.WriteLine($"{green}PostId: {comment.PostId}");
                Console.WriteLine($"{green}Id: {comment.Id}");
                Console.WriteLine($"{green}Name: {comment.Name}");
                Console.WriteLine($"{green}Email: {comment.Email}");
                Console.WriteLine($"{green}Body: {comment.Body}{resetColor}");
            }
        }
    }
}