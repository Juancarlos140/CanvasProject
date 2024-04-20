using Canvas.Models;

namespace Canvas.Services {

    public class ModuleService {
        private static ModuleService instance;
        public static ModuleService Current {
            get {
                if(instance == null) {
                    instance = new ModuleService();
                }
                return instance;
            }
        }

        private IList<Module> modules;

        public IEnumerable<Module> Modules
        {
            get
            {
                return modules;
            }
        }
        private ModuleService() {
            modules = new List<Module>();
        }

        public IEnumerable<Module> GetByCourse(Guid CourseID) {
            return modules.Where(m => m.CourseID == CourseID);
        }

        public void Add(Module module)
        {
            modules.Add(module);
        }
    }

}