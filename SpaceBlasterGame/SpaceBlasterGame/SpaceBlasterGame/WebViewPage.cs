using System.IO;
using Xamarin.Forms;

namespace SpaceBlasterGame
{
    class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            Label header = new Label
            {
                Text = "Xamarin & Construct2",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            var source = new HtmlWebViewSource();
            var assetManager = Xamarin.Forms.Forms.Context.Assets;
            using (var streamReader = new StreamReader(assetManager.Open("index.html")))
            {
                source.Html = streamReader.ReadToEnd();
            }
            
            WebView webView = new WebView
            {
                Source = source,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    webView
                }
            };
        }
    }

}
