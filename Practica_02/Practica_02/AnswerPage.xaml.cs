﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Practica_02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnswerPage : ContentPage
    {
        public AnswerPage()
        {
            InitializeComponent();
        }

            async void OnPreviousPageButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PopAsync();

            }
        }
}