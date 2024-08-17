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
	public partial class VHFooter : ContentView
	{
		public VHFooter ()
		{
			InitializeComponent ();
		}

        /*private async void btn_iniciar_sesion_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new VPPrincipal());
        }

        private void btn_registrar_Clicked(object sender, EventArgs e)
        {

        }*/
    }
}