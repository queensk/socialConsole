using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialConsole.Controllers;
using socialConsole.Models;

namespace socialConsole.views
{
    public class socialInit
    {
        // Display a happy message to the user
        public static async Task Welcome(){
            Console.WriteLine("Welcome to socialConsole!");
            Console.WriteLine("This is a simple social network.");
            UserController userController = new UserController();
            List<User> users = await userController.GetUsersAsync();
            UserListView userListView = new UserListView();
            await userListView.DisplayUsers(users);
            await GetUser();
        }

        // Get user id to show posts
        public static async Task GetUser(){
            Console.WriteLine("Enter user id to show posts: ");
            string userId = Console.ReadLine();
            PostController postController = new PostController();
            List<Post> posts = await postController.GetPosts(userId);
            await UsersPost.DisplayUsers(posts);
            await GetPostComments();
        }

        // show user comment base of a post id
        public static async Task GetPostComments(){
            Console.WriteLine("Enter post id to show comments: ");
            string postId = Console.ReadLine();
            PostComments commentController = new PostComments();
            List<Comment> comments = await commentController.GetComments(postId);
            await UsersComment.DisplayComments(comments);
        }


    }
}