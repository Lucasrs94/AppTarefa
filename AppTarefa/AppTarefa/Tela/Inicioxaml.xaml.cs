using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarefa.Tela
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicioxaml : ContentPage
	{
		public Inicioxaml ()
		{
			InitializeComponent ();
		}
        private void ActionCadastro(object sender, EventArgs args)
        {
            // Chamo a tela cadastro
            Navigation.PushAsync(new Cadastro());
        }


    }
}