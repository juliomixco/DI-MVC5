using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public class CourseService : ICourseService
    {
        public Course GetCourseByID(long courseID)
        {
            return new Course { CourseID = courseID, Description = "Sample course description", InstitutionID = 1, Title = "Sample Course Title" };
        }
    }
}