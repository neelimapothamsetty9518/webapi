using System;
using System.Collections.Generic;

namespace WebapiSchool.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Students = new HashSet<Student>();
        }

        public int SubjectId { get; set; }
        public string? Sname { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
