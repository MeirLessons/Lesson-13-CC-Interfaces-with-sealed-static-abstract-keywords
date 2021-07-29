using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_CC_Interfaces
{
    class Respirator : IElectronicDevice, IHardOfFable
    {
        public bool IsTurnOn { get; set; }

        public void Break()
        {
            Console.WriteLine("oh no this Respirator Was Very Expensive");
        }

        public void HardOff()
        {
            Console.WriteLine("Hard off");
        }

        public void Off()
        {
        }

        public void On()
        {
            Console.WriteLine("Now, Respirator Is On");
        }
    }
}
