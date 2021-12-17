using StaticEnumSealed.Extentions;
using System;

namespace StaticEnumSealed
{
    class Program
    {    
        public enum WeekDay {Monday,Thuesday,Wednesday };
        static void Main(string[] args)
        {
            //FrontEndDeveloper frontEndDeveloper = new FrontEndDeveloper();


            //SimpleClass simpleClass = new SimpleClass();
            //SimpleClass.Number = 23;
            //SimpleClass.Sum(3, 4);

            //SimpleClass simpleClass1 = new SimpleClass();
            //Console.WriteLine($"static:{SimpleClass.StaticCount},nonstatic:{simpleClass1.NonStaticCount}");

            //SimpleClass simpleClass2 = new SimpleClass();
            //Console.WriteLine($"static:{SimpleClass.StaticCount},nonstatic:{simpleClass2.NonStaticCount}");

            //SimpleClass simpleClass3 = new SimpleClass();

            //Console.WriteLine($"static:{SimpleClass.StaticCount},nonstatic:{simpleClass3.NonStaticCount}");
            //SimpleClass.StaticCount = 5;
            //SimpleClass.StaticCount = 5;
            //Console.WriteLine(SimpleClass.StaticCount);
            //SimpleClass simpleClass = new SimpleClass();
            //Console.WriteLine(simpleClass.NonStaticCount);
            //string name = "Hello";

            //name.ToLower();

            //string str = "Hello";

            //string st2 = "Hello";
            //string st3 = "Hello";
            //Extension.Find("hello", 'l');
            //str.Find('t');
            //st2.Find('s');

            //int num1 = 6;
            //num1.ExMethod(7);


            //int? num = 6;

            int num = 0;

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Monday");
            //        break;
            //    default:
            //        break;
            //}


            switch (num)
            {
                case (int)WeekDay.Monday:
                  
                    break;
                case (int)WeekDay.Thuesday:
                    break;
                case (int)WeekDay.Wednesday:
                    break;
                default:
                    break;
            }

        }
    }

    //public abstract class Person
    //{
    //    public virtual void Run()
    //    {
    //        Console.WriteLine("Person run");
    //    }
    //}

    //public abstract class Developer : Person
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Developer run");
    //    }
    //}

    //public sealed class FrontEndDeveloper:Developer
    //{
    //    public void Test()
    //    {

    //    }
    //}

    //public class Test:Person
    //{
    //    public sealed override void Run()
    //    {
    //        base.Run();
    //    }



    //}

    //public class Test1:Test
    //{
         
    //}
  
  
}
