//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_13_CC_Interfaces
//{
//    interface IProgram
//    {
//        int MyProperty { get; set; }
//        void Main(string[] args);
//    }
//    class Program
//    {
//        string name;
//        //private int age_BackingField
//        public static int Age { get; set; }
//        //public int GetName()
//        //{
//        //    return age_BackingField;
//        //}
//        //public void SetAge(int value)
//        //{
//        //    age_BackingField = value;
//        //}

//        static void Main(string[] args)
//        {
//            Console.WriteLine();
//            int x = Age;//0;
//            Age = 5;
//            int y = Age;//5
//            SuperConsole c = new SuperConsole();
//            SuperConsole2 c2 = new SuperConsole2();
//            object o = 5;
//            c.Print("asd");
//            c.Print(3);
//            c.Print(true);
//            LetsFly(c);
//            LetsFly(c2);


//        }

//        public static void LetsFly(IB ib)
//        {
//            ib.A();
//            ib.B();
//        }
//    }

//    interface IA
//    {
//        void A();
//    }
//    interface IB : IA
//    {
//        void B();
//    }

//    class SuperConsole : IB
//    {
//        public void Print(object o)
//        {
//            Console.WriteLine(o);
//        }
//        public void A()
//        {
//            Console.WriteLine("a1");
//        }
//        public void B()
//        {
//            Console.WriteLine("b1");
//        }
//    }

//    class SuperConsole2 : IB
//    {
//        public void Print(object o)
//        {
//            Console.WriteLine(o);
//        }
//        public void A()
//        {
//            Console.WriteLine("a2");
//        }
//        public void B()
//        {
//            Console.WriteLine("b2");
//        }
//    }
//}
