using GAppMAUI.Tabs;

namespace GAppMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LogBookPage), typeof(LogBookPage));
	}
}
