using System.Net.Http;
using System.Windows.Input;
using TD.Api.Dtos;
using Xamarin.Forms;
using Storm.Mvvm;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace ProjetXamarin.ViewModels
{
    class AjouterLieuViewModel : ViewModelBase
    {
        public PlaceItem place { get; set; }
        public ImageItem image { get; set; }
        public ICommand Add { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }

        public AjouterLieuViewModel()
        {
            Add = new Command(Ajouter);
        }

        public override async Task OnResume()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            Lattitude = location.Latitude;
            Longitude = location.Longitude;
        }

        private async void Ajouter(object obj)
        {
            ApiClient client = new ApiClient();
            CreatePlaceRequest request = new CreatePlaceRequest();
            request.Title = Name;
            request.Description = Description;
            request.Latitude = Lattitude;
            request.Longitude = Longitude;
            if(image != null)
            {
                request.ImageId = image.Id;
            }
            HttpResponseMessage reponse = await client.Execute(HttpMethod.Post, "https://td-api.julienmialon.com/places", request);
            if (reponse.IsSuccessStatusCode)
            {
                await NavigationService.PopAsync();
            }
        }
    }
}
