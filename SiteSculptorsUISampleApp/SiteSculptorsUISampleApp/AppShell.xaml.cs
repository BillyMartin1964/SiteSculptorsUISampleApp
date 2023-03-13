using System;
using System.Collections.Generic;

using SiteSculptorsUISampleApp.ViewModels;
using SiteSculptorsUISampleApp.Views;

using Xamarin.Forms;

namespace SiteSculptorsUISampleApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ButtonsPage), typeof(ButtonsPage));
        }

        //private async void OnMenuItemClicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync("//LoginPage");
        //}
    }
}
