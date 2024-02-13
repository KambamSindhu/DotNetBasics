using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /*======================== Try Catch ========================================*/
    class TryCatch
    {
        public void  Try()
            {
            // Declare an array of max index 4
		int[] arr = { 1, 2, 3, 4, 5 };

		// Display values of array elements
		for (int i = 0; i<arr.Length; i++) {
			Console.WriteLine(arr[i]);
		}

		try {

			// Try to access invalid index of array
			Console.WriteLine(arr[7]);
			// An exception is thrown upon executing
			// the above line
		}
		catch (IndexOutOfRangeException e) {

			// The Message property of the object 
			// of type IndexOutOfRangeException
			// is used to display the type of exception
			// that has occurred to the user.
			Console.WriteLine("An Exception has occurred : {0}", e.Message);
		}
            }
}
    /*============================= TRY CATCH FINALLY ===========================*/
    class Tcf
    {
        public void Trc()
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result: {Result}");
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
            finally
            {
                Console.WriteLine("Hello this is finally block...");
            }
        }
    }
    /* ======================= TRY FINALLY =====================================*/
    class Tryfin
    {
        public void fin()
        {
            
                try
                {
                    Console.WriteLine("Inside SomeMethod");
                    int num1 = 10, num2 = 0;
                    int result = num1 / num2; //Exception will be thrown here
                    Console.WriteLine($"Result: {result}");
                }
                finally
                {
                    Console.WriteLine("SomeMethod finally Block");
                }
            
        }
    }
    /*========================= MUTIPLE TRY CATCH BLOCK ==========================*/
    class Mutipletry
    {
        public void Mutiple()
        {
            int[] arr = { 19, 0, 75, 52 };

            try
            {

                // Try to generate an exception
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            // Catch block for invalid array access
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Finally block
            // Will execute irrespective of the above catch blocks
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
            }

        }
    }
    /*========================= SINGLE CAST DELEGATE =============================*/
    public delegate void AddDelegate(int x, int y);
    class Addition
    {
        public void Add(int x,int y) 
        {
            Console.WriteLine("Addition of two number is " + (x + y));
        }
    }
    /*=========================== MUTICAST DELEGATE================================*/
    public delegate void CalDelegate(int w, int ht);
    class Cal
    {
        public void Area(int w,int ht)
        {
            Console.WriteLine("Area is "+(w*ht));
        }
        public void peri(int w,int ht)
        {
            Console.WriteLine("Perimeter is "+(2*(w+ht)));
        }
    }
    /*============================== AnNONYMOUS DELEGATE ===========================*/
    public delegate string GreetingsDelegate(string str);


    /*============================== NESTED TRY BLOCK ============================*/
    class NestedTry
    {
        public void nested()
        {
            // Here, number is greater 
            // than divisor. 
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };

            // Outer try block 

            // Here IndexOutOfRangeException occurs 
            // due to which program may terminates 
            try
            {

                for (int j = 0; j < number.Length; j++)
                {

                    // Inner try block 

                    // Here DivideByZeroException caught 
                    // and allow the program to continue 
                    // its execution 

                    try
                    {

                        Console.WriteLine("Number: " + number[j] +
                                        "\nDivisor: " + divisor[j] +
                                        "\nQuotient: " + number[j] / divisor[j]);
                    }

                    // Catch block for inner try block 
                    catch (DivideByZeroException)
                    {

                        Console.WriteLine("Inner Try Catch Block");
                    }
                }
            }

            // Catch block for outer try block 
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Outer Try Catch Block");

            }
        }
    }
   
    internal class Program
    {
        /*================================= GENERIC DELEGATES =================================*/

        public static double Add1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void Add2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            
            //SINGLE CAST DELEGATE
            Addition a =new Addition();
            AddDelegate ad = new AddDelegate(a.Add);
            Console.WriteLine("SINGLE CAST DELEGATE");
            ad.Invoke(1, 2);
            Console.WriteLine();

            //MULTICAST DELEGATE
            Cal cal = new Cal();
            CalDelegate cdel = new CalDelegate(cal.Area);
            cdel += cal.peri;
            Console.WriteLine("MULTICAST DELEGATE");
            cdel(12, 13);

            //ANONYMOUS DELEGATE
            Console.WriteLine("\n ANONYMOUS DELEGATE");
            GreetingsDelegate del = delegate (string str)
            {
                return "hello " + str + " Good Morning";
            };
            Console.WriteLine(del.Invoke("Raj"));

            //FUNC DELEGATE
            Console.WriteLine();
            Console.WriteLine();
            Func<int, float, double, double> fu = Add1;
            double res = fu.Invoke(100, 34.5f, 193.456);
            Console.WriteLine("FUNC DELEGATE "+res);

            //Try Catch
            Console.WriteLine();
            Console.WriteLine("Try Catch");
            TryCatch tryCatch = new TryCatch();
            tryCatch.Try();

            //MUTIPLE  CATCH BLOCK
            Console.WriteLine();
            Console.WriteLine("MUTIPLE TRY CATCH BLOCK");
            Mutipletry mutipletry = new Mutipletry();
            mutipletry.Mutiple();
            //TRY CATCH FINALLY
            Console.WriteLine();
            Console.WriteLine("TRY CATCH FINALLY");
            Tcf tcf = new Tcf();
            tcf.Trc();
            // NESTED TRY BLOCK
            Console.WriteLine();
            Console.WriteLine("NESTED TRY BLOCK");
            NestedTry nestedTry = new NestedTry();
            nestedTry.nested();
            //TRY FINALLY
            Console.WriteLine();
            Console.WriteLine("TRY FINALLY");
            Tryfin tryfin = new Tryfin();
            tryfin.fin();
           




        }
    }
}
