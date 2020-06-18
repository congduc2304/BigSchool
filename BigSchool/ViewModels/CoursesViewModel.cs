using System.Collections.Generic;
using BigSchool.Models;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.Controllers
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
       // public List<Category> Categories { get; set; }
    }
}