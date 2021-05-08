using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Student
    {
        public Student()
        {
            CreationDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public DateTime LastUpdateDate { get; set; }


    }
}
