using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTreeSample
{
    public class Inner
    {
        public int Number { get; set; }

    }

    public class SomeData
    {
        public SomeData()
        {
            Inners = Enumerable.Range(0, 5).Select(x => new Inner { Number = x }).ToList();
        }

        public string Text { get; set; }

        public IEnumerable<Inner> Inners { get;  }


    }
}
