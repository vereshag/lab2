using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Entry Entry1 = new Entry()
            {
                Placeholder = "Write"
            };
            Button Button1 = new Button()
            {
                Text = "Tap"
            };
            Label Label1 = new Label()
            {
                Text = "Привет"
            };
            Button1.Clicked += Button_Clicked;
            Content = new StackLayout
            {
                Children = {
                    Entry1,Button1,Label1
                }
            };
            void Button_Clicked(object sender, EventArgs e)
            {
                Label1.Text = Entry1.Text;
            }
        }
    }
}         