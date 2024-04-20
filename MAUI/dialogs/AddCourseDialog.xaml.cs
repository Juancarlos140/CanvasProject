using Canvas.Models;
using Canvas.Services;
using MAUI.Canvas.ViewModels;

namespace MAUI.Canvas.dialogs;

public partial class AddCourseDialog : ContentPage
{
    public AddCourseDialog()
    {
        InitializeComponent();
        BindingContext = new AddCourseViewModel();
    }

    private void OkClicked(object sender, EventArgs e)
    {
        (BindingContext as AddCourseViewModel)?.AddCourse();
        Shell.Current.GoToAsync("//Courses");
    }
    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Courses");
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        BindingContext = new AddCourseViewModel();
    }
}