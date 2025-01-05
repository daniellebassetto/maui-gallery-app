namespace MAUIGalleryApp.Views.Components.Mains;

public partial class ImagePage : ContentPage
{
	public ImagePage()
	{
		InitializeComponent();
		Imagem01.Source = ImageSource.FromUri(new Uri("https://hermes.dio.me/articles/cover/38edaf0f-382f-4dff-b3ae-43ac0b5ddbef.png"));
    }
}