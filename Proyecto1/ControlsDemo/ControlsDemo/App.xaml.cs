﻿using ControlsDemo.Pages;

namespace ControlsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PresentationControlsDemo();
        }
    }
}