using Xamarin.Forms;

namespace TabbedPagedTest.Pages
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
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

    }
}
