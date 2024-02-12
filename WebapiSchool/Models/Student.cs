using System;
using System.Collections.Generic;

namespace WebapiSchool.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public int? SubjectId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
