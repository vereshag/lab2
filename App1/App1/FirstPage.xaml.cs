using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Label1.Text = Entry1.Text;
        }

        private async void Button_level_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game());
        }

        private async void Button_Setting_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
        private void Button_exit_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}