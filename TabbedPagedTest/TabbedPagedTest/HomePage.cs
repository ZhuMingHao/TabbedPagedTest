using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPagedTest
{
   public class HomePage :TabbedPage
    {
        public HomePage()
        {
            Children.Add(new NavigationPage(new Pages.FirstPage()) { Title="FirstPage"});
            Children.Add(new NavigationPage(new Pages.SecondPage()) { Title="SecondPage"});
            Children.Add(new NavigationPage(new Pages.ThridPage()) { Title="ThridPage" });


          this.CurrentPage = this.Children[2];
        }
    }
}
