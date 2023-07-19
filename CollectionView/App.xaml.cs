using CollectionView.MVVM.Views;

namespace CollectionView;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DataView();
	}
}
