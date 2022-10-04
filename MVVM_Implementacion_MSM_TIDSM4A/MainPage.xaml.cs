using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM_Implementacion_MSM_TIDSM4A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Alerta()
        {
            DisplayAlert("Alerta", "Esta es una alerta", "Okay");
        }
        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Alerta();
        }



    }
}
