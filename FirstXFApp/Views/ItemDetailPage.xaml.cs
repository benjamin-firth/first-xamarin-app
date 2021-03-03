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
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();

            BindingContext = Note;
            NoteCourse.BindingContext = this;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();



            BindingContext = Note;
            NoteCourse.BindingContext = this;
        }

        async void InitializeData()
        {
            var pluralsightDataStore = new MockPluralsightDataStore();
            CourseList = await pluralsightDataStore.GetCoursesAsync();

            Note = new Note {
                Heading = "Test Note",
                Text = "Text for test note."
            };
        }

        public void Cancel_Clicked(object sender, EventArgs args)
        {
            DisplayAlert("Cancelled!", "Cancel successful", "Accept", "Deny");
        }

        public void Save_Clicked(object sender, EventArgs args)
        {
            DisplayAlert("Saved!", "Save successful", "Accept", "Deny");
        }
    }
}