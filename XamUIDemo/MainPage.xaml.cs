using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamUIDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected void ClickLoginPage(object sender, EventArgs e)
        {
            try
             {
                Crashes.GenerateTestCrash();
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>()
                {
                    { "isLogin",  "teste" },
                    { "new",  "teste" }
                });
            }
          
        }
        protected void ClickDellyShop(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Teste mapemento de eventos");
        }
        protected void ClickXFShop(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://codecanyon.net/item/xfshop-ecommerce-application-template-cross-platformandroidios/24853588"));

        }
    }
}
