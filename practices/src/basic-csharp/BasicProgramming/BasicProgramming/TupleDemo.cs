using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    public class TupleDemo
    {
        public Tuple<int, string> GetPersonaInfo()
        {
            int age = 20;
            string name = "John Doe";
            return new Tuple<int, string>(age, name);
        }
    }
}
