using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfLesson3.DAL;

public class Product
{

    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal UnitePrice { get; set; }
    public string? Descicription { get; set; } = default!;


}
