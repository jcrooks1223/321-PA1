using System;
using System.IO;
using System.Collections.Generic;
namespace PA1
{
    public class PostFile 
    {
        public static List<Posts> GetPosts()
        {
            List<Posts> userPost = new List<Posts>();
            StreamReader inFile = null;
            
            try
            {
             inFile = new StreamReader("posts.txt");
            }
            catch(FileNotFoundException e)
            {
              Console.WriteLine("Error Something Went Wrong" + e);
              return userPost;
            }
           
             string input = inFile.ReadLine();
            
            while(input != null)
            {
                string[] temp = input.Split("#");

                int PostId = int.Parse(temp[0]);
                
                userPost.Add(new Posts(){Id = PostId, UserPosts = temp[1],TimeStamp = temp[2]});
                
                input = inFile.ReadLine();
            }

            inFile.Close();

            return userPost;
        }
  
    }
}