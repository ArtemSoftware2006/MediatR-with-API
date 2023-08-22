using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public int Coust { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
    }
}