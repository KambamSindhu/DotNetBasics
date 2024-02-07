using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Collections;

 

namespace AssignmentCollections

{

    class ArrayClass

    {

        public void Arr()

        {

 

            Console.WriteLine();

            Console.WriteLine("Implementation of array");

 

         

            Console.WriteLine("Enter a number");

            int size = Convert.ToInt32(Console.ReadLine());

            int[] ar = new int[size];

            Console.WriteLine($"Enter {size} number");

            for (int i=0; i<ar.Length; i++)

            {

                ar[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Elements of array are");

            for (int i = 0; i < ar.Length; i++)

            {

               

                 Console.WriteLine(ar[i]);

            }

            Console.WriteLine("Sorting an array");

            Array.Sort(ar);

            for (int i = 0; i < ar.Length; i++)

            {

 

                Console.WriteLine(ar[i]);

            }

            Console.WriteLine("Reverse an array");

            Array.Reverse(ar);

            for (int i = 0; i < ar.Length; i++)

            {

 

                Console.WriteLine(ar[i]);

            }

            Console.WriteLine("Copying form one array to array");

            int[] newarr = new int[ar.Length];

            Array.Copy(ar,newarr, newarr.Length);

            for (int i = 0; i < ar.Length; i++)

            {

 

                Console.WriteLine(ar[i]);

            }

            Console.WriteLine("Length of an array is "+ ar.Length);

            Console.WriteLine("Two dimensional Arrays");

            //int[,] RectangleArray = new int[4, 5];

           

          

        }

    }

    class ArrayListClass

    {

        public void ArrayLi()

        {

            Console.WriteLine("ArrayList Implementation");

            //creating ArrayList

            ArrayList arrayList1 = new ArrayList();

            //Adding elements to ArrayList using Add() method

            arrayList1.Add(101); //Adding Integer Value

            arrayList1.Add("James"); //Adding String Value

            arrayList1.Add("James"); //Adding Duplicate Value

            arrayList1.Add(" "); //Adding Empty

            arrayList1.Add(true); //Adding Boolean

            arrayList1.Add(4.5); //Adding double

            arrayList1.Add(null); //Adding null

            Console.WriteLine("Elements of ArrayList1");

            for (int i=0;i<arrayList1.Count;i++)

            {

                Console.WriteLine(arrayList1[i]);

            }

            //Adding Elements to ArrayList using object initializer syntax

            Console.WriteLine("Elements of ArrayList2");

            var arrayList2 = new ArrayList()

            {

                102, "Smith", "Smith", true, 15.6

            };

            foreach (var item in arrayList2)

            {

                Console.WriteLine(item);

            }

            //Accessing individual elements from ArrayList using Indexer

            int firstElement = (int)arrayList1[0]; //returns 101

            string secondElement = (string)arrayList1[1]; //returns "James"

            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");

            //Using var keyword without explicit casting

            var firsItem = arrayList1[0]; //returns 101

            var secondItem = arrayList1[1]; //returns "James"

            //var fifthElement = arrayList1[5]; //Error: Index out of range

            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");

            //update elements

            arrayList1[0] = "Smith";

            arrayList1[1] = 1010;

            //arrayList1[5] = 500; //Error: Index out of range

            foreach (var item in arrayList1)

            {

                Console.Write($"{item} ");

            }

            Console.WriteLine("\n"+"Insert \"First Element\" at First Position i.e. Index 0");

            arrayList1.Insert(0, "First Element");

            //Insert "Third Element" at Third Position i.e. Index 2

            arrayList1.Insert(2, "Third Element");

            //Iterating through foreach loop

            foreach (var item in arrayList1)

            {

                Console.WriteLine($"{item}");

 

 

            }

            arrayList1.InsertRange(2, arrayList2);

 

            Console.WriteLine("\n\nArray List Elements After InsertRange");

            foreach (var item in arrayList1)

            {

                Console.Write($"{item} ");

            }

 

            ArrayList arrayList = new ArrayList()

            {

                    "India",

                    "USA",

                    "UK",

                    "Nepal",

                    "HongKong",

                    "Srilanka",

                    "Japan",

                    "Britem",

                    "HongKong",

            };

            Console.WriteLine("Array List Elements");

            foreach (var item in arrayList)

            {

                Console.Write($"{item} ");

            }

 

            arrayList.Remove("HongKong"); //Removes first occurance of null

            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");

            foreach (var item in arrayList)

            {

                Console.Write($"{item} ");

            }

 

           arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index

            Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");

            foreach (var item in arrayList)

            {

                Console.Write($"{item} ");

            }

 

            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");

            foreach (var item in arrayList)

            {

                Console.Write($"{item} ");

            }

            int totalItems = arrayList.Count;

            Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList.Capacity}"));

            //Remove all items from the Array list            

            arrayList.Clear();

 

            totalItems = arrayList.Count;

            Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList.Capacity}"));

            Console.WriteLine($"\n ArrayList Contains India: {arrayList.Contains("India")}"); // true

            //Creating a clone of the arrayList using Clone method

            ArrayList cloneArrayList = (ArrayList)arrayList1.Clone();

            Console.WriteLine("\nCloned ArrayList Elements:");

            foreach (var item in cloneArrayList)

            {

                Console.WriteLine($"{item} ");

            }

            ArrayList arrayList3 = new ArrayList()

            {

                    "India",

                    "USA",

                    "UK",

                    "Denmark",

                    "Nepal",

                    "HongKong",

                    "Austrailla",

                    "Srilanka",

                    "Japan",

                    "Britem",

                    "Brazil",

            };

            //Copying the arrayList to an object array

            object[] arrayListCopy = new object[arrayList3.Count];

            arrayList.CopyTo(arrayListCopy);

            //Console.WriteLine("\nArrayList Copy Array Elements:");

            //foreach (var item in arrayListCopy)

            //{

            //    Console.WriteLine(item);

            //}

            ArrayList arrayList4 = new ArrayList()

            {

                    "India",

                    "USA",

                    "UK",

                    "Denmark",

                    "Nepal",

                    "HongKong",

                    "Austrailla",

                    "Srilanka",

                    "Japan",

                    "Britem",

                    "Brazil",

            };

            // Sorting the elements of  ArrayList Using sort() method

            arrayList.Sort();

            Console.WriteLine("\n\nArray List Elements After Sorting");

            foreach (var item in arrayList)

            {

                Console.Write($"{item} ");

            }

        }

    }

    class HashTableClass

    {

        public void Hash()

        {

            //Creating Hashtable collection with default constructor

            Hashtable hashtable = new Hashtable();

 

            //Adding elements to the Hash table using key value pair

            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001

            hashtable.Add("Name", "James"); //Here key is Name and value is James

            hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500

            hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai

            hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com

            //Printing the keys and their values using foreach loop

            Console.WriteLine("Printing Hashtable using Foreach Loop");

            foreach (object obj in hashtable.Keys)

            {

                Console.WriteLine(obj + " : " + hashtable[obj]);

            }

            //Or

            //foreach (DictionaryEntry de in hashtable)

            //{

            //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");

            //}

 

            Console.WriteLine("\nPrinting Hashtable using Keys");

            //I want to print the Location by using the Location key

            Console.WriteLine("Location : " + hashtable["Location"]);

 

            //I want to print the Email ID by using the EmailID key

            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);

 

            Hashtable hash = new Hashtable()

            {

                {1,"abc,egf,jhd" },

                {2,"szsfd" }

            };

            foreach(DictionaryEntry entry in hash)

            {

                Console.WriteLine(entry.Key + " " + entry.Value) ;

            }

           

            hashtable.Add("Dept", "IT");

          

 

            //Checking the key using the Contains methid

            Console.WriteLine("Is EmailID Key Exists : " + hashtable.Contains("EmailID"));

            Console.WriteLine("Is Department Key Exists : " + hashtable.Contains("Department"));

 

            //Checking the key using the ContainsKey methid

            Console.WriteLine("Is EmailID Key Exists : " + hashtable.ContainsKey("EmailID"));

            Console.WriteLine("Is Department Key Exists : " + hashtable.ContainsKey("Department"));

 

            //Checking the value using the ContainsValue method

            Console.WriteLine("Is Mumbai value Exists : " + hashtable.ContainsValue("Mumbai"));

            Console.WriteLine("Is Technology value Exists : " + hashtable.ContainsValue("Technology"));

 

            Hashtable employee = new Hashtable

            {

                { "EId", 1001 },

                { "Name", "James" },

                { "Salary", 3500 },

                { "Location", "Mumbai" },

                { "EmailID", "a@a.com" }

            };

 

            //Count Property returns the number of elements present in the collection

            Console.WriteLine($"Hashtable Total Elements: {employee.Count}");

 

            // Remove EId as this key exists

            employee.Remove("EId");

            Console.WriteLine($"After Removing EID Total Elements: {employee.Count}");

 

            //Following statement throws run-time exception: KeyNotFoundException

            //employee.Remove("City");

 

            //Check key before removing it

            if (employee.ContainsKey("City"))

            {

                employee.Remove("City");

            }

            else

            {

                Console.WriteLine("Hashtable doesnot contain City key");

            }

 

            //Removes all elements

            employee.Clear();

            Console.WriteLine($"After Clearing Hashtable Total Elements: {employee.Count}");

            hashtable[1] = "One";

            hashtable[5] = "Five";

            hashtable[30] = "Thirty";

 

            foreach (DictionaryEntry de in hashtable)

            {

                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");

            }

            Hashtable cloneHashtable = (Hashtable)hashtable.Clone();

            Console.WriteLine("\nCloned Hashtable Elements:");

            foreach (DictionaryEntry item in cloneHashtable)

            {

                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }

        }

    }

   

    class StackClass

    {

        public void StackCl() {

            // Creating a stack collection

            Stack stack = new Stack();

 

            //Adding item to the stack using the push method

            stack.Push(10);

            stack.Push("Hello");

            stack.Push(3.14f);

            stack.Push(true);

            stack.Push(67.8);

            stack.Push('A');

 

            Console.WriteLine($"Total elements present in stack : {stack.Count}");

 

            // Fetch the topmost element of stack Using Pop method

            Console.WriteLine($"Topmost element of stack is {stack.Pop()}");

 

            Console.WriteLine($"Total elements present in stack : {stack.Count}");

 

            // Fetch the topmost element from Stacj Using Peek method

            Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");

 

            Console.WriteLine($"Total elements present in stack : {stack.Count}");

            Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");

                 // Checking if the element Hello is present in the Stack or not

            if (stack.Contains("Hello"))

            {

                Console.WriteLine("Element Hello is found");

            }

            else

            {

                Console.WriteLine("Element Hello is not found");

            }

            //Creating a clone queue using Clone method

            Stack cloneStack = (Stack)stack.Clone();

            Console.WriteLine("\nCloned Stack Elements:");

            foreach (var item in cloneStack)

            {

                Console.WriteLine(item);

            }

            //Copying the queue to an object array

            object[] stackCopy = new object[5];

            stack.CopyTo(stackCopy, 0);

            Console.WriteLine("\nStack Copy Array Elements:");

            foreach (var item in stackCopy)

            {

                Console.WriteLine(item);

            }

 

        }

    }

    class QueueClass

    {

        public void QueueCl()

        {

            // Creating a Queue collection

           Queue queue = new Queue();

 

            //Adding item to the queue using the Enqueue method

            queue.Enqueue(101);

            queue.Enqueue("Hello");

            queue.Enqueue(3.14f);

            queue.Enqueue(true);

            queue.Enqueue(67.8);

            queue.Enqueue('A');

 

            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");

 

            // Fetch First Element of Queue Using Dequeue method

            Console.WriteLine($"First Element of Queue is {queue.Dequeue()}");

            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");

 

            // Fetch the topmost element from Queue Using Peek method

            Console.WriteLine($"First Element of Queue is {queue.Peek()}");

            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");

            //Creating a clone queue using Clone method

            Queue cloneQueue = (Queue)queue.Clone();

            Console.WriteLine("\nCloned Queue Elements:");

            foreach (var item in cloneQueue)

            {

                Console.WriteLine(item);

            }

        }

    }

    class SortLi

    {

        public void so()

        {

            //Creating sortedList Collection

            SortedList sortedList = new SortedList();

 

            //Adding Elements to SortedList using Add Method

            //Key type going to be same

            sortedList.Add(1, "One");

            sortedList.Add(5, "Five");

            sortedList.Add(4, "Four");

            sortedList.Add(2, "Two");

            sortedList.Add(3, "Three");

 

 

            //Accessing SortedList using For loop

            Console.WriteLine("Accessing SortedList using For loop");

            for (int x = 0; x < sortedList.Count; x++)

            {

                Console.WriteLine($"Key: {sortedList.GetKey(x)}, Value: {sortedList.GetByIndex(x)}");

            }

 

            Console.WriteLine("\nAccessing SortedList using For Each loop");

            //Accessing SortedList using For Each loop

            foreach (DictionaryEntry item in sortedList)

            {

                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }

 

            Console.WriteLine("\nAccessing SortedList using Keys");

            Console.WriteLine($"Key: 1, Value: {sortedList[1]}");

            Console.WriteLine($"Key: 2, Value: {sortedList[2]}");

            Console.WriteLine($"Key: 3, Value: {sortedList[3]}");

 

            Console.WriteLine("\nAccessing SortedList using Index");

            Console.WriteLine($"Key: 1, Index: 0, Value: {sortedList.GetByIndex(0)}");

            Console.WriteLine($"Key: 2, Index: 1, Value: {sortedList.GetByIndex(1)}");

            Console.WriteLine($"Key: 3, Index: 2, Value: {sortedList.GetByIndex(2)}");

            // Creating sortedList using Object Initializer

            SortedList sortedList1 = new SortedList

            {

                { "Ind", "India" },

                { "USA", "United State of America" },

                { "SA", "South Africa" },

                { "PAK", "Pakistan" }

            };

 

            Console.WriteLine("SortedList Elements");

            foreach (DictionaryEntry item in sortedList1)

            {

                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }

            //Creating sortedList object

          

 

            //Adding Elements to SortedList using Add

           

 

            Console.WriteLine("SortedList Elements");

            foreach (DictionaryEntry item in sortedList)

            {

                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }

            foreach (DictionaryEntry item in sortedList)

            {

                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }

 

            Console.WriteLine("\nCloned Sorted List Elements:");

            //Creating a clone sortedList using Clone method

            SortedList cloneSortedList = (SortedList)sortedList.Clone();

            foreach (DictionaryEntry item in cloneSortedList)

            {

                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }

 

          

           

 

 

        }

    }

  

    internal class Program

    {

        static void Main(string[] args)

        {

 

           ArrayClass arrc=    new ArrayClass();

             arrc.Arr();

            ArrayListClass arrli= new ArrayListClass();

            arrli.ArrayLi();

            HashTableClass hashObj=new HashTableClass();

            hashObj.Hash();

            StackClass st = new StackClass();

            st.StackCl();

           QueueClass queue = new QueueClass();

            queue.QueueCl();

           SortLi sortLi = new SortLi();

            sortLi.so();

 

        }

    }

}
