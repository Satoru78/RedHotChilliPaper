using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Web_Developer : Developer
    {
        public string PresentationPart { get; set; }

        public string App { get; set; }
        public override void Development()
        {
            Console.WriteLine("Я программирую на JavaScript/Python/Html,CSS,PHP");
        }
        public override void SpectrumOfTasks()
        {
            Console.WriteLine("Умею выполнять следующие задачи: \n 1.Создаю сайты. \n 2. Выполняю BackEnd and FrontEnd задачи \n 3.Делаю красивый и вто же время простой дизайн");
        }
        public override void IDE()
        {
            Console.WriteLine("Использую следующие среды для разработки: Visual Studio Code \n MySql Worckbench \n ReactJs");
        }
    }
}
