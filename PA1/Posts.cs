using System;
using System.IO;
using System.Collections.Generic;
namespace PA1
{
    public class Posts 
    {
        public int Id {get; set;}
        public string UserPosts{get; set;}
        public string TimeStamp{ get; set;}

        public int CompareTo(Posts temp)
        {
          return this.Id.CompareTo(temp.Id);
        }

        public static int CompareByTimeStamp(Posts temp1,Posts temp2)
        {
              return temp1.TimeStamp.CompareTo(temp2.TimeStamp);
        }

        public override string ToString()
        {
            return this.Id + " " + this.UserPosts + " " + this.TimeStamp;
        } 

       public static List<Posts> AddPosts()
        {
            List<Posts> myPosts = new List<Posts>();
            
            //priming read
            StreamReader add = new StreamReader("posts.txt");
            Console.WriteLine("Enter To ID or -1 to stop");
            string userInput = Console.ReadLine();
            //while loop check
            while(userInput != "-1")
            {
      
                Console.WriteLine("Enter Post");
                string tempPost = Console.ReadLine();

                string tempTime = "09/02/2020 12:00AM";

                myPosts.Add(new Posts(){Id = int.Parse(userInput), UserPosts = tempPost,TimeStamp = tempTime});

                //update read
                Console.WriteLine("Enter another ID or -1 to stop");
                userInput = Console.ReadLine();
            }
           
            return myPosts;

        }
    }

}