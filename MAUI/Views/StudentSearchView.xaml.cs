namespace MAUI.Canvas.Views;
public partial class StudentSearchView : ContentPage
{
    public StudentSearchView()
    {
        InitializeComponent();
    }
    private void StudentSelected(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//Students2");
	}
	private void ReturnToMainPage(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MainPage");
	}
}