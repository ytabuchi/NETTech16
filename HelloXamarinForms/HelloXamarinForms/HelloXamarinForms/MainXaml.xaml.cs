using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarinForms
{
    public partial class MainXaml : ContentPage
    {
        public MainXaml()
        {
            InitializeComponent();
        }

        void OnButtonClicked (object sender, EventArgs e)
        {
            Navigation.PushAsync(new SubCS(entry.Text));
        }
    }
}
