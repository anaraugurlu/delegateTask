using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatetask
{
    public class Run
    {

        public  void RunFunc( Func func ,string str)
        {
           func.Invoke(str) ; 
        }

    }
}
