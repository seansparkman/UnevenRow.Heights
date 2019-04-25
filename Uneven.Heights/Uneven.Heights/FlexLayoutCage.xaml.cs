using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uneven.Heights
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlexLayoutCage : ContentPage, IReloadable
    {
        public FlexLayoutCage()
        {
            InitializeComponent();
        }

        public void OnLoaded()
        {
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var cagesViewModel = new CagesViewModel();

            cagesViewModel.Cages.ForEach(cage =>
            {
                var frame = new Frame
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = Color.Green,
                    Margin = 15,
                    CornerRadius = 20
                };

                var image = new Image
                {
                    Source = ImageSource.FromUri(new Uri(cage.ImageURL))
                };

                frame.Content = image;

                CagesCage.Children.Add(frame);
            });
        }
    }
}