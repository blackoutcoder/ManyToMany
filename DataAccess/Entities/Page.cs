using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Page
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public string Content { get; set; }

        public Book Book { get; set; }
    }
}
