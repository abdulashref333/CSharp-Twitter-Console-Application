using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterManager
{
    public class TweetManagerFile : TweetManager
    {
        private string fileName = "tweets.txt";

        public override string WriteTweet(string tweet)
        {
            //here we write to the file not save on memory...
            System.IO.File.AppendAllLines(fileName, new string[] { tweet });

            return "tweet posted successfully.";
        }

        public override int TweetCounter()
        {
            return System.IO.File.ReadAllLines(fileName).Length ;
        }

        public override string[] GetTweets()
        {
            return System.IO.File.ReadAllLines(fileName);
        }
    }
}
