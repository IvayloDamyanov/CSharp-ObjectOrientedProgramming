using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Animals lists
            Kitten malkoKote = new Kitten(2, "Malko Kote");
            Kitten poMalkoKote = new Kitten(1, "Po-malko kote");
            Tomcat kitHarington = new Tomcat(2, "Kit Harington", true);
            Tomcat kitkat = new Tomcat(4, "KitKat", true);
            Frog boko = new Frog(5, "Boko", true);
            Frog kvako = new Frog(8, "Kvako", true);
            Cat felicia = new Cat(4, "Felicia", false);
            Cat penka = new Cat(10, "Penka", false);
            Dog cratos = new Dog(7, "Cratos", true);
            Dog sharo = new Dog(3, "sharo", true);
            List<Kitten> kittens = new List<Kitten> { malkoKote, poMalkoKote };
            List<Tomcat> tomcats = new List<Tomcat> { kitHarington, kitkat };
            List<Frog> frogs = new List<Frog> { boko, kvako };
            List<Cat> cats = new List<Cat> { felicia, penka };
            List<Dog> dogs = new List<Dog> { cratos, sharo };
            #endregion

            #region Tests
            Console.WriteLine(dogs.AverageAge());
            Console.WriteLine(cats.AverageAge());
            Console.WriteLine(frogs.AverageAge());
            Console.WriteLine(kittens.AverageAge());
            Console.WriteLine(tomcats.AverageAge());
            #endregion
        }
    }
}
