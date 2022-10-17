using MVVM_Implementacion_MSM_TIDSM4A.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementacion_MSM_TIDSM4A.Modelo;
namespace MVVM_Implementacion_MSM_TIDSM4A.VistaModelo
{
    public class VMpagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        public void Mostrarusuarios() 
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios{ Nombre="Sofia" ,Imagen="https://i.ibb.co/7K69gbW/hedgehog.png"},
                new Musuarios{ Nombre="Fofo" ,Imagen="https://i.ibb.co/LYdx6HM/pizza.png"},
                new Musuarios{ Nombre="Olivia",Imagen="https://i.ibb.co/1MFrVD6/flower.png"}
            };
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
