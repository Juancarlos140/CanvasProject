namespace Canvas.Models{
    public class Course {
        public string? Name{get; set;}
        public string? Code{get; set;}
        public string? Description{get; set;}
        public Guid ID { get; set; }
        public Course() {
            ID = Guid.NewGuid();
        }
        //Name = name, Code = code, Description = description

        public override string ToString()
        {
            return $"({Code}) {Name}";
        }

        public void CourseInfo() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}