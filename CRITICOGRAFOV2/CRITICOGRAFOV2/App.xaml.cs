using CRITICOGRAFOV2.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRITICOGRAFOV2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new Critica();
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
