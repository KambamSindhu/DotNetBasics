using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    internal class Program
    {
        public void DataTypes()
        {
            byte b1 = 66;
            //You cannot store negative number using byte data type.
            //The following statement will give compile time error
            //byte b2 = -100;

            //The following Statement will give compile time error
            //The maximum value you can store in a byte variable is 255
            //byte b3 = 256;

            Console.WriteLine($"Decimal: {b1}");
            Console.WriteLine($"ASCII Equivalent Character of {b1} is {(char)b1}");
            Console.WriteLine($"Byte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            Console.WriteLine($"Byte Size:{sizeof(sbyte)} Byte");

            sbyte sb1 = 66;
            //You can store negative number using sbyte data type.
            //The following statement will not give compile time error
            sbyte sb2 = -100;

            //The following Statement will give compile time error
            //The maximum value you can store in a sbyte variable is 128
            //sbyte sb3 = 128;

            //The following Statement will give compile time error
            //The minimum value you can store in a sbyte variable is -128
            //sbyte sb4 = -129;

            Console.WriteLine($"\nDecimal: {sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb1} is {(char)sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb2} is {(char)sb2}");
            Console.WriteLine($"SByte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            Console.WriteLine($"SByte Size:{sizeof(sbyte)} Byte");


            char ch = 'B';
            Console.WriteLine($"Char: {ch}");
            Console.WriteLine($"Equivalent Number: {(byte)ch}");
            Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
            Console.WriteLine($"Char Size: {sizeof(char)} Byte");

            string str = "ABC";

            var howManyBytes = str.Length * sizeof(Char);
            Console.WriteLine($"str Value: {str}");
            Console.WriteLine($"str Size: {howManyBytes}");

            Int16 num1 = 123;
            Int32 num2 = 456;
            Int64 num3 = 789;

            Console.WriteLine($"Int16 Min Value:{Int16.MinValue} and Max Value:{Int16.MaxValue}");
            Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");

            Console.WriteLine($"Int32 Min Value:{Int32.MinValue} and Max Value:{Int32.MaxValue}");
            Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");

            Console.WriteLine($"Int64 Min Value:{Int64.MinValue} and Max Value:{Int64.MaxValue}");
            Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");


        }
        public void literals()
        {
            Console.WriteLine();
            Console.WriteLine("literals");
            int a = 101;
            int c = 0x123f;
            int d = 0b1111;

            Console.WriteLine($"Decimal Literal: {a}");
            Console.WriteLine($"Hexa-Decimal Literal: {c}");
            Console.WriteLine($"Binary Literal: {d}");

        }
        public void ImplictTypeCasting()
        {

            Console.WriteLine();
            Console.WriteLine("ImplictTypeCasting");
            int numInt = 1500;

            //Get type of numInt
            Type numIntType = numInt.GetType();

            // Implicit Conversion
            double numDouble = numInt;

            //Get type of numDouble
            Type numDoubleType = numDouble.GetType();

            // Value Before Conversion
            Console.WriteLine($"numInt value: {numInt}");
            Console.WriteLine($"numInt Type: {numIntType}");
            Console.WriteLine($"Int Size: {sizeof(int)} Bytes");

            // Value After Conversion
            Console.WriteLine($"numDouble value: {numDouble}");
            Console.WriteLine($"numDouble Type: {numDoubleType}");
            Console.WriteLine($"double Size: {sizeof(double)} Bytes");

        }
        public void ExplictTypeCasting()
        {
            Console.WriteLine();
            Console.WriteLine("Explict Type Casting");
            double numDouble = 1.23;
            // Explicit Type Casting
            int numInt = (int)numDouble;
            // Value Before Conversion
            Console.WriteLine("Original double Value: " + numDouble);
            // Value After Conversion
            Console.WriteLine("Converted int Value: " + numInt);

        }
        static int xyzzz = 100; //Static Variable
        public void Variables()
        {
            Console.WriteLine();
            Console.WriteLine("Variables");

            int y = 200; //Non-Static or Instance Variable

            Console.WriteLine($"x value: {xyzzz}");
            Console.WriteLine($"x value: {y}");
        }
        public void Arithmetic()
        {
            Console.WriteLine();
            Console.WriteLine("Arithmetic Operator");
            int Result;
            int Num1 = 20, Num2 = 10;
            // Addition Operation
            Result = (Num1 + Num2);
            Console.WriteLine($"Addition Operator: {Result}");

            // Subtraction Operation
            Result = (Num1 - Num2);
            Console.WriteLine($"Subtraction Operator: {Result}");

            // Multiplication Operation
            Result = (Num1 * Num2);
            Console.WriteLine($"Multiplication Operator: {Result}");

            // Division Operation
            Result = (Num1 / Num2);
            Console.WriteLine($"Division Operator: {Result}");

            // Modulo Operation
            Result = (Num1 % Num2);
            Console.WriteLine($"Modulo Operator: {Result}");

        }
        public void Assignment()
        {
            Console.WriteLine();
            Console.WriteLine("Assignment Operator");
            // Initialize variable x using Simple Assignment Operator "="
            int x = 15;

            x += 10;  //It means x = x + 10 i.e. 15 + 10 = 25
            Console.WriteLine($"Add Assignment Operator: {x}");

            // initialize variable x again
            x = 20;
            x -= 5;  //It means x = x - 5 i.e. 20 - 5 = 15
            Console.WriteLine($"Subtract Assignment Operator: {x}");

            // initialize variable x again
            x = 15;
            x *= 5; //It means x = x * 5  i.e. 15 * 5 = 75
            Console.WriteLine($"Multiply Assignment Operator: {x}");

            // initialize variable x again
            x = 25;
            x /= 5; //It means x = x / 5 i.e. 25 / 5 = 5
            Console.WriteLine($"Division Assignment Operator: {x}");

            // initialize variable x again
            x = 25;
            x %= 5; //It means x = x % 5 i.e. 25 % 5 = 0
            Console.WriteLine($"Modulo Assignment Operator: {x}");
        }
        public void Relational()
        {
            Console.WriteLine();
            Console.WriteLine("Relational  Operator");

            bool Result;
            int Num1 = 5, Num2 = 10;

            // Equal to Operator
            Result = (Num1 == Num2);
            Console.WriteLine("Equal (=) to Operator: " + Result);

            // Greater than Operator
            Result = (Num1 > Num2);
            Console.WriteLine("Greater (<) than Operator: " + Result);

            // Less than Operator
            Result = (Num1 < Num2);
            Console.WriteLine("Less than (>) Operator: " + Result);

            // Greater than Equal to Operator
            Result = (Num1 >= Num2);
            Console.WriteLine("Greater than or Equal to (>=) Operator: " + Result);

            // Less than Equal to Operator
            Result = (Num1 <= Num2);
            Console.WriteLine("Lesser than or Equal to (<=) Operator: " + Result);

            // Not Equal To Operator
            Result = (Num1 != Num2);
            Console.WriteLine("Not Equal to (!=) Operator: " + Result);
        }
        public void Logical()
        {
            Console.WriteLine();
            Console.WriteLine("Logical   Operator");
            bool x = true, y = false, z;

            //Logical AND operator
            z = x && y;
            Console.WriteLine("Logical AND Operator (&&) : " + z);

            //Logical OR operator
            z = x || y;
            Console.WriteLine("Logical OR Operator (||) : " + z);

            //Logical NOT operator
            z = !x;
            Console.WriteLine("Logical NOT Operator (!) : " + z);
        }

        public void Bitwise()
        {
            Console.WriteLine();
            Console.WriteLine("Bitwise   Operator");
            int a = 12, b = 25, Result;
            // Bitwise AND Operator
            Result = a & b;
            Console.WriteLine($"Bitwise AND: {Result}");
            // Bitwise OR Operator
            Result = a | b;
            Console.WriteLine($"Bitwise OR: {Result}");
            // Bitwise XOR Operator
            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR: {Result}");
        }
        public void Unary()
        {
            Console.WriteLine();
            Console.WriteLine("Unary   Operator");

            int x = 10;
            // Result1 is assigned 10 only,
            // x is not updated yet
            int Result1 = x++;
            //x becomes 11 now
            Console.WriteLine("x is {0} and Result1 is {1}", x, Result1);
            // Pre-Increment 
            int y = 10;
            int Result2 = ++y;
            //y and Result2 have same values = 11
            Console.WriteLine("y is {0} and Result2 is {1}", y, Result2);
        }

        public void Ternary()
        {
            Console.WriteLine();
            Console.WriteLine("Ternary   Operator");
            int a = 20, b = 10, res;
            res = ((a > b) ? a : b);
            Console.WriteLine("Result = " + res);

        }
        public void IfElse()
        {
            Console.WriteLine();
            Console.WriteLine("IfElse");
            int i = 23;
            if (i == 10)
            {
                Console.WriteLine("i is 10");
            }
            else if (i == 15)
            {
                Console.WriteLine("i is 15");
            }
            else if (i == 20)
            {
                Console.WriteLine("i is 20");
            }
            else
            {
                Console.WriteLine("i is not present");
            }
        }
        public void NestedIfElse()
        {
            int a = 15, b = 25, c = 10;
            int LargestNumber = 0;

            if (a > b)
            {
                Console.WriteLine($"Outer IF Block");
                if (a > c)
                {
                    Console.WriteLine($"Outer IF - Inner IF Block");
                    LargestNumber = a;
                }
                else
                {
                    Console.WriteLine($"Outer IF - Inner ELSE Block");
                    LargestNumber = c;
                }
            }
            else
            {
                Console.WriteLine($"Outer ELSE Block");
                if (b > c)
                {
                    Console.WriteLine($"Outer ELSE - Inner IF Block");
                    LargestNumber = b;
                }
                else
                {
                    Console.WriteLine($"Outer ELSE - Inner ELSE Block");
                    LargestNumber = c;
                }
            }

            Console.WriteLine($"The Largest Number is: {LargestNumber}");
        }

        public void NestedSwitch()
        {
            Console.WriteLine();
            Console.WriteLine("NestedSwitch");
            //Ask the user to enter a number between 1 and 3
            Console.Write("Enter a Number Between 1 and 3:");
            int number = Convert.ToInt32(Console.ReadLine());

            //outer Switch Statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("You Entered One");
                    //Ask the user to enter the character R, B, or G
                    Console.Write("Enter Color Code (R/G/B): ");
                    char color = Convert.ToChar(Console.ReadLine());

                    //Inner Switch Statement
                    switch (Char.ToUpper(color))
                    {
                        case 'R':
                            Console.WriteLine("You have Selected Red Color");
                            break;
                        case 'G':
                            Console.WriteLine("You have Selected Green Color");
                            break;
                        case 'B':
                            Console.WriteLine("You have Selected Blue Color");
                            break;
                        default:
                            Console.WriteLine($"You Have Enter Invalid Color Code: {Char.ToUpper(color)}");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("You Entered Two");
                    break;

                case 3:
                    Console.WriteLine("You Entered Three");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

        }
        public void Switch()
        {
            Console.WriteLine();
            Console.WriteLine("Switch");
            string category;

            // taking topic name
            string topic = "Inheritance";

            // using switch Statement
            switch (topic)
            {
                case "Introduction to C#":
                case "Variables":
                case "Data Types":
                    category = "Basic";
                    break;
                case "Loops":
                case "If ELSE Statements":
                case "Jump Statements":
                    category = "Control Flow";
                    break;
                case "Inheritance":
                case "Polymorphism":
                case "Abstraction":
                case "Encapsulation":
                    category = "OOPS Concept";
                    break;
                // default case 
                default:
                    category = "Invalid";
                    break;
            }

            Console.Write($"{topic} Category is {category}");
        }

        public void While()
        {
            Console.WriteLine();
            Console.WriteLine("While");
            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine("Value of x:" + x);
                x++;
            }
        }
        public void DoWhile()
        {
            Console.WriteLine();
            Console.WriteLine("Do While");
            int number = 1;
            do
            {
                Console.Write($"{number} ");
                number++;
            } while (number <= 5);
        }
        public void For()
        {
            Console.WriteLine();
            Console.WriteLine("For");
            Console.Write("Enter one Integer Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int counter = 1; counter <= number; counter++)
            {
                Console.WriteLine(counter);
            }
        }
        public void Break()
        {
            Console.WriteLine();
            Console.WriteLine("Break");
            for (int outer = 1; outer <= 5; outer++)
            {
                Console.WriteLine($"Outer: {outer}");
                for (int inner = 1; inner <= 5; inner++)
                {
                    if (inner > 3)
                    {
                        break;
                    }
                    Console.Write($"  Inner: {inner}");
                }
                Console.WriteLine();
            }
        }
        public void Continue()
        {
            Console.WriteLine();
            Console.WriteLine("Continue");
            for (int outer = 1; outer <= 5; outer++)
            {
                Console.WriteLine($"Outer: {outer}");
                for (int inner = 1; inner <= 5; inner++)
                {
                    if (inner == 3)
                    {
                        continue;
                    }
                    Console.Write($"  Inner: {inner}");
                }
            }
}
        public void Goto()
        {
            Console.WriteLine();
            Console.WriteLine("Goto");
            Console.WriteLine("1st Statement: ");
            goto label2;   //goto label label2:
            Console.WriteLine("2nd Statement: ");
        label1:    //label:
            Console.WriteLine("3rd Statement: ");
        label2:    //label:
            Console.WriteLine("4th Statement: ");
        label3:    //label:
            Console.WriteLine("5th Statement: ");
            Console.WriteLine("End of Main Method Statement: ");
        }
    static void Main(string[] args)
        {
            Program obj = new Program();
            //Methods and Properties of Console Class in C#
            string name = "Pranaya";
            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);
            Console.Write($"Hello {name}");


            obj.DataTypes();
            obj.literals();
            obj.ImplictTypeCasting();
            obj.ExplictTypeCasting();
            obj.Arithmetic();
            obj.Assignment();
            obj.Relational();
            obj.Logical();
            obj.Bitwise();
            obj.Unary();
            obj.Ternary();
            obj.IfElse();
            obj.NestedIfElse();
            obj.Switch();
            obj.NestedSwitch();
            obj.While();
            obj.DoWhile();
            obj.For();
            obj.Break();
            obj.Continue();
            obj.Goto();


        }
    }
}
