namespace Companions.Views;

public class HomePage : ContentPage
{
	public HomePage()
	{
		CollectionView homeCollectionView = new CollectionView();

		homeCollectionView.Header = new Grid()
		{

		};

		Content = homeCollectionView;
	}
}