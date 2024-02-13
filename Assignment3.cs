using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1
{

    /*=========================== Encapsulation ======================*/
    class Account
    {
        private int accountBalance = 1000;

        //public void SetBalance(int amount)
        //{
        //    accountBalance = amount;
        //}
        //public int GetBalance()
        //{
        //    return accountBalance;
        //}
        /*Using c# propeties to create getter and setter*/

        public int Balance { 
            get {
                return accountBalance;
            } 
            set 
            { 
                accountBalance = value;
            }
        }



    }
    /*=========================== Abstraction Using Abstract Class ======================*/

    // abstract class 'G'
    public abstract class G
    {

        // abstract method 'gfg1()'
        public abstract void gfg1();
    }

    // class 'G' inherit
    // in child class 'G1'
    public class G1 : G
    {

        // abstract method 'gfg1()'
        // declare here with
        // 'override' keyword
        public override void gfg1()
        {
            Console.WriteLine("Class name is G1");
        }
    }

    // class 'G' inherit in
    // another child class 'G2'
    public class G2 : G
    {

        // same as the previous class
        public override void gfg1()
        {
            Console.WriteLine("Class name is G2");
        }
    }

    /*=========================== Abstraction Using Interface ======================*/


    // A simple interface
    interface interface1
    {

        // method having only declaration
        // not definition
        void show();
    }

    // A class that implements the interface.
    class MyClass : interface1
    {

        // providing the body part of function
        public void show()
        {
            Console.WriteLine("Welcome !!!");
        }

    }
    /*=========================== inheritance ======================*/

    /*=========================== inheritance ======================*/
    // single inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
    /*=========================== inheritance ======================*/
    // multi-level inheritance
    class Mammal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Mammal is running.");
        }
    }

    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse is galloping.");
        }
    }
    /*=========================== inheritance ======================*/
    // hierarchical inheritance
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting.");
        }
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }
    /*=========================== inheritance ======================*/
    // multiple inheritance
    interface I1
    {
        void Method1();
    }

    interface I2
    {
        void Method2();
    }

    class MyClass1 : I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 is called.");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 is called.");
        }
    }

    /*=========================== inheritance ======================*/
    // Hybrid inheritance
    class Animal1
    {
        protected string name;

        public Animal1(string name)
        {
            this.name = name;
        }

        public void Eat1()
        {
            Console.WriteLine($"{name} is eating.");
        }
    }

    // Derived class
    class Dog1 : Animal1
    {
        public Dog1(string name) : base(name)
        {
        }

        public void Bark1()
        {
            Console.WriteLine($"{name} is barking.");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            // MyAccount.accountBalance = 2000; 
            //changing value of the account balance cannot be done
            Console.WriteLine();
            Console.WriteLine("=====  Encapsulation  ======");
            // myAccount.SetBalance(2000);
            //Console.WriteLine("Your account Balance is " + myAccount.GetBalance());
            myAccount.Balance = 2000;
            Console.WriteLine("Your account Balance is " + myAccount.Balance);
            Console.WriteLine();
            Console.WriteLine("==== Abstraction Using Abstract Class =====");
            Console.WriteLine();
            // 'obj' is object of class
            // 'G' class '
            // G' cannot
            // be instantiate
            G obj;

            // instantiate class 'G1'
            obj = new G1();

            // call 'gfg1()' of class 'G1'
            obj.gfg1();

            // instantiate class 'G2'
            obj = new G2();

            // call 'gfg1()' of class 'G2'
            obj.gfg1();

                Console.WriteLine();
                Console.WriteLine("Abstraction Using Interface");

                // Creating object
                MyClass obj1 = new MyClass();

                // calling method
                obj1.show();
            Console.WriteLine();
            Console.WriteLine("====== Inheritance ===========");
            Console.WriteLine();
            Console.WriteLine("====== Single Inheritance ===========");
            // single inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.WriteLine();
            Console.WriteLine("====== multi-level Inheritance ===========");
            // multi-level inheritance
            Horse horse = new Horse();
            horse.Eat();
            horse.Run();
            horse.Gallop();
            Console.WriteLine();
            Console.WriteLine("====== hierarchical Inheritance ===========");
            // hierarchical inheritance
            Eagle eagle = new Eagle();
            Penguin penguin = new Penguin();
            eagle.Fly();
            eagle.Hunt();
            penguin.Fly();
            penguin.Swim();
            Console.WriteLine();
            Console.WriteLine("====== multiple Inheritance ===========");
            // multiple inheritance
            MyClass1 myClass = new MyClass1();
            myClass.Method1();
            myClass.Method2();
            Console.WriteLine();
            Console.WriteLine("==== Hybrid Inheritance  =======");
            // Creating an instance of the derived class
            Dog1 myDog = new Dog1("Buddy");

            // Accessing the inherited method from the base class
            myDog.Eat1(); // Output: Buddy is eating.

            // Accessing the method defined in the derived class
            myDog.Bark1(); // Output: Buddy is barking.

        }
    }
}
