namespace Canvas.Models{
    public class Person {
        public enum Classification {Freshman, Sophomore, Junior, Senior};
        public string? Name{get; set;}
        public Classification Undergrad{get; set;}
        public  double Grade{get; set;}

        public Guid CourseID { get; set; }
        public Person() {
            
        }
        //Name = name, Undergrad = undergrad, Grade = grade
        public override string ToString()
        {
            return $"{Name}";
        }

        public void StudentInfo() {
            Console.WriteLine($"{Name} ({Undergrad}): {Grade.ToString("N2")}");
        }
    }
}