using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class AccessModifiers
    {
        int i;
        protected int j;
        public int k;
        internal int l;
        protected internal int m;

        public void ini()
        {
            i = j = k = l = m = 10;
        }
    }

    public class child : AccessModifiers
    {
        public void ini()
        {
            j = l = m = 10;
        }
    }
}
