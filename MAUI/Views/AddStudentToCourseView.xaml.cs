namespace MAUI.Canvas.Views;
public partial class AddStudentToCourseView : ContentPage
{
    public AddStudentToCourseView()
    {
        InitializeComponent();
    }
	private void ReturnToMainPage(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MainPage");
	}
}