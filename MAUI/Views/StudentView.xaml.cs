namespace MAUI.Canvas.Views;
public partial class StudentView : ContentPage
{
    public StudentView()
    {
        InitializeComponent();
    }
    private void StudentInfoView(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//StudentInfo");
	}

	private void ReturnToMainPage(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MainPage");
	}
}