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
    /*class Class1
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
    */
   

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
    
    //Function Hiding
   /* class Class1
    {
        public void display()
        {
            Console.WriteLine("Super class display method");
        }
    }
    class Class2 : Class1
    {
        public new void display() 
        {
            Console.WriteLine("Sub class display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.display();
            Console.ReadKey();
        }
    }
    */

    //Encapsulation
    /*public class Bank
    {
        private double balance;
        public double getBalance()
        {
            return balance;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
    }
    class BankUser
    {
        public static void Main()
        {
            Bank SBI = new Bank();
            SBI.setBalance(1000);
            Console.WriteLine(SBI.getBalance());
            Console.WriteLine("Press any key to exits.");
            Console.ReadLine();
        }
    }*/

    //Inheritance
    class Branch
    {
        int BranchCode;
        string BranchName,BranchAddress;
        public void GetBranchData()
        {
            Console.WriteLine("Enter Branch Details:");
            Console.WriteLine("Enter Branch Code:");
            BranchCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Branch Name:");
            BranchName = Console.ReadLine();
            Console.WriteLine("Enter Branch Address:");
            BranchAddress = Console.ReadLine();
        }
        public void DisplayBranchData()
        {
            Console.WriteLine("Branch Code is : " + BranchCode);
            Console.WriteLine("Branch Name is : " + BranchName);
            Console.WriteLine("Branch Address is : " + BranchAddress);
        }
    }
    class Employee : Branch
    {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAddress;
        public void GetEmployeeData()
        {
            Console.WriteLine("Enter Employee Details: ");
            Console.WriteLine("Enter Employee ID: ");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Age: ");
            EmployeeAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Address: ");
            EmployeeAddress = Console.ReadLine();
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine("Employee Id is : " + EmployeeId);
            Console.WriteLine("Employee Name is : " + EmployeeName);
            Console.WriteLine("Employee Address is : " + EmployeeAddress);
            Console.WriteLine("Employee Age is : " + EmployeeAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.GetBranchData();
            obj1.GetEmployeeData();
            obj1.DisplayBranchData();
            obj1.DisplayEmployeeData();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
























