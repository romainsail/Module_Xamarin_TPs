using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tp2.Models;
using Xamarin.Forms;

namespace Tp2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //new LoginForm();
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //affichage au click en console
            Debug.WriteLine("Connection is clicked");
            Debug.WriteLine("Login : " + this.Login.Text);

            var login = this.Login.Text;
            var password = this.Password.Text;
            var isRemind = this.IsRemind;

            hideError();
            hideTweet();

            if (String.IsNullOrEmpty(login) || login.Length < 3)
            {
                showError("Votre login n'est pas correct !");
                return;
            }
            if ( String.IsNullOrEmpty(password) || password.Length < 6 )
            {
                showError("Votre mot de passe doit contenir plus de 6 caractères !");
                return;
            }

            showTweet();
            hideForm();
        }

        private void hideForm()
        {
            this.form.IsVisible = false;
        }

        private void hideTweet()
        {
            this.tweet.IsVisible = false;
        }

        private void showTweet()
        {
            this.tweet.IsVisible = true;
        }

        private void hideError()
        {
            this.error.IsVisible = false;
        }

        private void showError(String message)
        {
            this.error.IsVisible = true;
            this.error.Text = message;
        }
    }
}
