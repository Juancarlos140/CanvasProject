using Canvas.Models;
using Canvas.Services;
using MAUI.Canvas.ViewModels;

namespace MAUI.Canvas.Views;
public partial class StudentManagerView : ContentPage
{
    public StudentManagerView()
    {
        InitializeComponent();
        BindingContext = new StudentManagerViewModel();
    }

    private void AddStudent(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//AddStudent");
    }
    private void RemoveStudent(object sender, EventArgs e)
	{
        (BindingContext as StudentManagerViewModel)?.RemoveStudent();
    }
    private void GoBack(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Students");
    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as StudentManagerViewModel)?.RefreshView();
    }

}