using DAV_SpecificationPattern.Model;

namespace DAV_SpecificationPattern.Specification
{
    public class StudentGpaSpecification : IStudentSpecification
    {
        private readonly int gpa;

        public StudentGpaSpecification(int gpa)
        {
            this.gpa = gpa;
        }

        public bool IsSatisfiedBy(Student student)
        {
            return student.GPA.Equals(gpa);
        }
    }
}
