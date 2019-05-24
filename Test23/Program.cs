using DTOModel;
using DTOModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test23
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext ctx = new MyDbContext();
            ctx.schools.Add(new School() { Name = "北京大学" });
            ctx.SaveChanges();
        }
    }
}
