using System;
using System.Collections.Generic;
using System.IO;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
          Menu();  
        }
        public static void Menu()
        {
          int userChoice = 0;
          List<Posts> myPosts = new List<Posts>();
          List<Posts> userPosts = PostFile.GetPosts();
         // List<PostFile> addPost = new List<PostFile>();
         
          
          while(userChoice !=4)
          {
            Console.WriteLine("Hello! Please select an option from the menu below");
          Console.WriteLine("1.Display All Post\n" +
          "2.Add an Post\n" +
          "3.Delete a Post");
            try
                {
                    userChoice = int.Parse(Console.ReadLine());
                    if(userChoice < 1 || userChoice > 3)
                    {
                        throw new Exception("Not a Valid Menu Choice");
                    }
                }
                catch(Exception e)
                {
                   Console.WriteLine(e.Message);
                }
                finally
                {
                   if(userChoice == 1)
                   {
                   Console.WriteLine("Display Posts");
                   userPosts.Sort(Posts.CompareByTimeStamp);
                   PostUitls.DisplayAllPosts(userPosts);
                  
                   }
                   else if(userChoice == 2)
                   {
                     Console.WriteLine("Add Post");
                      List<Posts> newPost = Posts.AddPosts();
                      
                     PostUitls.DisplayAllPosts(userPosts);
                     PostUitls.DisplayAllPosts(newPost);
                     userPosts.AddRange(newPost);

                     
                     Console.WriteLine("Press any key to continue");
                     Console.ReadLine();
                   }
                   else if(userChoice ==3)
                   {
                        Console.WriteLine("Delete Post");
                        int userDelete = int.Parse(Console.ReadLine());
                        int foundIndex = userPosts.FindIndex(temp => temp.Id == userDelete);
                        
                         if(foundIndex != -1)
                         {
                           userPosts.RemoveAt(foundIndex);
                         }
                        PostUitls.DisplayAllPosts(userPosts);

                   }
                }

          }
           
        }

    }
}
