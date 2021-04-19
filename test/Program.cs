using System;
using System.Reflection;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dll = Assembly.LoadFile(@"hesapla.dll");
            var tip = dll.GetType("hesapla.Hesapla");
            var istek = Activator.CreateInstance(tip);
            var metod = tip.GetMethod("hesapla");
            float sonuc = (int)metod.Invoke(istek, new object[] { 4 });
            Console.WriteLine(sonuc);
        }
    }
}
