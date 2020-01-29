using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using blahblahblah.ViewModel;
using blahblahblah.View;
using System.IO;

namespace blahblahblah.Navigator
{
    public enum ViewModelEnums
    {
        Page1VM = 1,
        Page2VM = 2
    }

    public class NavigatorMenu
    {
        private readonly Dictionary<ViewModelBase, Page> ViewModelViewPair;

        public NavigatorMenu()
        {
            ViewModelViewPair = new Dictionary<ViewModel.ViewModelBase, Page>()
            {
                {new Page1ViewModel(), new Page1() },
                {new Page2ViewModel(), new Page2() },
            };
        }

        public KeyValuePair<ViewModelBase,Page> OpenPage(ViewModelEnums viewModelEnum)
        {
            if(viewModelEnum == ViewModelEnums.Page1VM)
            {
                return ViewModelViewPair.FirstOrDefault();
            }

            else if(viewModelEnum == ViewModelEnums.Page2VM)
            {
                return ViewModelViewPair.LastOrDefault();
            }
            else
            {
                return new KeyValuePair<ViewModelBase, Page>();
            }
        }
    }
}
