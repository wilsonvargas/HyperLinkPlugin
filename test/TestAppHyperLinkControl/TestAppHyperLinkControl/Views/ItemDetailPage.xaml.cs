using TestAppHyperLinkControl.Models;
using TestAppHyperLinkControl.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppHyperLinkControl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private ItemDetailViewModel viewModel;
    }
}
