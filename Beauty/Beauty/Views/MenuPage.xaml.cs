using Beauty.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Beauty.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage, IMenuPage
	{
		public MenuPage ()
		{
            try
            {
                InitializeComponent();
                BindingContext = new MenuViewModel(this);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void GoToPage(Type target)
        {
            ((MainPage)Parent).Detail = new NavigationPage((Page)Activator.CreateInstance(target));
            ((MainPage)Parent).IsPresented = false;
        }
    }
}