using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll() // lista os departamentos de forma sincrona
        {
            return _context.Department.OrderBy(x => x.Name).ToList(); // ToList é o que faz a consulta
        }

        public async  Task<List<Department>> FindAllAsync() // lista os departamentos de forma assincrona
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();  // ToListAsync pertence ao EntityFrameworkCore
        }
    }
}
