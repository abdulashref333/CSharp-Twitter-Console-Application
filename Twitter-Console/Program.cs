using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterManager;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            TweetManagerFile tm = new TweetManagerFile();
            do
            {
                Console.WriteLine("------------ Main Menu ------------");
                Console.WriteLine();
                Console.WriteLine("1. View All Tweets");
                Console.WriteLine("2. Post A New Tweet");
                Console.WriteLine("3. Search About Tweets");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    Console.WriteLine("********** Your Tweets **********");
                    string[] tweets = tm.GetTweets();
                    for(int i=0; i< tm.TweetCounter(); i++)
                    {
                        Console.WriteLine("Tweet #{0}: {1}", i + 1, tweets[i]);
                    }
                    Console.WriteLine("=================================");
                }
                else if(choice == "2")
                {
                    Console.Write("Enter Your Tweet: ");
                    string tweet = Console.ReadLine();
                    Console.WriteLine(tm.PostTweet(tweet));
 
                }else if(choice == "3")
                {
                    Console.Write("Please Enter Your SearchTerm: ");
                    string searchTerm = Console.ReadLine();
                    List<string> tweets = tm.Search(searchTerm);
                    for(int i = 0; i < tweets.Count(); i++)
                    {
                        Console.WriteLine(tweets[i]);
                    }
                }
            } while (choice != "4");
            Console.WriteLine();
            Console.WriteLine("By By (^ _ ^)");
            Console.ReadLine();
        }
    }
}
