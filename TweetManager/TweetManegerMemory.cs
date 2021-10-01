using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterManager
{
    public class TweetManegerMemory : TweetManager
    {
        string[] tweets = new string[10];
        int tweetsCounter = 0;
        public override string WriteTweet(string tweet)
        {
            if (tweet.Length > 140)
                return "Error: tweet is more thane 140 character.";
            if (tweetsCounter >= tweets.Length)
                return "Error: Max tweets reached.";
            tweets[tweetsCounter++] = tweet;
            return "tweet posted successfully.";
        }

        public override string[] GetTweets()
        {
            return tweets;
        }
        public override int TweetCounter()
        {
            return tweetsCounter;
        }

    }
}
