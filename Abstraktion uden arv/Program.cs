using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Apstract_Virtual_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("BMW", "M5", new DateTime(2023, 11, 7), DateTime.Now);
            Truck MyTruck = new Truck("MAN", "B37", new DateTime(2017, 2, 2), DateTime.Now);

            MyCar.SetTireType(false);
            MyTruck.SetTireType(true);

            Console.WriteLine(MyCar.DisplayInfo());
            Console.WriteLine(MyCar.InstectionStatus());
            Console.WriteLine($"Max rim size: {MyCar.MaxRimSize}");

            Console.WriteLine(MyTruck.DisplayInfo());
            Console.WriteLine(MyTruck.InstectionStatus());
            Console.WriteLine($"Max rim size: {MyTruck.MaxRimSize}");

            Console.WriteLine(MyCar.GetInterfaceInfo());
            Console.WriteLine(MyTruck.GetInterfaceInfo());
        }
    }
}
