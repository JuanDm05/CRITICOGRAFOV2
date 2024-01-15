using CRITICOGRAFOV2.Vista;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CRITICOGRAFOV2.VistaModelo;

namespace CRITICOGRAFOV2.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Criticas : ContentPage
    {
        public Criticas()
        {
            InitializeComponent();
            BindingContext = new VMpatron(Navigation);
        }
    }
}