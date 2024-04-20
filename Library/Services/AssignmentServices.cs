using Canvas.Models;

namespace Canvas.Services {

    public class AssignmentService {
        private static AssignmentService instance;
        public static AssignmentService Current {
            get {
                if(instance == null) {
                    instance = new AssignmentService();
                }
                return instance;
            }
        }

        private IList<Assignment> assingments;

        public IEnumerable<Assignment> Assignments
        {
            get
            {
                return assingments;
            }
        }
        private AssignmentService() {
            assingments = new List<Assignment>();
        }

        public IEnumerable<Assignment> GetByCourse(Guid CourseID) {
            return assingments.Where(a => a.CourseID == CourseID);
        }

        public void Add(Assignment assignment)
        {
            assingments.Add(assignment);
        }
    }

}