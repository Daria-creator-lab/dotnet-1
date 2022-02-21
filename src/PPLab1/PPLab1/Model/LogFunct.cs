using System;

namespace PPLab1.Model
{
    internal class LogFunct : Function
    {
        public Data Elems { get; set; }

        public LogFunct() { Elems = new Data(); }

        public LogFunct(Data elems) { Elems = elems; }

        public override double calc_funct(double value)
        {
            return Elems.K * Math.Round(Math.Log(value, Elems.A), 2);
        }
        public override string derivative()
        {
            return String.Format("y' = {0} x^-1",
                
                Math.Round(Elems.K / Math.Log(Elems.A), 2));
        }
        public override string ToString()
        {
            return String.Format("y = {0} log_{1}x", Elems.K, Elems.A);
        }

        public override bool Equals(Object obj)
        {
            if (obj is LogFunct) 
            {
                LogFunct lf = (LogFunct)obj;
                return (Elems.K == lf.Elems.K) && (Elems.A == lf.Elems.A);
            }
            else { return false; }
        }
        public override int GetHashCode()
        {
            return Elems.A ^ Elems.K;
        }
    }
}

