using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StringerTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button buttonAccount = new Button
            {
                Text = "Account",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
            };
            Button buttonMeet = new Button
            {
                Text = "Meet",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.End,
            };

            Button buttonSettings = new Button
            {
                Text = "Settings",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
            };

            buttonAccount.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Account());
            };

            Content = buttonMeet;
            Content = buttonSettings;
            Content = buttonAccount;
        }

    }

}
