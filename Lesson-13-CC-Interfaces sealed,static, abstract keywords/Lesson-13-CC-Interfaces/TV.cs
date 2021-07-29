using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_CC_Interfaces
{
    class TV : IElectronicDevice
    {
        public bool IsTurnOn { get; set; }

        public void Break()
        {
            Console.WriteLine("oh no this Tv Was Very Expensive");
        }

        public void Off()
        {
            Console.WriteLine("Now, TV Is Off");
        }

        public void On()
        {
            Console.WriteLine("Now, TV Is On");
        }
    }

}
