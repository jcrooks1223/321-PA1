using System;
using System.IO;
using System.Collections.Generic;
namespace PA1
{
    public class PostUitls 
    {
        public static void DisplayAllPosts(List<Posts> posts)
        {

         foreach(Posts post in posts) 
         {
           Console.WriteLine(post.ToString());
         }
        }
    }
}