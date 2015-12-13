using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarinForms
{
    public class SubCS : ContentPage
    {
        public SubCS(string name)
        {
            Title = "Welcome";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label {
                        Text = string.Format("Hello {0}!", name),
                        HorizontalTextAlignment = TextAlignment.Center
                    }
                }
            };
        }
    }
}
