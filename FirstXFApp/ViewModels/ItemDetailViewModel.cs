using System;

using FirstXFApp.Models;

namespace FirstXFApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Note = new Note { Heading = "Test note", Text = "Text for note in ViewModal" };
        }
    }
}
