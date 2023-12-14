using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    public class Motor
    {
        public Motor() 
        {

        }
        public string TYPE { get; private set; }
        public string U { get; private set; }
        public string N { get; private set; }
        public string I { get; private set; }
        public string nju { get; private set; }
        public string Cos { get; private set; }
        public string Slide { get; private set; }
        public string L { get; private set; }
        public string Omega { get; private set; }
        public string T { get; private set; }
        public string Polus { get; private set; }
        public string Freq { get; private set; }
        public string d { get; private set; }
        public string w { get; private set; }
        public string Maker { get; private set; }

        public Motor(string columnTYPE, string columnU, string columnN, string columnI, string columnnju, string columnCos, string columnSlide, string columnL, string columnOmega, string columnT, string columnPolus, string columnFreq, string columnd, string columnw, string columnMaker)
        {
            TYPE = columnTYPE;
            U = columnU;
            N = columnN;
            I = columnI;
            nju = columnnju;
            Cos = columnCos;
            Slide = columnSlide;
            L = columnL;
            Omega = columnOmega;
            T = columnT;
            Polus = columnPolus;
            Freq = columnFreq;
            d = columnd;
            w = columnw;
            Maker = columnMaker;
        }

        public override string ToString()
        {
            return $"{TYPE,-23} {U,-23} {N,-23} {I,-23} {nju,-23} {Cos,-23} {Slide,-23} {L,-23} {Omega,-23} {T,-23} {Polus,-23} {Freq,-23} {d,-23} {w,-23} {Maker,-23}";
        }
    }
}
