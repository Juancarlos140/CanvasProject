namespace Canvas.Models{
    public class Assignment {
        public string? Name{get; set;}
        public string? Description{get; set;}
        public double TotalAvailablePoints{get; set;}
        public string? DueDate{get; set;}
        public Guid CourseID { get; set; }
        public Assignment() {
            
        }
        //Name = name, Description = description, DueDate = dueDate, TotalAvailablePoints = totalAvailablePoints
    }
}