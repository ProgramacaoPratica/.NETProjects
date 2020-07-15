using SistemaVendas.Data;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Services
{
    public class DepartmentService
    {
        private readonly SistemaVendasContext _context;

        public DepartmentService(SistemaVendasContext context)
        {
            _context = context;
        }
     
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }


    }
}
