using ProjetXamarin.ViewModels;
using Xamarin.Forms.Xaml;
using Storm.Mvvm.Forms;

namespace ProjetXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsLieu : BaseContentPage
    {
        public DetailsLieu(int Id)
        {
            BindingContext = new DetailsLieuViewModel(Id);
            InitializeComponent();
        }
    }
}