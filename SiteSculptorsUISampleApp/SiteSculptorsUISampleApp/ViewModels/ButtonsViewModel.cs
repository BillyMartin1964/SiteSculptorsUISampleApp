using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SiteSculptorsUISampleApp.ViewModels
{
    public class ButtonsViewModel : BaseViewModel
    {

        private ICommand _testButtonCommands;
        public ICommand TestButtonCommands =>
            _testButtonCommands ??= new Command<object>((x) =>
            {

                switch ((string)x)
                {
                    case "Button1":

                        break;
                    
                    case "Button2":

                        break;
                    default:
                        break;
                }
            });
    }
}
