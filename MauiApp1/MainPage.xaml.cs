namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void NewOnCounterClicked(object sender, EventArgs e)
	{
		count++;



		Console.WriteLine("");
		if (count == 1)
			NewBtn.Text = $"Clicked -{count} time do not click";
		else
			NewBtn.Text = $"Clicked -{count} times";

		SemanticScreenReader.Announce(NewBtn.Text);
	}
}

