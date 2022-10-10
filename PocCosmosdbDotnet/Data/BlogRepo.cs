using PocDapperDotnet.Data;
using PocDapperDotnet.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocDapperDotnet.Data
{

    public class BlogRepo : IDisposable
    {
        private readonly BlogDbContext _context;

        public BlogRepo()
        {
            _context = new BlogDbContext();
            _context.Database.EnsureCreated();
        }

        public void SaveChanges() => _context.SaveChanges();

        public void Add(Blog blog) => _context.AddAsync(blog);

        public List<Blog> FindAll() => _context.Blogs.ToList();

        public void Dispose() => _context.Dispose();
    }
}
