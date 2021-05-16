using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatetask
{
   //public  class MyClass
    //{

        //public void Space(string str)
        //{

        //    foreach (var item in str.ToCharArray())
        //    {
        //        Console.WriteLine($" { item}_ ");
               
        //    } 

        //}
        //public void Reverse(string str)
        //{
        //    char[] chars = str.ToCharArray();
        //    char[] result = new char[chars.Length];
        //    for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        //    {
        //        result[i] = chars[j];
        //    }
        //    Console.WriteLine(result);
        //}
    //}
    //class Run
    //{

    //}

    public delegate void Func(string str);
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("include text");
            var str = Console.ReadLine();
            MyClass cls = new MyClass(str);
            Func funcDell = new Func( cls.Space );
            funcDell += cls.Reverse;
            Run run = new Run();
            run.RunFunc(funcDell, str); 
        }
    }
}
