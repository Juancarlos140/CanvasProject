namespace Canvas.Models{
    public class Module {
        public string? Name{get; set;}
        public string? Description{get; set;}
        public Guid CourseID { get; set; }
        public List<contentItem> Content = new List<contentItem>();
        public Module() {
            
        }
        //Name = name, Description = description
    }
}