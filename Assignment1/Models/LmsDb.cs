using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class LmsDb : DbContext
    {
        public LmsDb(DbContextOptions<LmsDb> option) : base(option)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
