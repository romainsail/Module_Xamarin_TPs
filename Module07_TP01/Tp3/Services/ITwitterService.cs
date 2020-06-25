using System;
using System.Collections.Generic;
using System.Text;
using Tp3.Models;

namespace Tp3.Services
{
    interface ITwitterService
    {
        bool authenticate(String user, String password);
        List<Tweet> GetTweets();
    }
}
