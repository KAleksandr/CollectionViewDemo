using CollectionView.MVVM.ViewModels;

namespace CollectionView.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataVIewModel();

    }
}