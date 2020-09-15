using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Github_Test.Services;
using Github_Test.Views;

namespace Github_Test
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
