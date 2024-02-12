using System;
using System.Collections.Generic;

namespace WebapiSchool.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int ClassId { get; set; }
        public string? Cname { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
