using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;
using System.Diagnostics;
using SocialAdd.Model;

namespace SocialAdd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TilføjRåd : ContentPage
	{
        Home home = new Home();
		public TilføjRåd ()
		{
			InitializeComponent ();
            VisGenreValg();
            
		}

        public void VisGenreValg()
        {
            GenreValgListView.ItemsSource = home.GenreValg;
            ValgteListView.ItemsSource = home.Valgte;
        }

        public void TilføjValgte(object sender, ItemTappedEventArgs e)
        {
            bool ErValgt = false;

            foreach (var valg in home.Valgte)
            {
                if(valg == e.Item.ToString())
                {
                    ErValgt = true;
                }
            }
            
            if (ErValgt == false)
            {
                home.Valgte.Add(e.Item.ToString());
            }
            
        }

        public void FjernValgte(object sender, ItemTappedEventArgs e)
        {
            home.Valgte.Remove(e.Item.ToString());
        }

        public void SendOpslag(object sender, EventArgs e)
        {

        }
	}
}