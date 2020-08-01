using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrastModifier
{
    class ViewModel : PropChanged
    {
        private static ViewModel instance = new ViewModel();

        private ViewModel()
        {

        }

        public static ViewModel Instance => instance;

        private bool _MainWhite = false;
        public bool MainWhite
        {
            get => _MainWhite;
            set { _MainWhite = value; OnPropertyChanged(); }
        }
    }
}
