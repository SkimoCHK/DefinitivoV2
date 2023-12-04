using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefinitivoV2.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DefinitivoV2.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RectanguloView : ContentPage
    {
        public RectanguloView()
        {
            InitializeComponent();
            BindingContext = new VMrectangulo(Navigation);
        }
    }
}