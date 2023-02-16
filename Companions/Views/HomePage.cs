namespace Companions.Views;

public class HomePage : ContentPage
{
	public HomePage()
	{
		CollectionView homeCollectionView = new CollectionView();

		Content = homeCollectionView;
	}
}