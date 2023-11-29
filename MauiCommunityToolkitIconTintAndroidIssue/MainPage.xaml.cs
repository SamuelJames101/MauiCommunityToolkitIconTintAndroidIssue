using CommunityToolkit.Maui.Behaviors;

namespace MauiCommunityToolkitIconTintAndroidIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        Image myImage = new()
        {
            BackgroundColor = Colors.SeaGreen,
            Source = "dotnet_bot.png",
            HeightRequest = 185,
            Aspect = Aspect.AspectFit
        };

        Image myBrokenImage = new()
        {
            BackgroundColor = Colors.Yellow,
            Source = "dotnet_bot.png",
            HeightRequest = 185,
            Aspect = Aspect.AspectFit
        };

        myImage.Behaviors.Add(new IconTintColorBehavior()
        {
            TintColor = Colors.Black
        });

        myBrokenImage.Behaviors.Add(new IconTintColorBehavior()
        {
            TintColor = null
        });

        VerticalStackLayout myStack = new()
        {
            myImage,
            myBrokenImage
        };

        ScrollView scrollView = new()
        {
            Content = myStack
        };

        this.Content = scrollView;
	}
}