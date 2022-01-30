using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginScreen
{
    public partial class MainPage : ContentPage
    {
        private const string Username = "02hero";
        private const string Password = "predavanje3";

        public MainPage()
        {
            InitializeComponent();
            Task.Run(AnimateBackground);
        }

        private async void AnimateBackground()
        {
            Action<double> foward = input => bdGradient.AnchorY = input;
            Action<double> backward = input => bdGradient.AnchorY = input;

            while (true)
            {
                bdGradient.Animate(name: "foward", callback: foward, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bdGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (UsernameEntry.Text == Username && PasswordEntry.Text == Password)
            {
                InfoLabel.Text = "Uspesan login";
                InfoLabel.TextColor = Color.Green;
            }
            else
            {
                InfoLabel.Text = "Not today";
                InfoLabel.TextColor = Color.Red;
            }
        }
    }
}
