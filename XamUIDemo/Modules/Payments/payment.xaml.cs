using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using FFImageLoading.Svg;
using FFImageLoading.Transformations;

namespace XamUIDemo.Modules.Payments
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class payment : ContentPage
    {
        public payment()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");
        }
    }
}