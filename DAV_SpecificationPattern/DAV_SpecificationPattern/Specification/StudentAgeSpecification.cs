using DAV_SpecificationPattern.Model;

namespace DAV_SpecificationPattern.Specification
{
    public class StudentAgeSpecification : IStudentSpecification
    {
        private readonly int age;

        public StudentAgeSpecification(int age)
        {
            this.age = age;
        }

        public bool IsSatisfiedBy(Student student)
        {
            return student.Age.Equals(age);
        }
    }
}
