using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Mobile_Developer : Developer
    {
        public string OS { get; set; }
        public string Tester { get; set; }
        public override void Development()
        {
            Console.WriteLine("Я программирую на Java/Kotlin/C#!");
        }
        public override void SpectrumOfTasks()
        {
            Console.WriteLine("Умею выполнять следующие задачи: \n 1.Разрабатываю,тестирую ,мобильные приложения. \n 2. Писать грамотный код \n 3.Делаю красивый дизайн");
        }
        public override void IDE()
        {
            Console.WriteLine("Использую следующие среды для разработки: Visual Studio 2022 \n Android Studio");
        }      
    }
}
