using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        

        public SecondPage(int _number)
        {
            InitializeComponent();
            NumberLabel.Text = _number.ToString();
        }

        protected override void OnAppearing()
        {
            NumberLabel.Text = "Not a string";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThirdPage());
        }
    }
}