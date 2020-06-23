using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Requied]
        public string Place { get; set; }
        [Requied]
        [FutureDate]
        public string Date { get; set; }
        [Requied]
        [ValidTime]
        public string Time { get; set; }
        [Requied]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}