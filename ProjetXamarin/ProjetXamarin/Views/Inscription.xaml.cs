﻿using ProjetXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inscription : ContentPage
    {
        public Inscription()
        {
            BindingContext = new InscriptionViewModel();
            InitializeComponent();
        }
    }
}