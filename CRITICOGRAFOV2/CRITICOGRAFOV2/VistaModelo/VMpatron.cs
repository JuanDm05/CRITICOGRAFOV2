using CRITICOGRAFOV2.VistaModelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CRITICOGRAFOV2.VistaModelo
{
    public class VMpatron : BaseViewModel
    {
        #region Variables
        private string _resultado;
        private string _nombre;
       

        private bool _hombre;
        private bool _mujer;
        private string _generoSeleccionado;
        private bool _feo;
        private bool _grande;
        private bool _alto;
        private bool _extravagante;
        private bool _raro;
        private bool _listo;
        #endregion

        #region Propiedades
        public string GeneroSeleccionado
        {
            get { return _generoSeleccionado; }
            set { SetValue(ref _generoSeleccionado, value); }
        }
        public string nombre
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value); }
        }
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }

        public bool Feo
        {
            get { return _feo; }
            set { SetValue(ref _feo, value); }

        }
     
        public bool Grande
        {
            get { return _grande; }
            set { SetValue(ref _grande, value); }
        }

        public bool Alto
        {
            get { return _alto; }
            set { SetValue(ref _alto, value); }
        }

        public bool Raro
        {
            get { return _raro; }
            set { SetValue(ref _raro, value); }
        }

        public bool Listo
        {
            get { return _listo; }
            set { SetValue(ref _listo, value); }
        }

        public bool Extravagante
        {
            get { return _extravagante; }
            set { SetValue(ref _extravagante, value); }
        }

        public bool Hombre
        {
            get { return _hombre; }
            set
            {
                SetValue(ref _hombre, value);
            }
        }

        public bool Mujer
        {
            get { return _mujer; }
            set
            {
                SetValue(ref _mujer, value);
           
            }
        }
        #endregion
        #region CONSTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Proceso
        public string EstadoRadio()
        {
            if (Hombre)
            {
                return "Hombre";
            }
            else
            {
                return "Mujer";
            }
        }
        private string EstadosDeCheck()
        {
            string auxi = string.Empty;

            if (Hombre)
            {

                if (Alto)
                {
                    auxi += " ALTO";

                }
                if (Raro)
                {
                    auxi += " RARO";

                }
                if (Listo)
                {
                    auxi += " LISTO";

                }
                if (Extravagante)
                {
                    auxi += " EXTRAVAGANTE";

                }
                if (Grande)
                {
                    auxi += " GRANDE";

                }
                if (Feo)
                {
                    auxi += " FEO";
                }
                    
            }
            else if (Mujer)
            {

                if (Alto)
                {
                    auxi += " ALTA";

                }
                if (Raro)
                {
                    auxi += " RARA";

                }
                if (Listo)
                {
                    auxi += " LISTA";

                }
                if (Extravagante)
                {
                    auxi += " EXTRAVAGANTE";

                }
                if (Grande)
                {
                    auxi += " GRANDE";

                }
                if (Feo)
                {
                    auxi += " FEA";

                }
            }

            string[] subs = auxi.Split(' ');

            for (int i = 1; i < subs.Length; i++)
            {
                if (i == 1)
                {
                    auxi = subs[i];
                }
                else if (i == subs.Length - 1)
                {
                    auxi += " Y " + subs[i] + ".";
                }
                else if (i != subs.Length)
                {
                    auxi += ", " + subs[i];
                }
            }

            return auxi;
        }


        public async Task GeneroSeleccionadoProceso()
        {
            Resultado = $"{nombre} ES {EstadosDeCheck()} ";
            GeneroSeleccionado = Resultado; 
        }


        #endregion

        #region Comandos

        public ICommand GeneroSeleccionadoCommand => new Command(async () => await GeneroSeleccionadoProceso());

        #endregion
    }
}
