using System;
using System.ComponentModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FirstXFApp.Models;
using FirstXFApp.ViewModels;
using NoteKeeper.Services;

namespace FirstXFApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }

        public void Cancel_Clicked(object sender, EventArgs args)
        {
            viewModel.NoteHeading = "XXXXX";
            DisplayAlert("Cancelled!", $"Heading value is {viewModel.Note.Heading}", "Accept", "Deny");
        }

        public void Save_Clicked(object sender, EventArgs args)
        {
            DisplayAlert("Saved!", "Save successful", "Accept", "Deny");
        }
    }
}