using Canvas.Models;

namespace Canvas.Services {
    public class PersonService{
        private IList<Person> persons;

        private string? query;
        private static object _lock = new object();
        private static PersonService? instance;
        public static PersonService Current {
            get {
                lock(_lock) {               
                    if(instance == null) {
                        instance = new PersonService();
                    }
                }

                return instance;
            }
        }

        public IEnumerable<Person> Persons {
            get {
                return persons.Where(p =>  p.Name.ToUpper().Contains(query ?? string.Empty));
            }
        }

        private PersonService() {
            persons = new List<Person>();
        }

        public IEnumerable<Person> GetByCourse(Guid CourseID) {
            return persons.Where(p => p.CourseID == CourseID);
        }

        public IEnumerable<Person> Search(string query) {
            this.query = query;
            return Persons;
        }

        public void Add(Person person) {
            persons.Add(person);
        }

        public void Remove(Person personToDelete)
        {

            persons.Remove(personToDelete);
        }

    }
}