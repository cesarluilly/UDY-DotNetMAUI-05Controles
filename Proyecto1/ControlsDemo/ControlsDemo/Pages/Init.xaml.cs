namespace ControlsDemo.Pages;

public partial class Init : ContentPage
{
	public Init()
	{
		InitializeComponent();
	}

    private void btnPresentation_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PresentationControlsDemo());
    }

    private void btnCommands_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CommandsControlsDemo());
    }

    private void btnInput_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputControlsDemo());
    }

    private void btnText_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TextControlsDemo());
    }

    private void btnActivity_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActivityControlsDemo());
    }

    private void btnCollectionCarousel_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionsControlsDemo());
    }

    private void btnCollectionListView_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionsControlsDemo2ListView());
    }

    private void btnCollectionView_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionsControlsDemo3CollectionView());
    }

    private void btnCollectionPicker_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionsControlsDemo4Picker());
    }

    private void btnCollectionTableView_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionsControlsDemo5TableView());
    }
}