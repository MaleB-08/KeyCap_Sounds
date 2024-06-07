﻿
namespace KeyCap_Sounds
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newHeight = 400;
            const int newWidth = 400;


            window.Height = newHeight;
            window.Width = newWidth;

            return window;
        }
    }
}
