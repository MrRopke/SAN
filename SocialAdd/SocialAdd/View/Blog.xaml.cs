using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialAdd;
using SocialAdd.View;

namespace SocialAdd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Blog : ContentPage
	{        
		public Blog ()
		{
			InitializeComponent ();            
        }
        
        public async void StackTapped(TappedEventArgs args)
        {            
            await Navigation.PushAsync(new BlogDetail(args.Parameter.ToString()));
        }

    }
}