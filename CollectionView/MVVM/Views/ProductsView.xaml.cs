using CollectionView.MVVM.ViewModels;
using System.Diagnostics;

namespace CollectionView.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductViewModel();
	}

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		Debug.Write("--------------------------------------------------------------");
		Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
		Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
		Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
		Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
		Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
		Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
		Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
        Debug.Write("--------------------------------------------------------------");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var vm = BindingContext as ProductViewModel;
		var product = vm.Products
			.SelectMany(p => p)
			.FirstOrDefault(x => x.Id == 10);
		collectionView.ScrollTo(product, animate:false, position: ScrollToPosition.Center);
    }
}