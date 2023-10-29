using System.Diagnostics;

namespace ControlsDemo.Pages;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        DisplayAlert("Test", "Se ah completado", "Ok");
    }
}