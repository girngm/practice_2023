using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    public class SHVN_Nasos
    {
        public string Name { get; private set; }
        public string q100 { get; private set; }
        public string H { get; private set; }
        public string Dgabarit { get; private set; }
        public string d { get; private set; }
        public string L { get; private set; }
        public string Nju { get; private set; }
        public string Hopt { get; private set; }
        public string Freq { get; private set; }
        public string Maker { get; private set; }


        public SHVN_Nasos(string columnName, string columnq100, string columnH, string columnDgabarit, string columnd, string columnL, string columnNju, string columnHopt, string columnFreq, string columnMaker)
        {
            Name = columnName;
            q100 = columnq100;
            H = columnH;
            Dgabarit = columnDgabarit;
            d = columnd;
            L = columnL;
            Nju = columnNju;
            Hopt = columnHopt;
            Freq = columnFreq;
            Maker = columnMaker;

        }

        public override string ToString()
        {
            return $"{Name,-25} {q100,-25} {H,-25} {Dgabarit,-25} {d,-25} {L,-25} {Nju,-25} {Hopt,-25} {Freq,-25} {Maker,-25}";
        }
    }
}
