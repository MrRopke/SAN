using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialAdd.Model;

namespace SocialAdd.ViewModel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailDetailViewModel : ContentPage
	{
        public Løsninger Løsning { get; set; }
		public DetailDetailViewModel (Løsninger løsning = null)
		{
			InitializeComponent ();
            Løsning = løsning;
		}
	}
}