using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVM
{
    public class Screen : ViewModel
    {
        private string displayName;

    public Screen(string tabName)
    {
        DisplayName = tabName;
    }

    public string DisplayName
    {
        get
        {
            return displayName;
        }

        set
        {
            if (displayName != value)
            {
                displayName = value;
                RaisePropertyChanged("DisplayName");
            }
        }
    }
    }
}
