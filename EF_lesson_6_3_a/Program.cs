using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_3_a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Phone phone = db.Phones.Find(1);
                phone.Name = "Nokia N9";
                db.Entry(phone).State = EntityState.Modified;
                db.SaveChanges();
                foreach (Phone ph in db.Phones)
                {
                    Console.WriteLine("Id - {0}, Name - {1}", ph.Id, ph.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
