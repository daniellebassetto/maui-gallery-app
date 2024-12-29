using GalleryApp.Repositories;

namespace GalleryApp.Views;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();

        var categories = new CategoryRepository().GetCategories();

        foreach (var category in categories)
        {
            var lblCategory = new Label
            {
                Text = category.Name,
                FontFamily = "OpenSansSemibold",
                TextColor = Colors.Black
            };

            MenuContainer.Children.Add(lblCategory);

            foreach (var component in category.Components)
            {
                var tap = new TapGestureRecognizer();
                tap.CommandParameter = component.Page;
                tap.Tapped += OnTapComponent;

                var lblComponentTitle = new Label
                {
                    Text = component.Title,
                    FontFamily = "OpenSansSemibold",
                    Margin = new Thickness(20, 20, 0, 0),
                    TextColor = Colors.Black,
                };

                lblComponentTitle.GestureRecognizers.Add(tap);

                var lblComponentDescription = new Label
                {
                    Text = component.Description,
                    Margin = new Thickness(20, 0, 0, 0),
                    TextColor = Colors.Black
                };

                lblComponentDescription.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(lblComponentTitle);
                MenuContainer.Children.Add(lblComponentDescription);
            }
        }
    }

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        var label = (Label)sender;
        var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
        var page = (Type)tap.CommandParameter!;

        ((FlyoutPage)App.Current!.MainPage!).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void OnTapInicio(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current!.MainPage!).Detail = new NavigationPage(new MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}