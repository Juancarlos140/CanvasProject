using Canvas.Models;

namespace Canvas.Services {

    public class CourseService {
        private static CourseService instance;
        public static CourseService Current {
            get {
                if(instance == null) {
                    instance = new CourseService();
                }
                return instance;
            }
        }

        private IList<Course> courses;

        public IEnumerable<Course> Courses
        {
            get
            {
                return courses;
            }
        }
        private CourseService() {
            courses = new List<Course>{
                new Course { Name = "Course 1" },
                new Course { Name = "Course 2" },
                new Course { Name = "Course 3" },
                new Course { Name = "Course 4" },
                new Course { Name = "Course 5" },
            };
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Remove(Course course)
        {
            courses.Remove(course);
        }
    }

}