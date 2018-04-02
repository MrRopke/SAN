using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialAdd.Model;
using System.Collections.ObjectModel;

namespace SocialAdd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Chat : ContentPage
	{
        ObservableCollection<Besked> Beskeder = new ObservableCollection<Besked>
        {
            new Besked() {BeskedId = 1, Beskeden = "Dette er en test besked", AfsenderId = 1, ModtagerId = 2, AfsenderNavn = "Theis Røpke"},
            new Besked() {BeskedId = 2, Beskeden = "Dette er en test besked 2", AfsenderId = 2, ModtagerId = 1, AfsenderNavn = "Theis Jørgensen"},
            new Besked() {BeskedId = 3, Beskeden = "Dette er en test besked 3", AfsenderNavn = "Theis Jørgensen"},
            new Besked() {BeskedId = 4, Beskeden = "Dette er en test besked 4", AfsenderNavn = "Theis Jørgensen"},
            new Besked() {BeskedId = 5, Beskeden = "Dette er en test besked 5", AfsenderNavn = "Theis Jørgensen"},
            new Besked() {BeskedId = 6, Beskeden = "Dette er en test besked 6", AfsenderNavn = "Theis Røpke"},
            new Besked() {BeskedId = 7, Beskeden = "Dette er en test besked 7", AfsenderNavn = "Theis Røpke"},
            new Besked() {BeskedId = 8, Beskeden = "Dette er en test besked 8", AfsenderNavn = "Theis Røpke"},
        };

        List<Bruger> BrugerListe = new List<Bruger>
        {
            new Bruger() {BrugerId = 1, Brugernavn = "Theis", Email = "Theis1@Theis.dk", Fornavn = "Theis1", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 2, Brugernavn = "Theis1", Email = "Theis2@Theis.dk", Fornavn = "Theis2", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 3, Brugernavn = "Theis2", Email = "Theis3@Theis.dk", Fornavn = "Theis3", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
            new Bruger() {BrugerId = 4, Brugernavn = "Theis3", Email = "Theis4@Theis.dk", Fornavn = "Theis4", Efternavn = "Røpke", Alder = 30, BorI = "Valby", Relation = "Pårørende"},
        };

        public Chat ()
		{   
			InitializeComponent();            
            ChatView.ItemsSource = Beskeder;
            BrugerView.ItemsSource = BrugerListe;
		}


        public string AfsenderNavn(int BrugerId)
        {
            string Afsendernavn = "";
            foreach (var bruger in BrugerListe)
            {
                if (BrugerId == bruger.BrugerId)
                {
                    Afsendernavn =  bruger.Brugernavn;
                }                
            }

            return Afsendernavn;
        }

        public void SkrivChatBesked(object sender, EventArgs e)
        {
            Home home = new Home();
            Besked besked = new Besked();
            besked.Beskeden = BeskedEntry.Text;
            besked.AfsenderId = home.DenneBrugersId();
            besked.AfsenderNavn = AfsenderNavn(home.DenneBrugersId());

            Beskeder.Add(besked);
        }
	}
}