using System;
using System.Collections.Generic;
using System.Text;
using Tp3.Services;

namespace Tp3.Models
{
    class Tweet
    {
        public String login { get; set; }
        public String createDate { get; set; }
        public String text { get; set; }
        public String userName { get; set; }
        public String userIdent { get; set; }
        public String pseudo { get; set; }

        public Tweet(string login, string createDate, string text, string userName, string userIdent, string pseudo)
        {
            this.login = login;
            this.createDate = createDate;
            this.text = text;
            this.userName = userName;
            this.userIdent = userIdent;
            this.pseudo = pseudo;
        }

        /*        public Tweet()
                {
                }*/

        

    }
}
