using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tp2.Models
{
    class LoginForm
    {
        public Entry Login { get; }
        public Entry Password { get; }
        public Switch IsRemind { get; }
        public VisibilitySwitch VisibilitySwitch { get; }
        public bool IsValid()
        {
            bool result = true;
            return result;
        }

        public LoginForm(Entry login, Entry password, Switch isRemind, VisibilitySwitch visibilitySwitch)
        {
            Login = login;
            Password = password;
            IsRemind = isRemind;
            VisibilitySwitch = visibilitySwitch;
        }

        public LoginForm()
        {
        }
    }
}
