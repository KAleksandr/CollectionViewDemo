using CollectionView.MVVM.ViewModels;

namespace CollectionView.MVVM.Views;

public partial class LayautPage : ContentPage
{
	public LayautPage()
	{
		InitializeComponent();
		BindingContext = new DataVIewModel();
	}
}