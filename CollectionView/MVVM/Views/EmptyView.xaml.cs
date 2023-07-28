namespace CollectionView.MVVM.Views;

public partial class EmptyView : ContentPage
{
	public EmptyView()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		var isTaggled = e.Value;
		CollectionView.EmptyView = isTaggled ? Resources["NoResultsView"] : Resources["ConnectivityIssue"];
    }
}