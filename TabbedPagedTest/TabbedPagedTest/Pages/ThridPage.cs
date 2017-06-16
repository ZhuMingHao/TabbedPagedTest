using Xamarin.Forms;

namespace TabbedPagedTest.Pages
{
    public class ThridPage : ContentPage
    {
        public ThridPage()
        {
          

            Content = new StackLayout
            {
                Children =
                {
                    new Label {
                        Text = "This week's appointments go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}
