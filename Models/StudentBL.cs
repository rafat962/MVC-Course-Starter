namespace WebGIS46.Models
{
    public class StudentBL
    {
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Rafat", Age = 30, ImageUrl= "pn.png" });
            students.Add(new Student { Id = 2, Name = "Ahmed", Age = 25, ImageUrl = "pn.png" });
            students.Add(new Student { Id = 3, Name = "Sara", Age = 28, ImageUrl = "pn.png" });
            return students;
        }
        public Student GetStudentById(int id)
        {
            List<Student> students = GetAllStudents();
            return students.FirstOrDefault(s => s.Id == id);
        }
}
}

