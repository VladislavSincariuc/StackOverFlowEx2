using System;
using System.Reflection;

namespace StackOverFlowEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post("Sau petuh", "O scapat sluceaino saponul...");

       
            Console.WriteLine("Title : {0}", newPost.Title);
            Console.WriteLine("Description : {0}", newPost.Description);
            Console.WriteLine("It was created on : {0}", newPost.ItWasCreatedOn);
            Console.WriteLine("Vote count : {0}\n--------------------", newPost.Vote);

            Console.WriteLine("Type 1 to vote up.\nType 0 to vote down.\n--------------------");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        newPost.UpVote();
                        Console.WriteLine("--------------------\nTitle : {0}", newPost.Title);
                        Console.WriteLine("Description : {0}", newPost.Description);
                        Console.WriteLine("It was created on : {0}", newPost.ItWasCreatedOn);
                        Console.WriteLine("Vote count : {0}\n--------------------", newPost.Vote);
                        break;
                    case "0":
                        newPost.DownVote();
                        Console.WriteLine("--------------------\nTitle : {0}", newPost.Title);
                        Console.WriteLine("Description : {0}", newPost.Description);
                        Console.WriteLine("It was created on : {0}", newPost.ItWasCreatedOn);
                        Console.WriteLine("Vote count : {0}\n--------------------", newPost.Vote);
                        break;
                    default:
                        Console.WriteLine("Make sure you Type the correct key!!!\n--------------------");
                        Console.WriteLine("Type 1 to vote up.\nType 0 to vote down.\n--------------------");
                        break;
                }
            }
        }
       
    }
}