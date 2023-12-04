using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DefinitivoV2.Vista;

namespace DefinitivoV2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RectanguloView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
