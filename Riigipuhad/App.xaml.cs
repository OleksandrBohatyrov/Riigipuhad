﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Riigipuhad();
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
