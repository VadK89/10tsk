using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10tsk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
             * Реализовать класс, в котором указанные значения представлены в виде свойств. 
             * Для свойств предусмотреть проверку корректности данных. 
             * Класс должен содержать конструктор для установки начальных значений, 
             * а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса. 
             * Осуществить использование объекта в программе.
             */
            //Ввод исходных данных
            Console.WriteLine("Введите исходные данные");
            Console.WriteLine("Введите численное значение градусов для задаваемого угла");
            int gr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите численное значение минут для задаваемого угла");
            int mi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите численное значение секунд для задаваемого угла");
            int se = Convert.ToInt32(Console.ReadLine());
            Corner corn = new Corner(gr,mi,se);
            Console.WriteLine(corn);
            corn.ToRad();
            Console.ReadKey();

        }
    }
    class Corner
    {
        private int grad;
        private int min;
        private int sec;

        public int Grad
        {
            set
            {
                if (value>=0||value<=0)
                {
                    grad = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
            get
            {
                return grad;
            }
        }
        public int Min
        {
            set
            {
                if (value>=0||value<=0)
                {
                    min = value;
                    grad += value / 60;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value>=0||value<=0)
                {
                    sec = value%60;
                    grad += value / 3600;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
            get
            {
                return sec;
            }
        }
        public Corner(int grad, int min, int sec)
           {
            Grad = grad;
            Min = min;
            Sec = sec;
           }
        public void ToRad()
        {            
            double rad = Math.PI * grad / 180;
            Console.WriteLine("Угол в радианах{0:0000}",rad);
        }
    }
}
