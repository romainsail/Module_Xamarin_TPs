using System;
using System.Collections.Generic;
using System.Text;
using Tp3.Services;

namespace Tp3.Models
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string user, string password)
        {
            if (user == "Romain" && password == "romain")
            {
                return true;
            }
            return false;
        }

        public List<Tweet> GetTweets()
        {
            List<Tweet> tweets = new List<Tweet>();
            tweets.Add(new Tweet("roro", "25/06/20", "totofdslqjqslkjqsljdfmlkdhfkdjsnbvidgh suifghs dpifhgsiug sifughsiughgidsj foish", "Romain", "Romain", "roro"));
            tweets.Add(new Tweet("toto", "01/06/20", "totofdslqjqslkjqsljdfmlkdhfkdjsnbvidgh suifghs dpifhgsiug sifughsiughgidsj foish", "Toto", "Toto", "toto"));
            tweets.Add(new Tweet("tata", "29/06/20", "totofdslqjqslkjqsljdfmlkdhfkdjsnbvidgh suifghs dpifhgsiug sifughsiughgidsj foish", "Romain", "Romain", "tata"));
            tweets.Add(new Tweet("titi", "28/06/20", "totofdslqjqslkjqsljdfmlkdhfkdjsnbvidgh suifghs dpifhgsiug sifughsiughgidsj foish", "Romain", "Romain", "titi"));
            tweets.Add(new Tweet("lolo", "26/06/20", "totofdslqjqslkjqsljdfmlkdhfkdjsnbvidgh suifghs dpifhgsiug sifughsiughgidsj foish", "Romain", "Romain", "lolo"));
            tweets.Add(new Tweet("lola", "25/07/20", "totofdslqjqslkjqsljdfmlkdhfkdjsnbvidgh suifghs dpifhgsiug sifughsiughgidsj foish", "Romain", "Romain", "lola"));
            return tweets;
        }
    }
}
