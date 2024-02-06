using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace Assignment4

{

 

    /*================================ Method Overriding =============================*/

    public class Shape

    {

        public virtual void Draw()

        {

            Console.WriteLine("I am Drawing Shape");

        }

    }

    public class Circle : Shape

    {

        public override void Draw()

        {

            Console.WriteLine("I am Drawing Circle");

        }

    }

    public class Square : Shape

    {

        public override void Draw()

        {

            Console.WriteLine("I am Drawing Square");

        }

    }

  

    /*======================== Method Hiding ==========================*/

    public class Student

    {

        public void Read(string firstname, string secondname)

        {

            Console.WriteLine("Base class Invoked");

            Console.WriteLine(firstname+ " " + secondname);

        }

    }

    public class PartTime:Student

    {

        public new void Read(string firstname, string secondname)

        {

            Console.WriteLine("Method Hiding 1");

            base.Read("firstname", "secondname");

            Console.WriteLine("Method Hiding 2");

            Console.WriteLine("Derived class Invoked");

            Console.WriteLine(firstname + " " + secondname);

        }

    }

     /*====================================== Partial Class ============================*/

    partial class Math

    {

        private int num1, num2;

        private Math(int num1, int num2)

        {

            this.num1 = num1;

            this.num2 = num2;

        }

        public int Sum()

        {

            return num1 + num2;

        }

    }

 

    partial class Math

    {

 

        public int Sub()

        {

            return num1 - num2;

        }

    }

    /*====================================== Sealed Class ============================*/

      sealed class MyClass1

    {

        public void SampleMethod()

        {

            Console.WriteLine("Sample Method in Myclass1");

        }

    }

    /*

     * Thorows an error while inheriting

     * class Myclass2:MyClass1 { }

     */

 

    /*====================================== Static Class ============================*/

 

    static class product  //static class cant create and object . You cannot dervice a class

    {

       

        public static int ProductId;

        public static string ProductName;

        public static int ProductPrice;

        static product()

        {

            ProductId = 111;

            ProductName = "abc";

            ProductPrice = 5000;

 

        }

        public static void getProductDetails()

        {

            Console.WriteLine("ProductId is {0}", ProductId);

            Console.WriteLine("ProductName is {0}", ProductName);

            Console.WriteLine("ProductPrice is {0}", ProductPrice);

        }

    }

    class Program

    {

        public void sum(int a , int b)

        {

            Console.WriteLine($"Sum of two numbers is {a+b}");

        }

        public void sum(int a, int b,int c)

        {

            Console.WriteLine($"Sum of three numbers is {a+b+c}");

        }

 

        static void Main(string[] args)

        {

            Console.WriteLine();

            Console.WriteLine("====     Method Overloading      ====");

            Program obj = new Program();

            obj.sum(1, 2);

            obj.sum(1, 2, 3);

            Console.WriteLine();

            Console.WriteLine("====      Method Overriding        ====");

            Console.WriteLine();

            Shape sh = new Shape();

            sh.Draw();

            Shape circle = new Circle();

            circle.Draw();

            Shape square = new Square();

            square.Draw();

            Console.WriteLine();

            Console.WriteLine("====       Method Hiding           ====");

            PartTime partTime = new PartTime();

            partTime.Read("firstname", "secondname");

            Console.WriteLine("Method Hiding 3");

            ((Student)partTime).Read("firstname", "secondname");

 

            // Console.WriteLine();

            // Console.WriteLine("Partial class");

            // Console.WriteLine();

            //Math m = new Math(10, 5);

            Console.WriteLine();

            Console.WriteLine("====       Static Class           ====");

            Console.WriteLine();

            product.getProductDetails();

 

        }

    }

}
