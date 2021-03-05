using System;
using System.Collections.Generic;
using FirstXFApp.Models;

namespace FirstXFApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public String NoteHeading
        {
            get { return Note.Heading; }
            set
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }

        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            InitializeCourseList();
            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for note in ViewModal",
                Course = CourseList[0]
            };
        }

        async void InitializeCourseList()
        {
            CourseList = await PluralsightDataStore.GetCoursesAsync();
        }
    }
}
