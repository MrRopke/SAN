using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialAdd.ViewModel;

namespace SocialAdd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profil : ContentPage
	{
        ProfilViewModel PViewModel;
		public Profil ()
		{
			InitializeComponent ();
		}
        public Profil(ProfilViewModel pViewModel)
        {
            InitializeComponent();
            PViewModel = pViewModel;

            BindingContext = this.PViewModel = pViewModel;
        }
       
	}
}