namespace WebApplication1.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new List<Course>();
        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Title = "Asp.net Core",
                    Description="Asp.net core web development",
                    Image="1.jpg",
                    Tags = new string[] {"Asp.net","Web Development"},
                    isActive = true,
                    isHome = true
                },
                new Course()
                {
                    Id = 2,
                    Title = "Node JS",
                    Description="Node JS Back end programing language",
                    Image="2.jpg",
                    Tags = new string[] {"Javascript","Web Development"},
                    isActive = false,
                    isHome = true
                },
                new Course() {
                    Id = 3,
                    Title = "Python",
                    Description="Django is Python FrameWork",
                    Image="3.jpg",
                    Tags = new string[] {"Django ","Web Development"},
                    isActive = true,
                    isHome = false
                },
                new Course() {
                    Id = 4,
                    Title = "Vue JS",
                    Description="Vue JS İs JavaScript FrameWork",
                    Tags = new string[] {"Vue JS","Web Development"},
                    Image="3.jpg",
                    isActive = true,
                    isHome = false
                },
                new Course() {
                    Id = 5,
                    Title = "React JS",
                    Description="React JS İs JavaScript FrameWork",
                    Tags = new string[] {"JavaScript","Web Development"},
                    Image="3.jpg",
                    isActive = true,
                    isHome = true
                },
            };
        }
        public static List<Course> getAllCourses
        {
            get
            {
                return _courses;
            }
        }
        public static Course? getById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
