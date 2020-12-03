using DAV_SpecificationPattern.Model;

namespace DAV_SpecificationPattern.Specification
{
    public interface IStudentSpecification
    {
        bool IsSatisfiedBy(Student student);
    }
}
