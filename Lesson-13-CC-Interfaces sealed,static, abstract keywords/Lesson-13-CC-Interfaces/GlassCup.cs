using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_CC_Interfaces
{
    class GlassCup : IBreakable
    {
        public void Break()
        {
            Console.WriteLine("The whole house is glass");
        }
    }

}
