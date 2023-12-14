using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    public class Maker
    {
        public Maker()
        {

        }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Adress { get; private set; }

        public Maker(string columnCode, string columnName, string columnAdress)
        {
            Code = columnCode;
            Name = columnName;
            Adress = columnAdress;
        }

        public override string ToString()
        {
            return $"{Code,-20} {Name,-100} {Adress,-200}";
        }
    }
}
