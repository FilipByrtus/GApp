using GAppMAUI.Tabs;

namespace GAppMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void LogBookPage_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(LogBookPage));
	}

    private void Entry_Completed(object sender, EventArgs e)
    {
		//CounterBtn.Text = (sender as Entry)?.Text;
    }
}

