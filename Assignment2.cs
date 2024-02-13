using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    /*=============================== Default Constructor ============================*/
   
    public class Customer
    {
        public string firstName;
        public string lastName;
        public Customer()
        {

        }
    }
    /*=============================== Parameter Constructor ============================*/
    class ParameterConstructor
    {
        public int FirstNumber;
        public int SecondNumber;

        public ParameterConstructor(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
    }
    /*=============================== Copy Constructor ============================*/

    public class Employee
    {
        public string firstName;
        public string lastName;
        public string position;
        public int salary;
        public Employee()
        {

        }

        // Copy constructor.  
        public Employee(Employee employee)
        {
            firstName = employee.firstName;
            lastName = employee.lastName;
            position = employee.position;
            salary = employee.salary;
        }

    }
    /*=============================== Static  Constructor ============================*/

    public class Customer1
    {
        public string firstName;
        public string lastName;
        public static string discount;

        public Customer1(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
        static Customer1()
        {
            discount = 10 + "%";
        }
        public void CustomerDetails()
        {
            Console.WriteLine("Full Name:{0}", firstName + " " + lastName);
            Console.WriteLine("Discount:{0}", discount + "\n");
        }
      
    }
    /*=============================== Private  Constructor ============================*/

    public class Candidate
    {
        private Candidate()
        {

        }
        public static int CandidateVisitedForInterview;
        public static int CountCandidate()
        {
            return ++CandidateVisitedForInterview;
        }

    }

    /*================================== Destructor ============================*/

    class Complex
    {

        // Class members, private 
        // by default 
        int real, img;

        // Defining the constructor 
        public Complex()
        {
            real = 0;
            img = 0;
        }

        // SetValue method sets 
        // value of real and img 
        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }

        // DisplayValue displays 
        // values of real and img 
        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }

        // Defining the destructor 
        // for class Complex 
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }

    } // End class Complex 


    internal class Program
    {
        static void Main(string[] args)
        {
            /*=============================== Default Constructor ============================*/
            Console.WriteLine("Default Constructor");
            Customer custormer = new Customer();
            custormer.firstName = "Farhan";
            custormer.lastName = "Ahmed";

            Console.WriteLine("Full Name:" + custormer.firstName + " " + custormer.lastName);
            /*=============================== Parameter Constructor ============================*/
            Console.WriteLine();
            Console.WriteLine("Parameter Constructor");
            ParameterConstructor p = new ParameterConstructor(10, 20);
            int Result = p.FirstNumber + p.SecondNumber;

            Console.WriteLine("Total:" + Result);
            /*=============================== Copy Constructor ============================*/
         Console.WriteLine();
            Console.WriteLine("Copy Constructor");
            Employee emp = new Employee();
            Employee emp1 = new Employee(emp);

            Console.WriteLine("Enter your first name:");
            emp1.firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your last name:");
            emp1.lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your position:");
            emp1.position = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your salary:");
            emp1.salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Name:" + emp1.firstName);
            Console.WriteLine("Last Name:" + emp1.lastName);
            Console.WriteLine("Position:" + emp1.position);
            Console.WriteLine("Salary:" + emp1.salary);
            /*=============================== Static  Constructor ============================*/
            Console.WriteLine();
            Console.WriteLine("Static  Constructor");
            Customer1 c1 = new Customer1("Farhan", "Ahmed");
            Customer1 c2 = new Customer1("Abdul", "Jabbar");
            c1.CustomerDetails();
            c2.CustomerDetails();
            /*=============================== Private  Constructor ============================*/
            Console.WriteLine();
            Console.WriteLine("Private  Constructor");
            //Candidate candidate = new Candidate();  
            Candidate.CandidateVisitedForInterview = 20;
            Candidate.CountCandidate();
            Console.WriteLine("Interviewed candidates: {0}", Candidate.CandidateVisitedForInterview);
            /*=============================== Destructor ============================*/
            Console.WriteLine();
            Console.WriteLine("Destructor");
            Complex C = new Complex();
            C.SetValue(2, 3);
            C.DisplayValue();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    /*============================== public Access Specifier ============================*/
    class Student
    {

        // Declaring members rollNo
        // and name as public
        public int rollNo;
        public string name;

        // Constructor
        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        // methods getRollNo and getName
        // also declared as public
        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }
    /*============================== protectedAccessModifier ============================*/
    class X
    {

        // Member x declared
        // as protected
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    // class Y inherits the 
    // class X
    class Y : X
    {

        // Members of Y can access 'x'
        public int getX()
        {
            return x;
        }
    }
    /*============================== internalAccessModifier ============================*/
    // Declare class Complex as internal
    internal class Complex
    {

        int real;
        int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }
    /*============================== protected internal ============================*/
    /* public class Parent
     {

         // Declaring member as protected internal
         protected internal int value;
     }
     class ABC
     {

         // Trying to access 
         // value in another class
         public void testAccess()
         {
             // Member value is Accessible
             Parent obj1 = new Parent();
             obj1.value = 12;
         }
     }
     class Child : Parent
     {

         // Main Method
         public static void Main(String[] args)
         {
             // Accessing value in another assembly
             Child obj3 = new Child();

             // Member value is Accessible
             obj3.value = 9;
             Console.WriteLine("Value = " + obj3.value);
         }
     }*/
    /*============================== private  Accessibility Level ============================*/
    class Parent1
    {

        // Member is declared as private
        private int value;

        // value is Accessible 
        // only inside the class
        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
    }
    class Child1 : Parent1
    {

        public void showValue()
        {
            // Trying to access value
            // Inside a derived class
            // Console.WriteLine( "Value = " + value );
            // Gives an error
        }
    }

    /*============================== private protected Accessibility Level ============================*/
    class Parent2
    {

        // Member is declared as private protected
        private protected int value;

        // value is Accessible only inside the class
        public void setValue(int v)
        {
            value = v;
        }
        public int getValue()
        {
            return value;
        }
    }

    class Child2 : Parent2
    {

        public void showValue()
        {
            // Trying to access value
            // Inside a derived class

            Console.WriteLine("Value = " + value);
            // value is accessible
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            /*============================== public Access Specifier ============================*/
            Console.WriteLine();
            Console.WriteLine("Public Access Specifier");
            // Creating object of the class Student
            Student S = new Student(1, "Astrid");

            // Displaying details directly
            // using the class members
            // accessible through another method
            Console.WriteLine("Roll number: {0}", S.rollNo);
            Console.WriteLine("Name: {0}", S.name);

            Console.WriteLine();

            // Displaying details using 
            // member method also public
            Console.WriteLine("Roll number: {0}", S.getRollNo());
            Console.WriteLine("Name: {0}", S.getName());
            Console.WriteLine();
            Console.WriteLine();
            /*============================== protectedAccessModifier ============================*/
            X obj1 = new X();
            Y obj2 = new Y();

            // Displaying the value of x
            Console.WriteLine("Value of x is : {0}", obj2.getX());
            /*============================== internalAccessModifier ============================*/
            Complex c = new Complex();

            // Accessible in class Program
            c.setData(2, 1);
            c.displayData();
            /*============================== private  Accessibility Level ============================*/
            Parent1 obj = new Parent1();

            // obj.value = 5;
            // Also gives an error

            // Use public functions to assign
            // and use value of the member 'value'
            obj.setValue(4);
            Console.WriteLine("Value = " + obj.getValue());
            /*============================== private protected Accessibility Level ============================*/
            Parent2 pa = new Parent2();
            pa.setValue(4);
            Console.WriteLine("Value = " + pa.getValue());

        }
    }
}

