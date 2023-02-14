using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace peregruzka_operatorov
{
    // унарные
    // бинарные

    struct SDrob
    {
        public int Ch { get; set; }
        public int Zn { get; set; }
    }

    class Drob
    {
        public int Ch { get; set; }
        public int Zn { get; set; }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        } // нужны для сравнения объектов класса по какому-то значению
        
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString(); // перепределили метод гетхэшкод для нашего объекта
        }

        public static bool operator == (Drob d1, Drob d2)
        {
            return d1.Equals(d2);
        }

        public static bool operator !=(Drob d1, Drob d2)
        {
            return !(d1.Equals(d2));
        }

        public static bool operator >(Drob d1, Drob d2)
        {
            return d1.Ch > d2.Ch;
        }

        public static bool operator <(Drob d1, Drob d2)
        {
            return d1.Ch < d2.Ch;
        }
        public static Drob operator ++(Drob d1)
        {
            d1.Ch += d1.Zn;
            return d1;
        }

        public override string ToString()
        {

            return $"{Ch}/{Zn} \n";
            
        }

        public static Drob operator +(Drob d1, Drob d2)
        {
            return new Drob { Ch = d1.Ch * d2.Zn + d1.Zn * d2.Ch, Zn = d1.Zn * d2.Zn };
        }

        public static Drob operator -(Drob d1, Drob d2)
        {
            return new Drob { Ch = d1.Ch * d2.Zn - d1.Zn * d2.Ch, Zn = d1.Zn * d2.Zn };
        }

        public static Drob operator -(Drob d1)
        {
           
            d1.Ch *= -1;
            return d1;
        }


    }
    // перегруженные бинарные операторы создаются в паре (если == то и != и тд)
    // равенство ссылок или значений

    // bool

    internal class Program
    {
        static void Main(string[] args)
        {

            Drob d = new Drob { Ch = 2, Zn = 5}; 
            Drob dr = new Drob { Ch = 3, Zn = 7 };
            // 1

            /*d++;
            WriteLine(d);
            ++d;
            WriteLine(d);
           

            Drob res = d - dr;            
            WriteLine(res);

            Drob res1 = -d;
            WriteLine(res1);*/


            WriteLine($"{d}\n{dr}");


            /*WriteLine($"{ReferenceEquals(d, dr)}"); // refequals проверяет указывают ли ссылки на один и тот же экземпляр класса (возвращает адреса)

            Drob dr3 = d;
            WriteLine($"{ReferenceEquals(d, dr3)}");

            SDrob sdr1 = new SDrob { Ch = 2, Zn = 5 };
            SDrob sdr2 = new SDrob { Ch = 2, Zn = 5 };
            WriteLine($"{ReferenceEquals (sdr1, sdr1)}"); // со значимыми типами всегда false

            WriteLine($"{Equals(d, dr)}");
            WriteLine($"{Equals(sdr1, sdr2)}");*/

            WriteLine($"{d == dr}");
            WriteLine($"{d > dr}");

        }
    }
}
