using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Navigation.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamlRuntime.Helpers;

namespace XamlRuntime.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public DelegateCommand OpenNewSimplePageCommand { get; private set; }

        public DelegateCommand OpenNewPageCommand { get; private set; }

        public DelegateCommand OpenNewPage2Command { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            OpenNewSimplePageCommand = new DelegateCommand(async () =>
            {
                // See the sample for the full XAML string
                string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ContentPage xmlns=\"http://xamarin.com/schemas/2014/forms\"\nxmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\nx:Class=\"LoadRuntimeXAML.CatalogItemsPage\"\nTitle=\"Catalog Items\">\n<StackLayout>\n<Label x:Name=\"monkeyName\"\n Text=\"Nome: Thallison\"\n Margin=\"20\"\n  Font=\"Large\"\n  />\n</StackLayout>\n</ContentPage>";

                ContentPage page = new ContentPage().LoadFromXaml(pageXAML);
                await Prism.PrismApplicationBase.Current.MainPage.Navigation.PushAsync(page);
            });

            OpenNewPageCommand = new DelegateCommand(async () =>
            {
                string xaml = $"{RuntimePage.Header}" +
                              $"{RuntimePage.Label}" +
                              $"{RuntimePage.Footer}";
                

                ContentPage page = new ContentPage().LoadFromXaml(xaml);

                var labelWelcome = page.FindByName<Label>("lblWelcome");
                labelWelcome.Text = "Texto alterado com sucesso.!";

                await Prism.PrismApplicationBase.Current.MainPage.Navigation.PushAsync(page);
            });

            OpenNewPage2Command = new DelegateCommand(async () =>
            {
                string xaml = $"{RuntimePage.Header}" + 
                              $"{RuntimePage.StartLabel}lblName1{RuntimePage.EndLabel}" +
                              $"{RuntimePage.StartLabel}lblName2{RuntimePage.EndLabel}" +
                              $"{RuntimePage.Footer}";


                ContentPage page = new ContentPage().LoadFromXaml(xaml);

                var label1 = page.FindByName<Label>("lblName1");
                label1.FontSize = 20;
                label1.Text = "Texto 1° alterado com sucesso.!";

                var label2 = page.FindByName<Label>("lblName2");
                label2.FontSize = 20;
                label2.Text = "Texto 2° alterado com sucesso.!";


                await Prism.PrismApplicationBase.Current.MainPage.Navigation.PushAsync(page);
            });
        }
    }
}
