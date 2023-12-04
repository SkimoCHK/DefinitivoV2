using DefinitivoV2.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DefinitivoV2.ViewModel
{
    public class VMrectangulo : BaseViewModel
    {
        #region VARIABLES
        double _Longitud;
        double _Ancho;
        double _Resultado;
        string _Mensaje;

        #endregion

        #region CONSTRUCTORES
        public VMrectangulo(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETOS
        public double Longitud
        {
            get { return _Longitud; }
            set { SetValue(ref _Longitud, value); }
        }
        public double Ancho
        {
            get { return _Ancho; }
            set { SetValue(ref _Ancho, value); }
        }
        public double Resultado
        {
            get { return _Resultado; }
            set { SetValue(ref _Resultado, value); }
        }

        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }

        #endregion

        #region PROCESOS
        
        public void CalcularResultado(double l, double a)
        {
            Resultado = l * a;
        }

        public async void btnCalcular()
        {
            CalcularResultado(Longitud, Ancho);
            if(Longitud == null || Ancho == null && Longitud == 0 || Ancho == 0)
            {
                await DisplayAlert("Mensaje", "Llene todos los campos!", "Salir");
                return;
            }

            if(Resultado > 0)
            {
                Mensaje = "xd";
            }

            await DisplayAlert("Resultado", Mensaje, "Salir");


        }

        #endregion

        #region COMANDOS

        public ICommand CalcularCommand => new Command(btnCalcular);

        #endregion


    }
}
