using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialAdd.Model;
using SocialAdd.ViewModel;

namespace SocialAdd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailDetail : ContentPage
	{
        DetailDetailViewModel DViewModel;
       
		public DetailDetail ()
		{
			InitializeComponent ();
		}

        public DetailDetail(DetailDetailViewModel dViewModel)
        {
            Home home = new Home();
            InitializeComponent();
            DViewModel = dViewModel;
            BindingContext = this.DViewModel = dViewModel;
        }

        public void VisFordele(object sender, EventArgs args)
        {
            Home home = new Home();
            KommentarFarve.BackgroundColor = Color.FromHex("#ccffe6"); //Color.FromHex("#66ffb3");
            KommentarView.ItemsSource = home.KommentarListe();
            SkrivKommentarKnap.IsVisible = true;
        }

        public void VisUlemper(object sender, EventArgs args)
        {
            Home home = new Home();
            KommentarFarve.BackgroundColor = Color.FromHex("#ff8080");
            KommentarView.ItemsSource = home.KommentarListe();
            SkrivKommentarKnap.IsVisible = true;
        }

        public void SkrivKommentar(object sender, EventArgs args)
        {
            SkrivKommentarKnap.IsVisible = false;
            SkrivKommentarStack.IsVisible = true;
        }
    }
}