using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_CC_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interfaces
            const int x = 5;
            TV tv = new TV();
            GlassCup gc = new GlassCup();
            Respirator r = new Respirator();
            
            DropOnTheFloor(tv);
            DropOnTheFloor(gc);
            DropOnTheFloor(r);

            OnClickPowerOnButton(tv);
            //OnClickPowerOnButton(gc);
            OnClickPowerOnButton(r);

            OnClickPowerOffButton(tv);
            OnClickPowerOffButton(r);
            #endregion

            #region Static Class
            /*Call To Static Ctor*/
            Circle c = new Circle();
            c.radius = 3.1;   //By Instance
            Console.WriteLine("From Main Before");
            Circle.Pie = 3.14;//By Class
            Console.WriteLine("From Main After");
            Log.pathOfFile = "C://";
            Log.WriteToLog("User Login");
            #endregion

            #region abstract keyword

            Shape s = new Circle();
            s.CalcArea();
            SubShape ss = new Rectangle();
            ss.CalcArea();

            TryCalcArea(s);
            TryCalcArea(ss);
            #endregion
        }

        public static void TryCalcArea(Shape shape)
        {
            shape.GetShapeName();
            shape.CalcArea();
        }
        #region Interfaces
        public static void DropOnTheFloor(IBreakable someBreakable)
        {
            someBreakable.Break();
        }
        public static void OnClickPowerOnButton(IElectronicDevice ElDevice)
        {
            if (DateTime.Now.Hour >= 23)
                ElDevice.Break();
            else
                ElDevice.On();
        }
        public static void OnClickPowerOffButton(IElectronicDevice ElDevice)
        {
            if (ElDevice is/*smart as*/ IHardOfFable)// is = check is as is null or not
            {
                Console.WriteLine("you can turn off respirator only after 23:00");
                //return;
            }

            //(ElDevice as IHardOfFable).HardOff(); //do casting without check
            IHardOfFable hard = ElDevice as IHardOfFable;// TV = null ////do casting but if its not ok return null
            if (hard != null)
            {
                hard.HardOff();
                return;
            }

            ElDevice.Off();
        }
        #endregion
    }


    static class Log
    {
        public static string pathOfFile;
        //public string pathOfFile;

        public static void WriteToLog(string log)
        {
            Console.WriteLine("Write To Log...");
        }

    }

    public abstract class Shape
    {
        private string name;
        public string Name { get; set; }
        public int Angles { get; set; }

        public string GetShapeName()
        {
            return Name;
        }

        public abstract void CalcArea();
    }

    public abstract class SubShape : Shape
    {
        public abstract void CalcArae2();
    }

    class Circle : SubShape
    {
        public static double Pie;
        public double radius;

        static Circle()
        {
            Console.WriteLine("From Static Ctor");
            Pie = 3.99;
        }

        public Circle()
        {
            Name = "Circle";
        }

        public override void CalcArae2()
        {
        }

        public override void CalcArea()
        {
            Console.WriteLine($"Calc Arae For: {Name}");
        }
    }

    public class Rectangle : SubShape
    {
        public Rectangle()
        {
            Name = "Rectangle";
        }
        public override void CalcArae2()
        {
        }

        public override void CalcArea()
        {
            Console.WriteLine($"Calc Arae For: {Name}");
        }
    }
}
