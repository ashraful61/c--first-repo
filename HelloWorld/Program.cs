using HelloWorld.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Topic 1 start

            ////Array 
            //int[] numbers = new int[] { 1, 2, 3 };

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);

            //}


            ////List 
            //List<string> mans = new List<string>();

            //mans.Add("Rahim");
            //mans.Add("Karim");
            //mans.Add("Salim");
            //mans.RemoveAt(0);
            //for (int i = 0; i < mans.Count; i++) {
            //    Console.WriteLine(mans[i]);
            //}

            //Console.ReadLine();

            //Topic 1 End



            //Topic 2 start
            Animal dog = new Animal("Tom Dog", 3, "Ghew");
            dog.printDetails();
            Animal cat = new Animal("Thom Cat", 2, "Mew");
            cat.printDetails();
            Animal cow = new Animal("Mohesh Cow", 10, "Hamba");
            cow.printDetails();

            Console.WriteLine("Number of animal: " + Animal.animalCount);
            Console.ReadLine();
            //Topic 2 End

            


            //Topic 3 Start



            //Topic 3 End

        }
    }



    //For Topic 2
    public class Animal
    {
        public string name;
        public int age;
        public string voice;
        public static int animalCount = 0;
        DateTime currentTime = DateTime.Now;
        public void printDetails()
        {
            Console.WriteLine("Name: " + name + ", " + "Age: " + age + ", " + "Voice: " + voice + ", " + "Time: " + currentTime);
        }

        public Animal(string _name, int _age, string _voice)
        {
            name = _name;
            age = _age;
            voice = _voice;
            animalCount++;
        }
    }

    class Horse : Animal
    {
        public Horse(string _name, int _age, string _voice) : base(_name, _age, _voice)
        {
        }

        public void DerivedMethod()
        {
            Console.WriteLine("This is a method from the derived class.");
        }
    }


}
