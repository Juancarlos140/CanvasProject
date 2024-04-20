namespace MAUI.Canvas.Views;
public partial class StudentInfoView : ContentPage
{
    public StudentInfoView()
    {
        InitializeComponent();
    }
	private void ReturnToMainPage(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MainPage");
	}
}