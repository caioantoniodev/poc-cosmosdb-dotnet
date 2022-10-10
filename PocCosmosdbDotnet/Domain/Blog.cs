using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocDapperDotnet.Domain
{
    public class Blog : Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Description { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
