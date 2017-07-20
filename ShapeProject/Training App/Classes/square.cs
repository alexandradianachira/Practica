using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_App.Classes
{
  
    class square : Classes.shape
    {
        public override void theArea(int _l)
        {
            int area = _l*_l;
            Console.WriteLine(area);
        }


    }
}
