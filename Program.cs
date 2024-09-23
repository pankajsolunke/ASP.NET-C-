using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_01
{
    //Function Overloading 
    /* class Program
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float x,float y)
        {
            Console.WriteLine(x + y);
        }
        public void add(string s1,string s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.add(12, 34);
            obj.add(12.3f, 34.6f);
            obj.add("pankaj" , "solunke");
            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        }
    }*/

    //Function Overriding
    class Class1
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }

    class Class2 : Class1
    {
        public override void show()
        {
            Console.WriteLine("Sub class override show method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Class1 obj2 = new Class2();
            obj1.show();
            obj2.show();
            Console.ReadLine();
        }
    }
   

    /*class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Program1
    {
        static void Main()
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.Speak();  // Output: Animal speaks
            myDog.Speak();     // Output: Woof!
            myCat.Speak();     // Output: Meow!
        }
    }
    */

}
























