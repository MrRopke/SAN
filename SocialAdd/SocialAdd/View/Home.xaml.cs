using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using SocialAdd.ViewModel;
using SocialAdd.Model;
using System.Collections.ObjectModel;

namespace SocialAdd.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : MasterDetailPage
    {

        List<Bruger> BrugerListe = new List<Bruger>
        {
            new Bruger() {BrugerId = 1, Brugernavn = "Theis", Email = "Theis1@Theis.dk", Fornavn = "Theis1", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 2, Brugernavn = "Theis1", Email = "Theis2@Theis.dk", Fornavn = "Theis2", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 3, Brugernavn = "Theis2", Email = "Theis3@Theis.dk", Fornavn = "Theis3", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 4, Brugernavn = "Theis3", Email = "Theis4@Theis.dk", Fornavn = "Theis4", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
        };

        ObservableCollection<ProCons> Kommentarer = new ObservableCollection<ProCons>
        {
            new ProCons() {PCId = 1, Overskrift = "Overskrift 1", Kommentar = "Dette er fordels-kommentar 1", Likes = 22, LøsningId = 1, ProEllerCon = "Fordel"},
            new ProCons() {PCId = 1, Overskrift = "Overskrift 2", Kommentar = "Dette er fordels-kommentar 2", Likes = 12, LøsningId = 1, ProEllerCon = "Fordel"},
            new ProCons() {PCId = 1, Overskrift = "Overskrift 3", Kommentar = "Dette er fordels-kommentar 3", Likes = 43, LøsningId = 1, ProEllerCon = "Fordel"},
            new ProCons() {PCId = 1, Overskrift = "Overskrift 4", Kommentar = "Dette er fordels-kommentar 4", Likes = 7, LøsningId = 1, ProEllerCon = "Fordel"},
            new ProCons() {PCId = 1, Overskrift = "Overskrift 5", Kommentar = "Dette er fordels-kommentar 5", Likes = 2, LøsningId = 1, ProEllerCon = "Ulempe"},
            new ProCons() {PCId = 1, Overskrift = "Overskrift 6", Kommentar = "Dette er fordels-kommentar 6", Likes = 8, LøsningId = 1, ProEllerCon = "Ulempe"},
            new ProCons() {PCId = 1, Overskrift = "Overskrift 7", Kommentar = "Dette er fordels-kommentar 7", Likes = 16, LøsningId = 1, ProEllerCon = "Ulempe"},
            new ProCons() {PCId = 1, Overskrift = "Overskrift 8", Kommentar = "Dette er fordels-kommentar 8", Likes = 19, LøsningId = 1, ProEllerCon = "Ulempe"},

        };

        public ObservableCollection<String> GenreValg = new ObservableCollection<string>()
        {
            "Søvn", "Struktur", "Indre Ro", "Fokus", "Arbejde", "Tanker"
        };

        public ObservableCollection<String> Valgte = new ObservableCollection<string>();


        public int BrugerId = 1;
        public Home()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        public int DenneBrugersId()
        {
            return BrugerId;
        }

        public ObservableCollection<ProCons> KommentarListe()
        {
            return Kommentarer;
        }
                        
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HomeMenuItem;
            if (item == null)
                return;

            if (item.Title == "Home")
            {
                Detail = new NavigationPage(new HomeDetail());
            }

            if (item.Title == "Bruger Råd")
            {
                Detail = new NavigationPage(new Blog());
            }

            if (item.Title == "Tilføj Råd")
            {
                Detail = new NavigationPage(new TilføjRåd());
            }

            if (item.Title == "Chat")
            {
                Detail = new NavigationPage(new Chat());
            }
            if (item.Title == "Profil")
            {
                foreach (var bruger in BrugerListe)
                {
                    if(bruger.BrugerId == BrugerId)
                    {
                        Detail = new NavigationPage(new Profil(new ProfilViewModel(bruger)));
                    }
                }   
                
            }
            //var page = (Page)Activator.CreateInstance(item.TargetType);
            //page.Title = item.Title;

            //Detail = new NavigationPage(page);
            //IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}