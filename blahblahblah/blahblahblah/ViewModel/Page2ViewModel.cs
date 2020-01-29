using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace blahblahblah.ViewModel
{
    public class Page2ViewModel : ViewModelBase
    {
        private int counter;
        public int Counter
        {
            get { return counter; }
            set { counter = value; OnPropertyChanged(); }
        }


        public Page2ViewModel()
        {
            Counter = 0;
        }

        public ICommand ChangePage
        {
            get
            {
                return new RelayCommand(
                    obj =>
                    {
                        Counter++;
                        changePageDelegate?.Invoke();
                    });
            }
        }
    }
}
