using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Content
    {
        public int Id { get; set; }

        public int Grade { get; set; }

        public string Data { get; set; } = null!;
        public bool IsActive { get; set; }

        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
