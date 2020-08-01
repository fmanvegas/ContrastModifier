using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrastModifier
{
    public class WindowViewModel : PropChanged
    {
        private bool _windowWhite = false;
        public bool WindowWhite
        {
            get => _windowWhite;
            set { _windowWhite = value; OnPropertyChanged(); }
        }
    }
}
