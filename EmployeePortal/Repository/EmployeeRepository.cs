using EmployeePortal.Data;
using EmployeePortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Repository
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task SaveEmployee(Employee objEmp)
        {
            await _context.Employees.AddAsync(objEmp);
            await _context.SaveChangesAsync();
        }

    }
}
