using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReusableContentView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarView : Frame
    {
        public BarView()
        {
            InitializeComponent();
        }
    }
}