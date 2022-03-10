using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ObjectR
    {
        public int page { get; set; }
        public List<Movie> results { get; set; }

        public ObjectR()
        {
            results = new List<Movie>();
        }
    }
}
