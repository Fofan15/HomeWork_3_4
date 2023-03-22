using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_3_4
{
    public class Contact
    {
        public string Name { get; set; }

        public string NumberPhone { get; set; }

        public override string ToString()
        {
            return $"{Name} - {NumberPhone}";
        }
    }
}
