using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls;

namespace ItemTemplateTest
{
    public sealed partial class MainPage : Page
    {
        private byte[] _items => new byte[100];

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is string[] dateTemplateNames && dateTemplateNames.Length == 2)
            {
                ChangeItemTemplate(ItemsRepeaterLeft, dateTemplateNames[0]);
                ChangeItemTemplate(ItemsRepeaterRight, dateTemplateNames[1]);
            }
        }

        private void ChangeItemTemplate(ItemsRepeater itemsRepeater, string dateTemplateName)
        {
            itemsRepeater.ItemTemplate = Resources[dateTemplateName] as DataTemplate;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), new[] {"Template2", "Template1"});
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), new[] {"Template1", "Template1"});
        }
    }
}
