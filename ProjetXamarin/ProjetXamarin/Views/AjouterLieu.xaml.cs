using ProjetXamarin.ViewModels;
using Xamarin.Forms.Xaml;
using Storm.Mvvm.Forms;

namespace ProjetXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjouterLieu : BaseContentPage
    {
        public AjouterLieu()
        {
            BindingContext = new AjouterLieuViewModel();
            InitializeComponent();
        }
    }
}