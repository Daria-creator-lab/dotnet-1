using System;

namespace PPLab1.Model
{
    internal class ExpFunct : Function
    {
        public Data Elems { get; set; }

        public ExpFunct() { Elems = new Data(); }

        public ExpFunct(Data elems) { Elems = elems; }

        public override double calc_funct(double value)
        {
            return Elems.K * Math.Pow(Elems.A, value);
        }
        public override string derivative()
        {
            return String.Format("y' = {0} {1}^x ",
                Math.Round( Elems.K* Math.Log(Elems.A), 2), Elems.A );
        }
        public override string ToString()
        {
            return String.Format("y = {0}{1}^x", Elems.K, Elems.A);
        }
    }
}
