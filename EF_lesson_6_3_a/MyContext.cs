using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_3_a
{
    class MyContext : DbContext 
    {
        public MyContext():base("EF_lesson_6_3_a")
        { }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Companies { get; set; }
        static MyContext()
        {
            Database.SetInitializer<MyContext>(new MyContextInitializer());
        }
    }
}
