using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footing
{
   public class Material
    {
        private double length;
        private double b;
        private double h;
        private double load;
        public double moe;
        public double stiff;
        public double dfac;
        public double sdfac;
        public double rdfac;
        public double sfem;
        public double rfem;
        public double[] bl;
        public double[] sbl;
        public double[] rbl;
        public double[] sco;
        public double[] rco;

        public Material()
        {
            bl = new double[6];
            sbl = new double[6];
            rbl = new double[6];
            sco = new double[5];
            rco = new double[5];
            length = b = h = load = moe = stiff = dfac = sdfac = rdfac = sfem = rfem = 0;
            bl[0] = sbl[0] = rbl[0] = 0;
            for (int i = 0; i < 5; i++)
                bl[i + 1] = sbl[i + 1] = rbl[i + 1] = sco[i] = rco[i] = 0;
        }
       public double Length
        {
            get { return length; }
            set { if (value > 0) length = value; else length = 0; }
        }
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; else b = 0; }
        }
        public double H
        {
            get { return h; }
            set { if (value > 0) h = value; else h = 0; }
        }
        public double Load
        {
            get { return load; }
            set { if (value > 0) load = value; else load = 0; }
        }


    }
}
