using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManeyApp
{
    class Operation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }

        public Operation(int id, string title, decimal cost)
        {
            Id = id;
            Title = title;
            Cost = cost;
        }
    }
}
