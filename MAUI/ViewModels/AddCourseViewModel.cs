using Canvas.Models;
using Canvas.Services;

namespace MAUI.Canvas.ViewModels {
    public class AddCourseViewModel {
        public AddCourseViewModel() {
            course = new Course();
        }
        private Course? course;

        public Course? Course => course;

        public string Code { 
            get {return course?.Code ?? string.Empty; }
            set {
                if (course == null) course = new Course();
                course.Code = value;
            }
        }
        public string Name {
            get {return course?.Name ?? string.Empty; }
            set {
                if (course == null) course = new Course();
                course.Name = value;
            }
        }

        public void AddCourse() {
            if (course != null)
                CourseService.Current.Add(course);
        }
    }
}