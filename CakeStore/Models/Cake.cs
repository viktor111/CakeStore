using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeStore.Models
{
    public class Cake
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageURL { get; set; }

        public double Price { get; set; }

        public int PiecesCount { get; set; }

    }
}
