using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVM
{
    public class Screen : ViewModel
    {
        private string _displayName;
        private bool _closeVisible = false;

        public Screen(string tabName)
        {
            DisplayName = tabName;
        }

        public string DisplayName
        {
            get
            {
                return _displayName;
            }

            set
            {
                if (_displayName != value)
                {
                    _displayName = value;
                    NotifyOfPropertyChange(()=>DisplayName);
                }
            }
        }

        public bool CloseVisible
        {
            get
            {
                return _closeVisible;
            }

            set
            {
                _closeVisible = value;
                NotifyOfPropertyChange(()=>CloseVisible);
            }
        }
    }
}
