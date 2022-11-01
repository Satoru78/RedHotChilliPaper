using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
     public class Sistem_Developer : Developer
    {
        
        public override void Development()
        {
            Console.WriteLine("Я программирую на C/C++!");
        }
        public override void SpectrumOfTasks()
        {
            Console.WriteLine("Умею выполнять следующие задачи: \n 1.Разрабатываю ОС , Сетевые системы ,Мобильные системы. \n 2. Разработка драйверов \n 3. Делать графические движки");
        }
        public override void IDE()
        {
            Console.WriteLine("Использую следующий среды для разработки:  Eclipse \n NetBeans \n Dev C++");
        }
       
    }
}
