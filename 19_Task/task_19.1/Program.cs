using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace task_19._1
{
    class Pc
    {
        public int Code { get; set; }
        public string Brand { get; set; } // модель ПК
        public string CpuType { get; set; } // вид процессора
        public int CpuFrequency { get; set; } // частота процессора
        public int RamVolume { get; set; } // объем оперативной
        public int HddVolume { get; set; } // объем диска
        public int VideoCardVolume { get; set; } // объем видео
        public double PcPrice { get; set; } // цена
        public int Availability { get; set; } // наличие в штуках
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pc> listPc = new List<Pc>()
            {
                new Pc(){Code = 1, Brand="DELL", CpuType="intel core i3", CpuFrequency = 2600, RamVolume=16, HddVolume=256, VideoCardVolume=4, PcPrice=67000, Availability = 6},
                new Pc(){Code = 2, Brand="ACER", CpuType="intel core i5", CpuFrequency = 2500, RamVolume=16, HddVolume=1000, VideoCardVolume=2, PcPrice=50000, Availability = 19},
                new Pc(){Code = 3, Brand="Lenovo", CpuType="intel core i5", CpuFrequency = 3000, RamVolume=8, HddVolume=512, VideoCardVolume=2, PcPrice=80000, Availability = 2},
                new Pc(){Code = 4, Brand="Huawei", CpuType="AMD A5", CpuFrequency = 2000, RamVolume=6, HddVolume=256, VideoCardVolume=4, PcPrice=100000, Availability = 7},
                new Pc(){Code = 5, Brand="Xiaomi", CpuType="intel core i5", CpuFrequency = 1800, RamVolume=16, HddVolume=256, VideoCardVolume=4, PcPrice=70000, Availability = 23},
                new Pc(){Code = 6, Brand="HP", CpuType="AMD A7", CpuFrequency = 2200, RamVolume=16, HddVolume=512, VideoCardVolume=6, PcPrice=84000, Availability = 12},
                new Pc(){Code = 7, Brand="Lenovo", CpuType="AMD A5", CpuFrequency = 3200, RamVolume=8, HddVolume=512, VideoCardVolume=4, PcPrice=123000, Availability = 20}
            };

            Console.Write("Введите название процессора: ");
            var str = Console.ReadLine();
            List<Pc> pcList = listPc
                .Where(d => d.CpuType == str).ToList();
            foreach (Pc d in pcList)
            {
                Console.WriteLine($"{d.Brand}");
            }

            Console.Write("\nВведите объем ОЗУ: ");
            var q = Console.ReadLine();
            List<Pc> pcRam = listPc
                .Where(d => d.RamVolume >= Convert.ToInt32(q)).ToList();
            foreach (Pc d in pcRam)
            {
                Console.WriteLine($"{d.RamVolume} {d.Brand}");
            }
            Console.WriteLine("\nНажмите клавишу чтобы продожить...");
            Console.ReadKey();

            Console.WriteLine("\n====вывести весь список, отсортированный по увеличению стоимости=====\n");
            List<Pc> pcPric = listPc
                .OrderBy(d=>d.PcPrice).ToList();
            foreach (Pc d in pcPric)
                Console.WriteLine($"{d.PcPrice} {d.Brand}");
            Console.WriteLine("\nНажмите клавишу чтобы продожить...");
            Console.ReadKey();

            Console.WriteLine("\n====вывести весь список, сгруппированный по типу процессора====\n");
            List<string> pcSortCpu = listPc
                .Select(d=>d.CpuType)
                .Distinct()
                .ToList();
            foreach (string d in pcSortCpu)
                Console.WriteLine(d);
            Console.WriteLine("\nНажмите клавишу чтобы продожить...");
            Console.ReadKey();

            Console.WriteLine("\n====найти самый дорогой компьютер====\n");           
            var pcSortMax = listPc
                .Max(d => d.PcPrice);
            List<Pc> pcListMax = listPc
               .Where(d => d.PcPrice == pcSortMax).ToList();
            foreach (Pc d in pcListMax)
            {
                Console.WriteLine("{0} является компьютером с максимальной стоимостью равной {1}", d.Brand, pcSortMax);
            }
            Console.WriteLine("\nНажмите клавишу чтобы продожить...");
            Console.ReadKey();

            Console.WriteLine("\n====найти самый дешевый компьютер====\n");
            var pcSortMin = listPc
                .Min(d => d.PcPrice);
            List<Pc> pcListMin = listPc
               .Where(d => d.PcPrice == pcSortMin).ToList();
            foreach (Pc d in pcListMin)
            {
                Console.WriteLine("{0} является компьютером с минимальной стоимостью равной {1}", d.Brand, pcSortMin);
            }
            Console.WriteLine("\nНажмите клавишу чтобы продожить...");
            Console.ReadKey();

            Console.WriteLine("\n====есть ли хотя бы один компьютер в количестве не менее 30 штук?====\n");
            bool pcListResult = listPc
               .Any(d => d.Availability >= 30);
            if (pcListResult == true)
                Console.WriteLine("\nЕсть компьютер в колическтве на менее 30 штук");
            else
                Console.WriteLine("\nНет компьютеров в колическтве на менее 30 штук\n");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
