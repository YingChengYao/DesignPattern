using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Feeling
    {
        public Feeling()
        {
            Date = DateTime.Now;
        }
        public DateTime Date { get; set; }
    }
}
