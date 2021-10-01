using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterManager
{
    public abstract class TweetManager
    {
        const int MaxTweet = 10;
        public abstract string[] GetTweets();
        public abstract int TweetCounter();
        public abstract string WriteTweet(string tweet);
        public string PostTweet(string tweet)
        {
            if (tweet.Length > 140)
                return "Error: tweet is more thane 140 character.";
            if (TweetCounter() >= MaxTweet)
                return "Error: Max tweets reached.";

            return WriteTweet(tweet);
        }

        public List<string> Search(string searchTerm)
        {
            List<string> results = new List<string>();
            string[] tweets = GetTweets();
            
            for(int i = 0; i< TweetCounter(); i++)
            {
                if (tweets[i].Contains(searchTerm))
                {
                    results.Add(tweets[i]);
                }
            }

            return results;
        }
    }
}
