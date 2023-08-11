using CollectionView.MVVM.ViewModels;

namespace CollectionView.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductViewModel();
	}
}