using EfLesson3.DAL;
using EfLesson3.Models;

namespace EfLesson3
{
    public class Program
    {
        static void Main(string[] args)
        {

            //using AppDbContext appDbContext = new AppDbContext();

            //foreach (var item in appDbContext.Products)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.UnitePrice}  {item.Descicription} ");
            //}


            using Library1Context context = new();



            foreach (var item in context.Books)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Comment}  {item.YearPress}");
            }
        }
    }
}