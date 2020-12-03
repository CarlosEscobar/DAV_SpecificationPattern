using DAV_SpecificationPattern.Model;
using DAV_SpecificationPattern.Specification;
using System.Collections.Generic;

namespace DAV_SpecificationPattern.Filter
{
    public static class StudentFilter
    {
        public static List<Student> GetStudentsBy(IStudentSpecification specification, Student[] students)
        {
            List<Student> result = new List<Student>();
            foreach(Student student in students)
            {
                if(specification.IsSatisfiedBy(student))
                {
                    result.Add(student);
                }
            }
            return result;
        }
    }
}