using Xamarin.Forms;

namespace TabbedPagedTest.Pages
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
           
            var button = new Button { Text = "ClickMe" };
            button.Clicked += Button_Clicked;
            Content = new StackLayout
            {
                Children =
                {
                    new Label {
                        Text = "This week's appointments go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    button,
                }
            };

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
          
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

    }
}

