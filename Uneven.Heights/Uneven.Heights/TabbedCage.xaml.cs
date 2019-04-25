using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uneven.Heights
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedCage : TabbedPage, IReloadable
    {
        public TabbedCage()
        {
            InitializeComponent();
        }

        public void OnLoaded()
        {
        }
    }
}