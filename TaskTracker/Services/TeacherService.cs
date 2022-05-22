using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;

namespace Template.Services
{
    public class TeacherService
    {
        private TemplateContext _context;
        private IHttpContextAccessor _httpContextAccessor; // needed for identity user

        public TeacherService(TemplateContext context)
        {
            _context = context;
        }

        public Task<List<Teacher>> GetTeachers()
        {
            return _context.Teachers
                .OrderByDescending(x => x.LastName)
                .ToListAsync();
        }
    }
}
