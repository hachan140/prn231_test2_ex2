using Microsoft.EntityFrameworkCore;

namespace Ex2_Test2
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudents();
    }
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
