﻿using App6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicio : ContentPage
    {
        public PaginaInicio()
        {
            InitializeComponent();
            BindingContext = new PaginaInicioViewModel(Navigation);
        }
    }
}