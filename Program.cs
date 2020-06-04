using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eftest
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await using (testdbContext ctx = new testdbContext())
            {
                await ctx.Person.AddAsync(new Person() {Name = "Jan Joska"});
                await ctx.SaveChangesAsync();
                var p = await ctx.Person.FirstAsync();
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
