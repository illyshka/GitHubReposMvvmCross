﻿using GitHubReposMvvmCross.Core.ViewModels;
using GitHubReposMvvmCross.Core.ViewModels.Home;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitHubReposMvvmCross.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class RepInfoPage : MvxContentPage<RepInfoViewModel>
    {
        public RepInfoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.BarTextColor = Color.White;
                navigationPage.BarBackgroundColor = (Color)Application.Current.Resources["PrimaryColor"];
            }
        }
    }
}