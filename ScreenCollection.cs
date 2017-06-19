using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVM
{
    public class ScreenCollection : ViewModel
    {
        private ObservableCollection<Screen> screens = new ObservableCollection<Screen>();
        private Screen activeScreen;

        public ObservableCollection<Screen> Screens
        {
            get
            {
                return screens;
            }
        }

        public Screen ActiveScreen
        {
            get
            {
                return activeScreen;
            }

            set
            {
                if (activeScreen != null)
                    activeScreen.CloseVisible = false;
                if (value != null)
                    value.CloseVisible = true;
                activeScreen = value;
                NotifyOfPropertyChange("ActiveScreen");
            }
        }
    }
}
