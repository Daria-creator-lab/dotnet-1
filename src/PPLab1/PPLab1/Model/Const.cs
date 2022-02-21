using System;

namespace PPLab1.Model
{
    internal class Const : Function
    {
        public Data Elems { get; set; }

        public Const() { Elems = new Data(); }

        public Const(Data elems) { Elems = elems; }

        public override double calc_funct(double value) { return Elems.K; }

        public override string derivative() { return "0"; }

        public override string ToString()
        {
            return String.Format("y = {0}", Elems.K);
        }
       
    }
}


