using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Storm.Mvvm;
using ProjetXamarin.Views;

namespace ProjetXamarin
{
    public partial class App : MvvmApplication
    {
        public App() : base(() => new Connexion())
        {
            InitializeComponent();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
