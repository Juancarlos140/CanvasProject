namespace MAUI.Canvas;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void Instructor_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//Instructors");
	}

	private void Student_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//StudentSearch");
	}
}

