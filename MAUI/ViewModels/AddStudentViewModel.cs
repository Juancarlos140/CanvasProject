using Canvas.Models;
using Canvas.Services;

namespace MAUI.Canvas.ViewModels {
    public class AddStudentViewModel {
        public AddStudentViewModel() {
            student = new Person();
        }
        private Person? student;

        public Person? Student => student;

        public Person.Classification Classification { 
            get {
                if (student == null) return Person.Classification.Freshman; //defaults to frehsman
                return student.Undergrad;
            }
            set {
                if (student == null) student = new Person();
                student.Undergrad = value;
            }
        }
        public string Name {
            get {return student?.Name ?? string.Empty; }
            set {
                if (student == null) student = new Person();
                student.Name = value;
            }
        }

        public void AddStudent() {
            if (student != null)
                PersonService.Current.Add(student);
        }
    }
}