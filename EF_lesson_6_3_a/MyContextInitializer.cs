using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_lesson_6_3_a
{
    class MyContextInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            
            Company c1 = new Company { Name = "Samsung" };
            Company c2 = new Company { Name = "Apple" };
            context.Companies.AddRange(new List<Company>() { c1, c2 });
            context.SaveChanges();

            Phone p1 = new Phone { Name = "Samsung Galaxy S5", Company = c1 };
            Phone p2 = new Phone { Name = "Samsung Galaxy S4", Company = c1 };
            Phone p3 = new Phone { Name = "iPhone5", Company = c2 };
            Phone p4 = new Phone { Name = "iPhone 4S", Company = c2 };

            //p1.Company = c1;
            //p2.Company = c1;
            //p3.Company = c2;
            //p4.Company = c2;

            context.Phones.AddRange(new List<Phone>() { p1, p2, p3, p4 });
            context.SaveChanges();

            base.Seed(context);
            
            
        }
    }
}
