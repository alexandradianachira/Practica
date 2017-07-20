using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_App.Classes
{
    class shape
    {
        private int _l;

        public int getL()
        {
            return _l;

        }

        public void setL(int l)
        {
            _l = l;
        }

        public virtual void theArea(int _l)
        {
            Console.WriteLine("Calculate the area");
        }

    }

    
}
