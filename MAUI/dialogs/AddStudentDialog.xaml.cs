using Canvas.Models;
using Canvas.Services;
using MAUI.Canvas.ViewModels;

namespace MAUI.Canvas.dialogs;

public partial class AddStudentDialog : ContentPage
{
    public AddStudentDialog()
    {
        InitializeComponent();
        BindingContext = new AddStudentViewModel();
    }

    private void OkClicked(object sender, EventArgs e)
    {
        (BindingContext as AddStudentViewModel)?.AddStudent();
        Shell.Current.GoToAsync("//Students");
    }
    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Students");
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        BindingContext = new AddStudentViewModel();
    }
}