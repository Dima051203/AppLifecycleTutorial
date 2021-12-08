using AppLifecycleTutorial.Services;
using AppLifecycleTutorial.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLifecycleTutorial
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
    }
}
