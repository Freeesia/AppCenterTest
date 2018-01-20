using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace AppCenterTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppCenterTestPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start($"android=fd6e4bc1-223d-4a9c-9ff4-b032a89d48a9;ios=9b3124ff-ff9b-41e7-9c2f-d4dd7d076c4f",
    typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
