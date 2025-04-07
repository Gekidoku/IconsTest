namespace IconsTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		//Capitalized L is from xcassets lowercase l is from resources/mauiimage
		//To change just 
		 var testitem = new ToolbarItem()
            {
                
                Order = ToolbarItemOrder.Primary,
                Priority = 1
                ,IconImageSource = ImageSource.FromFile("Licht.png")
            };
            
            ToolbarItems.Add(testitem);
			var testitem2 = new ToolbarItem()
            {
                
                Order = ToolbarItemOrder.Primary,
                Priority = 1
                ,IconImageSource = ImageSource.FromFile("licht.png")
            };
            
            ToolbarItems.Add(testitem2);
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
}

