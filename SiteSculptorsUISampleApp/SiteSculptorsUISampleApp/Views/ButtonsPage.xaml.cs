using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiteSculptorsUISampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonsPage : ContentPage
    {
        public ButtonsPage()
        {
            InitializeComponent();
        }

        private void DualButtonControl_OnButton1Clicked(object sender, EventArgs e)
        {
            var test = "test";
        }
        private void DualButtonControl_OnButton2Clicked(object sender, EventArgs e)
        {
            var test = "test";
        }
    }
}