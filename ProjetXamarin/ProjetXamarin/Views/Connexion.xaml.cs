using ProjetXamarin.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Connexion : ContentPage
    {
        public Connexion()
        {
            BindingContext = new ConnexionViewModel();
            InitializeComponent();
        }
    }
}