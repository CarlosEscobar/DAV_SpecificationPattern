using DAV_SpecificationPattern.Model;

namespace DAV_SpecificationPattern.Specification
{
    public class StudentFieldOfStudySpecification : IStudentSpecification
    {
        private readonly string fieldOfStudy;

        public StudentFieldOfStudySpecification(string fieldOfStudy)
        {
            this.fieldOfStudy = fieldOfStudy;
        }

        public bool IsSatisfiedBy(Student student)
        {
            return student.FieldOfStudy.Equals(fieldOfStudy);
        }
    }
}
