using Canvas.Models;
using Canvas.Services;
using MAUI.Canvas.ViewModels;

namespace MAUI.Canvas.Views;
public partial class CourseManagerView : ContentPage
{
    public CourseManagerView()
    {
        InitializeComponent();
        BindingContext = new CourseManagerViewModel();
    }

    private void AddCourse(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//AddCourse");
    }
    private void RemoveCourse(object sender, EventArgs e)
	{
        (BindingContext as CourseManagerViewModel)?.RemoveCourse();
    }
    private void GoBack(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Instructors");
    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as CourseManagerViewModel)?.RefreshView();
    }

}