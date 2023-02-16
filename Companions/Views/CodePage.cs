namespace Companions.Views;

public class CodePage : ContentPage
{
	public CodePage()
	{
		var verticalStackLayout = new VerticalStackLayout();

		var label = new Label()
		{
			TextColor = Color.FromRgb(255, 255, 255),
		};
		TestViewModel t = new TestViewModel();
		label.BindingContext = t;
		Binding b = new Binding("IsLoading", source: t);

		label.SetBinding(Label.TextProperty, b);

		verticalStackLayout.Children.Add(label);


		var scrollView = new ScrollView();
		scrollView.Content = verticalStackLayout;
		Content = scrollView;

		//homeContent.SetAppThemeColor(BackgroundColorProperty, light: Color.FromRgb(0, 0, 0), dark: Color.FromRgb(0, 0, 0));
		Content.SetAppThemeColor(BackgroundColorProperty, light: Color.FromRgb(0, 0, 0), dark: Color.FromRgb(0, 0, 0));
    }
}