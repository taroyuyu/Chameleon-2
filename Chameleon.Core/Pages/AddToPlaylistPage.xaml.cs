﻿using System.ComponentModel;
using Chameleon.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;

namespace Chameleon.Core.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [MvxModalPresentation(WrapInNavigationPage = false)]
    public partial class AddToPlaylistPage : MvxContentPage<AddToPlaylistViewModel>
    {
        public AddToPlaylistPage()
        {
            InitializeComponent();
        }
    }
}
