using MAUI.Canvas.ViewModels;

//using MAUI.Canvas.ViewModels;

namespace MAUI.Canvas.Views;

//[QueryProperty(nameof(ClientId), "clientId")]
public partial class InstructorView : ContentPage
{
	//public int ClientId { get; set; }
	public InstructorView()
	{
		InitializeComponent();
	}
	private void GoToCourses(object sender, EventArgs e) {
		Shell.Current.GoToAsync("//Courses");
	}
	private void GoToStudents(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//Students");
	}
        private void AddStudentToCourse(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//AddStudentToCourse");
	}
	private void ReturnToMainPage(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MainPage");
	}


    //private void OnArriving(object sender, NavigatedToEventArgs e)
    //{
	//	BindingContext = new ProjectViewViewModel(ClientId);
    //}
}