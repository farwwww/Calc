using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
        public class umnojenie
        {
            public string a, b;
            public umnojenie(string a, string b)
            {
                this.a = a;
                this.b = b;
            }
            public string fisting()
            {
                return "" + (Double.Parse(a) * Double.Parse(b));
            }
            public string Clear()
            {
                return "";
            }
        }
    }

