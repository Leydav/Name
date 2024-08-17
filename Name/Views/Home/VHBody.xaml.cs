using Name.Views.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Name.Views.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VHBody : ContentView
	{
		public VHBody ()
		{
			InitializeComponent ();
		}

        private async void btn_iniciar_sesion_Clicked(object sender, EventArgs e)
        {
            string usuario = "admin";
            string pass = "admin";

            string usuario_ingresado = txt_usuario.Text;
            string contrasenia_ingresada = txt_contrasenia.Text;

            if (usuario==usuario_ingresado && pass == contrasenia_ingresada){
                await Navigation.PushModalAsync(new VPPrincipal());
            }
            else
            {
                lblResultado.Text = "DENEGADO";
                txt_usuario.Text = "";
                txt_contrasenia.Text = "";
            }
        }

        private void btn_registrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}