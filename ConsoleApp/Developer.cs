using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Developer
    {
        public string Education { get; set; }
        public byte ExperienceAge { get; set; }
        public string ProgramLan { get; set; }
        public string PlaceOfWork { get; set; }
        public int Salary { get; set; } 

        public virtual void Development()
        {
            Console.WriteLine("Я умею программировать!");
        }
        public virtual void SpectrumOfTasks()
        {
            Console.WriteLine("Я умею выполнять различный спектр задач");
        }
        public virtual void IDE()
        {
            Console.WriteLine("Использую определенные среды разработки");
        }
         public virtual void SoftWare()
        {
            Console.WriteLine("Использую различный софт для разработки");
        }
    }
}
