using Beauty.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Beauty.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
	}
}