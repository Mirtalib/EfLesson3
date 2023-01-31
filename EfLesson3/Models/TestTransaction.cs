using System;
using System.Collections.Generic;

namespace EfLesson3.Models
{
    public partial class TestTransaction
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
