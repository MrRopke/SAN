using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialAdd.Model;
using System.Diagnostics;
using System.Collections.ObjectModel;
using SocialAdd.ViewModel;

namespace SocialAdd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BlogDetail : ContentPage
	{
        public string Gruppe = "";

        public ObservableCollection<Løsninger> Løsninger = new ObservableCollection<Model.Løsninger>
        {
            new Model.Løsninger() {Lid = 1, Overskrift = "Mulighed 1", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Søvn", Forfatter = "Theis", AntalLikes = 11, Dato = DateTimeOffset.Now, Bid = 1, FordeleKommentarer = 22, UlempeKommentarer = 6},
            new Model.Løsninger() {Lid = 2, Overskrift = "Mulighed 2", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Søvn", Forfatter = "Theis", AntalLikes = 24, Dato = DateTimeOffset.Now, Bid = 1, FordeleKommentarer = 11, UlempeKommentarer = 22},
            new Model.Løsninger() {Lid = 3, Overskrift = "Mulighed 3", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Søvn", Forfatter = "Theis", AntalLikes = 36, Dato = DateTimeOffset.Now, Bid = 1, FordeleKommentarer = 45, UlempeKommentarer = 31},
            new Model.Løsninger() {Lid = 4, Overskrift = "Mulighed 4", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Søvn", Forfatter = "Theis", AntalLikes = 41, Dato = DateTimeOffset.Now, Bid = 2, FordeleKommentarer = 12, UlempeKommentarer = 54},
            new Model.Løsninger() {Lid = 5, Overskrift = "Mulighed 5", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Søvn", Forfatter = "Theis", AntalLikes = 12, Dato = DateTimeOffset.Now, Bid = 1, FordeleKommentarer = 66, UlempeKommentarer = 1},
            new Model.Løsninger() {Lid = 6, Overskrift = "Mulighed 6", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Søvn", Forfatter = "Theis", AntalLikes = 18, Dato = DateTimeOffset.Now, Bid = 1, FordeleKommentarer = 32, UlempeKommentarer = 14},
            new Model.Løsninger() {Lid = 7, Overskrift = "Mulighed 1", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Struktur", Forfatter = "Theis", AntalLikes = 101, Dato = DateTimeOffset.Now, Bid = 2, FordeleKommentarer = 2, UlempeKommentarer = 9},
            new Model.Løsninger() {Lid = 8, Overskrift = "Mulighed 2", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Struktur", Forfatter = "Theis", AntalLikes = 89, Dato = DateTimeOffset.Now, Bid = 2, FordeleKommentarer = 9, UlempeKommentarer = 12},
            new Model.Løsninger() {Lid = 9, Overskrift = "Mulighed 3", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Struktur", Forfatter = "Theis", AntalLikes = 43, Dato = DateTimeOffset.Now, Bid = 2, FordeleKommentarer = 73, UlempeKommentarer = 10},
            new Model.Løsninger() {Lid = 10, Overskrift = "Mulighed 4", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Struktur", Forfatter = "Theis", AntalLikes = 21, Dato = DateTimeOffset.Now, Bid = 2, FordeleKommentarer = 35, UlempeKommentarer = 18},
            new Model.Løsninger() {Lid = 11, Overskrift = "Mulighed 5", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Struktur", Forfatter = "Theis", AntalLikes = 76, Dato = DateTimeOffset.Now, Bid = 1, FordeleKommentarer = 19, UlempeKommentarer = 25},
            new Model.Løsninger() {Lid = 12, Overskrift = "Mulighed 6", Brødtekst = "Dette er brødtekst til mit eksempel", Gruppe = "Struktur", Forfatter = "Theis", AntalLikes = 45, Dato = DateTimeOffset.Now, Bid = 1, FordeleKommentarer = 16, UlempeKommentarer = 22},
        };

        List<Bruger> BrugerListe = new List<Bruger>
        {
            new Bruger() {BrugerId = 1, Brugernavn = "Theis", Email = "Theis1@Theis.dk", Fornavn = "Theis1", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 2, Brugernavn = "Theis1", Email = "Theis2@Theis.dk", Fornavn = "Theis2", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 3, Brugernavn = "Theis2", Email = "Theis3@Theis.dk", Fornavn = "Theis3", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 4, Brugernavn = "Theis3", Email = "Theis4@Theis.dk", Fornavn = "Theis4", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
        };
        

        public ObservableCollection<Løsninger> Løsninger2 = new ObservableCollection<Model.Løsninger>();

        Løsninger løsning = new Model.Løsninger();

        public BlogDetail ()
		{
			InitializeComponent ();

        }

        public BlogDetail(string gruppe)
        {
            InitializeComponent();            
            Gruppe = gruppe;
            FindLøsninger();            
            LøsningerView.ItemsSource = Løsninger2;            
        }
                       

        private async void LøsningTapped(object sender, ItemTappedEventArgs e)
        {
            var løsning = e.Item as Løsninger;
            await Navigation.PushAsync(new DetailDetail(new DetailDetailViewModel(løsning)));
        }

        public void FindLøsninger()
        {            
            foreach (var løsning in Løsninger)
            {

                if (løsning.Gruppe == Gruppe)
                {
                    Løsninger2.Add(løsning);
                }
            }
        }

        public void SorterEfterLikes(object sender, EventArgs e)
        {
            Løsninger2 = new ObservableCollection<Løsninger>(Løsninger2.OrderBy(løsning => løsning.AntalLikes).Reverse());
            LøsningerView.ItemsSource = Løsninger2;
        }

        public void SorterEfterDato(object sender, EventArgs e)
        {
            Løsninger2 = new ObservableCollection<Løsninger>(Løsninger2.OrderBy(løsning => løsning.Dato));
            LøsningerView.ItemsSource = Løsninger2;
        }



    }
}