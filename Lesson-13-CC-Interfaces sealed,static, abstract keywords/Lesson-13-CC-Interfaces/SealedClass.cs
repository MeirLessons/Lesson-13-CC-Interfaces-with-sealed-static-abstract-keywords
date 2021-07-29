using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_CC_Interfaces
{
    class SClassBase
    {
        public virtual void Foo()
        {

        }
        public virtual void Goo()
        {

        }
    }
    class SealedClass : SClassBase
    {

        public override void Foo()
        {
            Console.WriteLine(  );
        }

        public sealed override void Goo()
        {
            Console.WriteLine();
        }
    }

    class SClassSon : SealedClass
    {
        public SClassSon() : base()
        {
            //Foo();
            //Goo();
        }
        public override void Foo()
        {
            Console.WriteLine();
        }
    }
}
