using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public const string Crash = "Crash";

        public MainPage()
        {
            InitializeComponent();
        }

        void FormsCrashBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            throw new Exception("Crash from forms' layer");
        }

        void PlatformCrashBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            MessagingCenter.Send(new object(), Crash);
        }
    }
}
