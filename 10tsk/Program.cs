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
            double gr = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Введите численное значение минут для задаваемого угла");
            double mi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите численное значение секунд для задаваемого угла");
            double se = Convert.ToInt32(Console.ReadLine());
            //Новый экземпляр класса угол и вывод результата
            Corner corn = new Corner(gr, mi, se);
            corn.ToRad();
            Console.ReadKey();
        }
    }
    
    //Задаем класс
   class Corner
    {
        //Задаем 
        private double grad;
        private double min;
        private double sec;
        //свойства класса
        public double Grad
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
        public double Min
        {
            set
            {
                if (value>=0&&value<=60)
                {
                    min = value;
                   
                }
                else
                {
                    min = value % 60;
                    grad += value / 60;
                    Console.WriteLine("Введено значениеминут больше 60. было прибавлено к градусу");
                }
            }
            get
            {
                return min;
            }
        }
        public double Sec
        {
            set
            {
                if (value>=0&&value<=60)
                {
                    sec = value;                   
                    
                }
                else
                {
                    sec = value % 60;
                    min += value / 60;
                    Console.WriteLine("Введено значение секунд больше 60. Было прибавлено к минутам");
                    Console.WriteLine("Суммарный градус {0,000000:000.000}", grad);

                    

                }
            }
            get
            {
                return sec;
            }
        }
        //Конструктор класса
        public Corner(double grad, double min, double sec)
           {
            Grad = grad;
            Min = min;
            Sec = sec;
           }
        //Метод для перевода в радианы
        public void ToRad()
        {
            double grd = grad + min / 60 + sec / 3600;
            double rad = Math.PI * grd / 180;
            Console.WriteLine("Угол в радианах  {0,00000:000.00}", rad);
        }
    }
}
