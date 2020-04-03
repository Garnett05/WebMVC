using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Data;
using WebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Services
{
    public class DepartmentService
    {
        private readonly WebMVCContext _context;

        public DepartmentService(WebMVCContext context)
        {
            _context = context;
        }

        public async Task <List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
