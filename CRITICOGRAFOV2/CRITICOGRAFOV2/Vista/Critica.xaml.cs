using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRITICOGRAFOV2.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRITICOGRAFOV2.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Critica : ContentPage
    {
        public Critica()
        {
            InitializeComponent();
            BindingContext = new VMpatron(Navigation);
        }
    }
}