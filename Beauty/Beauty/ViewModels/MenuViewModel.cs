using Beauty.Models;
using Beauty.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Beauty.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<MenuModel> menu;
        private MenuModel selectedMenuItem;
        private IMenuPage view;
        #endregion

        #region Properties
        public ObservableCollection<MenuModel> Menu
        {
            get { return menu; }
            set { SetProperty(ref menu, value); }
        }

        public MenuModel SelectedMenuItem
        {
            get { return selectedMenuItem; }
            set {
                SetProperty(ref selectedMenuItem, value);
                view.GoToPage(value?.TargetType);
            }
        }
        #endregion

        #region ctor
        public MenuViewModel(IMenuPage view)
        {
            this.view = view;
            Menu = new ObservableCollection<MenuModel> {
                new MenuModel{ Title="Запись", Icon="icon.png", TargetType = typeof(AboutPage)},
                new MenuModel{ Title="Новости", Icon="icon.png", TargetType = typeof(AboutPage)},
                new MenuModel{ Title="Акции", Icon="icon.png", TargetType = typeof(AboutPage)},
                new MenuModel{ Title="О программе", Icon="icon.png", TargetType = typeof(SecondPage)},
            };
        }
        #endregion
    }
}
