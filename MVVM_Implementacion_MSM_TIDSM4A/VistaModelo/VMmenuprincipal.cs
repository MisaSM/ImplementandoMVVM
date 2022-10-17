using MVVM_Implementacion_MSM_TIDSM4A.Modelo;
using MVVM_Implementacion_MSM_TIDSM4A.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Implementacion_MSM_TIDSM4A.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> Menuprincipal { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarelementos();
        }
        public void Mostrarelementos()
        {
            Menuprincipal = new List<Mmenuprincipal>
            {
                new Mmenuprincipal{ Pagina="Entry, datepicker, picker, etc", 
                    Icono="https://i.ibb.co/mXqDN82/pulpo.png"},

                new Mmenuprincipal{ Pagina="CollectionView sin enlace a BD",
                    Icono="https://i.ibb.co/GTNwkNP/pescado.png"},

                new Mmenuprincipal{ Pagina="CRUD Pokemon",
                    Icono="https://i.ibb.co/VYLQb0H/shayming.png"}
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



        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker")) 
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace")) 
            {
                await Navigation.PushAsync(new pagina2());
            }
            if (pagina.Contains("Crud Pokemon")) 
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }

        #endregion
        #region COMANDOS
        //public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion

    }
}
