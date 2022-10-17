using MVVM_Implementacion_MSM_TIDSM4A.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Implementacion_MSM_TIDSM4A.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina2 : ContentPage
    {
        public pagina2()
        {
            InitializeComponent();
            BindingContext = new VMpagina2(Navigation);
        }
    }
}