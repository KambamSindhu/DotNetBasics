using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionAssignment6
{
    public class GenericClass<T>
    {
        public T Message;
        public void GenericMethod(T Name, T Location)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Location: {Location}");
        }
    }





    class ListType
    {
        public void List1()
        {
            //Creating a Generic List of string type to store string elements
            List<string> countries = new List<string>();

            //Adding String Elements to the Generic List using the Add Method
            countries.Add("INDIA");
            countries.Add("USA");

            //The following Two Statements will give compile time error as element is not string type
            //countries.Add(100);
            //countries.Add(true);

            //Creating Another Generic List Collection of String Type
            List<string> newCountries = new List<string>();

            //Adding Elements using Add Method
            newCountries.Add("JAPAN");
            newCountries.Add("UK");

            //Adding the newCountries collection into countries collection using AddRange Method
            countries.AddRange(newCountries);

            //Accessing Generic List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

            //Accessing Generic List Elements using For Loop
            Console.WriteLine("\nAccessing Generic List using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                var element = countries[i];
                Console.WriteLine(element);
            }

            //Accessing List Elements by using the Integral Index Position
            Console.WriteLine("\nAccessing Individual List Element by Index Position");
            Console.WriteLine($"First Element: {countries[0]}");
            Console.WriteLine($"Second Element: {countries[1]}");
            Console.WriteLine($"Third Element: {countries[2]}");
            Console.WriteLine($"Fourth Element: {countries[3]}");
            //Creating a Generic List of string type and adding elements using collection initializer
            List<string> countries1 = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK"
            };

            //Accessing List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List Elemenst using For Each Loop");
            foreach (var item in countries1)
            {
                Console.WriteLine(item);
            }
            //Insert Element at Index Position 1
            countries.Insert(1, "China");
            Console.WriteLine($"\nIndex of China Element in the List : {countries.IndexOf("China")}");
            //Accessing List After Insert Method
            Console.WriteLine("\nAccessing List After Inserting China At Index 1");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            } //Creating Another Generic List Collection of string type

            //Inserting the newCountries collection into the existing countries list at Index 2 using InsertRange Method
            countries.InsertRange(2, newCountries);

            //Accessing countries List After InsertRange Method
            Console.WriteLine("\nAccessing List After InsertRange At Index 2");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Accessing List Elements using ForEach Loop
            Console.WriteLine("All Generic List Elemenst");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

            //Checking the Item using the Contains method
            Console.WriteLine("\nIs INDIA Exists in List: " + countries.Contains("INDIA"));
            Console.WriteLine("Is NZ Exists in List: " + countries.Contains("NZ"));
            Console.WriteLine($"Before Removing Element Count : {countries.Count}");

            // Create new array with 3 elements.
            string[] array = new string[] { "INDIA", "USA", "UK" };

            // Copy the array to a List.
            List<string> copiedList = new List<string>(array);

            Console.WriteLine("Copied Elements in List");
            foreach (var item in copiedList)
            {
                Console.WriteLine(item);
            }




            //Using Remove method to Remove an Element from the List
            Console.WriteLine($"\nRemoving Element SRILANKA : {countries.Remove("SRILANKA")}");
            Console.WriteLine($"After Removing SRILANKA Element Count : {countries.Count}");

            //Removing Element using Index Position from the List
            countries.RemoveAt(2);
            Console.WriteLine($"\nAfter Removing Index 2 Element Count : {countries.Count}");

            // Using RemoveAll method to Remove Elements from the List
            // Here, we are removing element whose length is less than 3 i.e. UK and NZ
            //countries.RemoveAll(x => x.Length < 3);
            Console.WriteLine($"\nRemoveAll Method Removes: {countries.RemoveAll(x => x.Length < 3)} Element(s)");
            Console.WriteLine($"After RemoveAll Method Element Count : {countries.Count}");

            //Removing Element using RemoveRange(int index, int count) Method
            //Here, we are removing the first two elements
            countries.RemoveRange(0, 2);
            Console.WriteLine($"\nAfter RemoveRange Method Element Count : {countries.Count}");

            //Removing All Elements using Clear method
            countries.Clear();
            Console.WriteLine($"\nAfter Clear Method Element Count : {countries.Count}");
            // Create Employee Objects
            Employee emp1 = new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
            Employee emp2 = new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
            Employee emp3 = new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };

            // Create a Generic List of type Employee
            List<Employee> listEmployees = new List<Employee>();

            //Adding Employees to the listEmployees collection using Add Method
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);

            Console.WriteLine("Retrive the First Employee By Index");
            //Retrieving Items from the collection by using Index. 
            //The following line of code will retrieve the employee from the list. 
            //The List index is  0 based.
            Employee FirstEmployee = listEmployees[0]; //Fetch the First Added Employee from the Collection
            Console.WriteLine($"ID = {FirstEmployee.ID}, Name = {FirstEmployee.Name}, Gender = {FirstEmployee.Gender}, Salary = {FirstEmployee.Salary}");

            //Retrieving All Employees of Generic List Collection using For loop
            Console.WriteLine("\nRetrieving All Employees using For Loop");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

            //Retrieving All Employees of Generic List Collection using For Each loop
            Console.WriteLine("\nRetrieving All Employees using For Each Loop");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

            //Inserting an Employee into the Index Position 1.
            Employee emp4 = new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };
            listEmployees.Insert(1, emp4);

            //Retrieving the list after inserting the employee in index position 1
            Console.WriteLine("\nRetriving the List After Inserting New Employee in Index 1");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

            //If you want to get the index postion of a specific employee then use Indexof() method as follows
            Console.WriteLine("\nIndex of emp3 object in the List = " + listEmployees.IndexOf(emp3));
            //Creating a list of type Employee


            //TrueForAll
            Console.WriteLine($"Are all salaries greater than 5000: {listEmployees.TrueForAll(x => x.Salary > 5000)}");

            // ReadOnlyCollection will not have Add() or Remove() methods
            System.Collections.ObjectModel.ReadOnlyCollection<Employee> readOnlyEmployees = listEmployees.AsReadOnly();
            Console.WriteLine($"\nTotal Items in ReadOnlyCollection: {readOnlyEmployees.Count}");

            // listEmployees list is created with an initial capacity of 8
            // but only 5 items are in the list. The filled percentage is less than 90 percent threshold.
            Console.WriteLine($"\nList Capacity Before invoking TrimExcess: {listEmployees.Capacity}");

            // Invoke TrimExcess() to set the capacity to the actual number of elements in the List
            listEmployees.TrimExcess();
            Console.WriteLine($"\nList Capacity After invoking TrimExcess: {listEmployees.Capacity} ");
            List<int> numbersList = new List<int> { 1, 8, 7, 5, 2 };
            Console.WriteLine("Numbers Before Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }

            // The Sort() of List Collection class will sort the data in ascending order 
            numbersList.Sort();
            Console.WriteLine("\n\nNumbers After Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }

            // If you want to  to retrieve data in descending order then use the Reverse() method
            numbersList.Reverse();
            Console.WriteLine("\n\nNumbers in Descending order");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }

            //Another Example of Sorting String
            List<string> names = new List<string>() { "Pranaya", "Anurag", "Sambit", "Hina", "Rakesh" };
            Console.WriteLine("\n\nNames Before Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Sort();
            Console.WriteLine("\nNames After Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Reverse();
            Console.WriteLine("\nNames in Descending Order");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }





    public class ComplexSort
    {
        public void Sort()
        {
            //Creating a list of type Employee
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };
            Console.WriteLine("Employees Before Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }

            SortByName sortByName = new SortByName();
            listEmployees.Sort(sortByName);
            Console.WriteLine("\nEmployees After Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            //Sorting Employee using Linq OrderBy Method
            listEmployees = listEmployees.OrderBy(x => x.Name).ToList();
            Console.WriteLine("\nEmployees After Sorting using Linq");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

        }
    }
    public class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }

    public class ComparisonDelegate
    {
        public void comp()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };

            Console.WriteLine("Employees Before Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

            //Using Comparison Delegate with Anonymous Method
            listEmployees.Sort(delegate (Employee e1, Employee e2)
            {
                //Sorting the Employees Based on Name
                return e1.Name.CompareTo(e2.Name);
            });

            Console.WriteLine("\nEmployees After Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
          
            Console.WriteLine("Employees Before Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

            //Using Lambda Expression
            listEmployees.Sort((e1, e2) => { return e1.Name.CompareTo(e2.Name); });
            //listEmployees.Sort((e1, e2) => e1.Name.CompareTo(e2.Name));

            Console.WriteLine("\nEmployees After Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
        }
    }






    public class Dict
    {
        public void Dicti()
        {
            //Creating a Dictionary with Key and value both are string type
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();

            //Adding Elements to the Dictionary using Add Method of Dictionary class
            dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");

            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }

            //Accessing Dictionary Elements using For Loop
            Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
            for (int i = 0; i < dictionaryCountries.Count; i++)
            {
                string key = dictionaryCountries.Keys.ElementAt(i);
                string value = dictionaryCountries[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            //Accessing Dictionary Elements using Keys
            Console.WriteLine("\nAccessing Dictionary Elements using Keys");
            Console.WriteLine($"Key: UK, Value: {dictionaryCountries["UK"]}");
            Console.WriteLine($"Key: USA, Value: {dictionaryCountries["USA"]}");
            Console.WriteLine($"Key: IND, Value: {dictionaryCountries["IND"]}");
            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries1 = new Dictionary<string, string>
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "IND", "Mumbai, Delhi, Bhubaneswar" }
            };

            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries1)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }
            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("All Dictionary Elements");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }

            //Checking the key using the ContainsKey methid
            Console.WriteLine("\nIs USA Key Exists : " + dictionaryCountries.ContainsKey("USA"));
            Console.WriteLine("Is PAK Key Exists : " + dictionaryCountries.ContainsKey("PAK"));

            //Checking the value using the ContainsValue method
            Console.WriteLine("\nIs India value Exists : " + dictionaryCountries.ContainsValue("India"));
            Console.WriteLine("Is Srilanka value Exists : " + dictionaryCountries.ContainsValue("Srilanka"));
            Console.WriteLine($"Dictionary Elements Count Before Removing: {dictionaryCountries.Count}");
            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }
            Console.WriteLine($"Iterating Dictionary Using AsParallel().ForAll Method");
            dictionaryCountries.AsParallel()
            .ForAll(entry => Console.WriteLine(entry.Key + " : " + entry.Value));
            dictionaryCountries["IND"] = "India";
            dictionaryCountries["PAK"] = "Pakistan";
            dictionaryCountries["SL"] = "Srilanka";

            //Updating the key UK and USA using Indexer
            dictionaryCountries["UK"] = "United Kingdom Updated";
            dictionaryCountries["IND"] = "India Updated";
            Console.WriteLine("\nAfter Updating the Key UK and IND");
            Console.WriteLine($"USA: {dictionaryCountries["UK"]}");
            Console.WriteLine($"IND: {dictionaryCountries["IND"]}");
            //Accessing the Dictionary using For Each Loop
            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }


            // Remove element PAK from Dictionary Using Remove() method
            if (dictionaryCountries.ContainsKey("PAK"))
            {
                dictionaryCountries.Remove("PAK");
                Console.WriteLine($"\nDictionary Elements Count After Removing PAK: {dictionaryCountries.Count}");
                foreach (var item in dictionaryCountries)
                {
                    Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
                }
            }

            // Remove all Elements from Dictionary Using Clear method
            dictionaryCountries.Clear();
            Console.WriteLine($"\nDictionary Elements Count After Clear: {dictionaryCountries.Count}");
            Dictionary<int, Student> Students = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},

                //The following Statement will give runtime error
                //System.ArgumentException: 'An item with the same key has already been added. Key: 101'
                //{ 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"}}
            };

            foreach (KeyValuePair<int, Student> item in Students)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
          

            Student std102;
            if (Students.TryGetValue(102, out std102))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 102 is not found in the dictionary");
            }

            Student std105;
            if (Students.TryGetValue(105, out std105))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std105.ID}, Name: {std105.Name}, Branch: {std105.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 105 is not found in the dictionary");
            }
            Student[] arrayStudents = new Student[3];
            arrayStudents[0] = new Student() { ID = 101, Name = "Anurag", Branch = "CSE" };
            arrayStudents[1] = new Student() { ID = 102, Name = "Mohanty", Branch = "CSE" };
            arrayStudents[2] = new Student() { ID = 103, Name = "Sambit", Branch = "ETC" };

            Dictionary<int, Student> dictionaryStudent = arrayStudents.ToDictionary(std => std.ID, std => std);

            foreach (KeyValuePair<int, Student> item in dictionaryStudent)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
            // To get all the keys in the dictionary use the keys properties of dictionary
            Console.WriteLine("All Keys in Student Dictionary");
            foreach (int key in Students.Keys)
            {
                Console.WriteLine(key + " ");
            }

            // Once you get the keys, then get the values using the keys
            Console.WriteLine("\nAll Keys and values in Student Dictionary");
            foreach (int key in Students.Keys)
            {
                var student = Students[key];
                Console.WriteLine($"Key: {key}, ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
            }

            //To get all the values in the dictionary use Values property
            Console.WriteLine("\nAll Student objects in Student Dictionary");
            foreach (Student student in Students.Values)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }







    public class Convert
    {
        public void convert()
        {
            //Create Employee object
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };

            // Create an array of employees with size 3
            // and then Store the 3 employees into the array
            Employee[] arrayEmployees = new Employee[3];
            arrayEmployees[0] = emp1;
            arrayEmployees[1] = emp2;
            arrayEmployees[2] = emp3;

            // To convert an array to a List, use ToList() method
            List<Employee> listEmployees = arrayEmployees.ToList();
            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();

            // To convert a List to an array, use ToArray() method
            Employee[] arrayAllEmployeesFromList = listEmployees.ToArray();
            foreach (Employee emp in arrayAllEmployeesFromList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();

            // To convert a List to a Dictionary, use ToDictionary() method
            Dictionary<int, Employee> dictionaryEmployees = listEmployees.ToDictionary(employee => employee.ID, employee => employee);
            foreach (KeyValuePair<int, Employee> keyValuePairEmployees in dictionaryEmployees)
            {
                Console.WriteLine("Key = {0}", keyValuePairEmployees.Key);
                Employee emp = keyValuePairEmployees.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();


            // To convert an Array to a Dictionary, use ToDictionary() method
            Dictionary<int, Employee> dictionaryEmployeesFromArray = arrayEmployees.ToDictionary(employee => employee.ID, employee => employee);
            // Loop thru the dictionary and print the key/value pairs
            foreach (KeyValuePair<int, Employee> kvp in dictionaryEmployeesFromArray)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }

            // To Convert a dictionaty to an array, use ToArray method on the Values 
            // Peoperty of the dictionary object
            Employee[] arrayAllEmployeesFromDictionary = dictionaryEmployeesFromArray.Values.ToArray();
            foreach (Employee emp in arrayAllEmployeesFromDictionary)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();

            // To Convert a dictionary to a List, use To List method on the Values
            // Property of the dictionary object
            List<Employee> listAllEmployeesFromDictionary = dictionaryEmployeesFromArray.Values.ToList();
            foreach (Employee emp in listAllEmployeesFromDictionary)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
        }
    }





    class Stack
    {
        public void stack()
        { 
            Stack<int> genericStack = new Stack<int>();
            //Pushing Elements to the Stack using Push Method
            genericStack.Push(10);
            genericStack.Push(20);
            genericStack.Push(30);
            genericStack.Push(50);
            genericStack.Push(25);

            Console.WriteLine("Generic Stack Elements");
            foreach (var item in genericStack)
            {
                Console.WriteLine(item);
            }
 Console.WriteLine($"\nDeleted Element: {genericStack.Pop()}");
 Console.WriteLine($"\nPeek Element: {genericStack.Peek()}");
Console.WriteLine($"\nIs Value 50 Present in the Generic Stack: {genericStack.Contains(50)}");
            Console.WriteLine($"\nIs Value 90 Present in the Generic Stack: {genericStack.Contains(90)}");

            //Copying the stack to an object array
            int[] stackCopy = new int[5];
            genericStack.CopyTo(stackCopy, 0);
            Console.WriteLine("\nStack Copy Array Elements:");
            foreach (var item in stackCopy)
            {
                Console.WriteLine(item);
            }
            //Printing Elements After Removing the Last Added Element
            Console.WriteLine($"\nAll Stack Elements After Deletion: Count {genericStack.Count}");
            foreach (var element in genericStack)
            {
                Console.WriteLine($"{element} ");
            }
            //Removing All Elements from Generic Stack using Clear Method
            genericStack.Clear();
            Console.WriteLine($"\nAll Stack Elements Counts After Clear: Count {genericStack.Count}");
            //Create Employee object
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Female",
                Salary = 40000
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Preety",
                Gender = "Female",
                Salary = 50000
            };
            // Create a Generic Stack of Employees
            Stack<Employee> stackEmployees = new Stack<Employee>();

            // To add an item into the stack, use the Push() method.
            // emp1 is inserted at the top of the stack
            stackEmployees.Push(emp1);

            // emp2 will be inserted on top of emp1 and now is on top of the stack
            stackEmployees.Push(emp2);

            // emp3 will be inserted on top of emp2 and now is on top of the stack
            stackEmployees.Push(emp3);

            // emp4 will be inserted on top of emp3 and now is on top of the stack
            stackEmployees.Push(emp4);

            // emp5 will be inserted on top of emp4 and now is on top of the stack
            stackEmployees.Push(emp5);

            // If you need to loop thru each items in the stack, then we can use the foreach loop 
            // in the same way as we use it with other collection classes. 
            // The foreach loop will only iterate thru the items in the stack, but will not remove them. 
            // Notice that the items from the stack are retrieved in LIFO (Last In First Out), order. 
            // The last element added to the Stack is the first one to be removed.
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (Employee emp in stackEmployees)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
                Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            }
            Console.WriteLine("------------------------------");

            // To retrieve an item from the stack, use the Pop() method. 
            // This method removes and returns an object at the top of the stack. 
            // Since emp5 object is the one that is pushed onto the stack last, this object will be
            // first to be removed and returned from the stack by the Pop() method

            Console.WriteLine("Retrive Using Pop Method");
            Employee e1 = stackEmployees.Pop();
            Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Gender + " - " + e1.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Employee e2 = stackEmployees.Pop();
            Console.WriteLine(e2.ID + " - " + e2.Name + " - " + e2.Gender + " - " + e2.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Employee e3 = stackEmployees.Pop();
            Console.WriteLine(e3.ID + " - " + e3.Name + " - " + e3.Gender + " - " + e3.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Employee e4 = stackEmployees.Pop();
            Console.WriteLine(e4.ID + " - " + e4.Name + " - " + e4.Gender + " - " + e4.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Employee e5 = stackEmployees.Pop();
            Console.WriteLine(e5.ID + " - " + e5.Name + " - " + e5.Gender + " - " + e5.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            Console.WriteLine("------------------------------");

            // Now there will be no items left in the stack. 
            // So, let's push the five objects once again
            stackEmployees.Push(emp1);
            stackEmployees.Push(emp2);
            stackEmployees.Push(emp3);
            stackEmployees.Push(emp4);
            stackEmployees.Push(emp5);

            // To retrieve an item that is present at the top of the stack, 
            // without removing it, then use the Peek() method.

            Console.WriteLine("Retrive Using Peek Method");
            Employee e105 = stackEmployees.Peek();
            Console.WriteLine(e105.ID + " - " + e105.Name + " - " + e105.Gender + " - " + e105.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Employee e104 = stackEmployees.Peek();
            Console.WriteLine(e104.ID + " - " + e104.Name + " - " + e104.Gender + " - " + e104.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Console.WriteLine("------------------------------");

            // To check if an item exists in the stack, use Contains() method.
            if (stackEmployees.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }
        }

    }






    class Queue
    {
        public void Que()
        {
            //Creating a Queue to Store Integer Values
            Queue<int> queue = new Queue<int>();

            //Adding Elements to the Queue using Enqueue Method
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            //Accesing all the Elements of the Queue using For Each Loop
            Console.WriteLine($"Generic Queue Elements Count: {queue.Count}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

           
            Console.WriteLine($"\nAll Queue Elements Counts After Clear: Count {queue.Count}");
            //Accesing all the Elements of the Queue using For Each Loop
            Console.WriteLine($"All Generic Queue Elements Count: {queue.Count}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Removing and Returning the First Element from queue using Dequeue method
            Console.WriteLine($"\nDequeue Element: {queue.Dequeue()}");

            //Printing Elements After Removing the First Added Element
            Console.WriteLine($"All Queue Elements After Dequeue: Count {queue.Count}");
            foreach (var element in queue)
            {
                Console.WriteLine($"{element} ");
            }

            // Returning an Element from the Queue using Peek method
            Console.WriteLine($"\nPeek Element: {queue.Peek()}");
            //Printing Elements After Peek the Last Added Element
            Console.WriteLine($"All Queue Elements After Peek: Count {queue.Count}");
            foreach (var element in queue)
            {
                Console.WriteLine($"{element} ");
            }
            Console.WriteLine($"\nIs Value 40 Present in the Queue: {queue.Contains(50)}");
            Console.WriteLine($"\nIs Value 90 Present in the Queue: {queue.Contains(90)}");
            //Copying the queue to an object array
            int[] queueCopy = new int[5];
            queue.CopyTo(queueCopy, 0);
            Console.WriteLine("\nQueue Copy Array Elements:");
            foreach (var item in queueCopy)
            {
                Console.WriteLine(item);
            }
            // Removing and Returning an Element from the Begining of the Stack using Dequeue method
            Console.WriteLine($"\nDeleted Element: {queue.Dequeue()}");

            //Printing Elements After Removing the First Added Element
            Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");
            foreach (var element in queue)
            {
                Console.WriteLine($"{element} ");
            }

            //Removing All Elements from Queue using Clear Method
            queue.Clear();
            //Create Employee object
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Female",
                Salary = 40000
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Preety",
                Gender = "Female",
                Salary = 50000
            };
            Console.WriteLine("COmplex Type QUEUE");
            // Create a Generic Queue of Employees
            Queue<Employee> queueEmployees = new Queue<Employee>();

            // To add an item into the queue, use the Enqueue() method.
            // emp1 is added first, so this employee, will be the first to get out of the queue
            queueEmployees.Enqueue(emp1);

            // emp2 will be queued up next, so employee 2 will be second to get out of the queue
            queueEmployees.Enqueue(emp2);

            // emp3 will be queued up next, so employee 3 will be third to get out of the queue
            queueEmployees.Enqueue(emp3);

            // emp3 will be queued up next, so employee 4 will be fourth to get out of the queue
            queueEmployees.Enqueue(emp4);

            // emp5 will be queued up next, so employee 5 will be fifth to get out of the queue
            queueEmployees.Enqueue(emp5);

            // If you need to loop thru each items in the queue, then we can use the foreach loop 
            // in the same way as we use it with other collection classes. 
            // The foreach loop will only iterate thru the items in the queue, but will not remove them. 
            // Notice that the items from the queue are retrieved in FIFI (First In First Out), order. 
            // The First element added to the queue is the first one to be removed.
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (Employee emp in queueEmployees)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
                Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            }
            Console.WriteLine("------------------------------");

            // To retrieve an item from the queue, use the Dequeue() method. 
            // Notice that the items are dequeued in the same order in which they were enqueued.
            // Dequeue() method removes and returns the item at the beginning of the Queue.
            // Since emp1 object is the one that is enqueued onto the queue first, this object will be
            // first to be dequeued and returned from the queue by using Dequeue() method

            Console.WriteLine("Retrive Using Dequeue Method");
            Employee e1 = queueEmployees.Dequeue();
            Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Gender + " - " + e1.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

            Employee e2 = queueEmployees.Dequeue();
            Console.WriteLine(e2.ID + " - " + e2.Name + " - " + e2.Gender + " - " + e2.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

            Employee e3 = queueEmployees.Dequeue();
            Console.WriteLine(e3.ID + " - " + e3.Name + " - " + e3.Gender + " - " + e3.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

            Employee e4 = queueEmployees.Dequeue();
            Console.WriteLine(e4.ID + " - " + e4.Name + " - " + e4.Gender + " - " + e4.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

            Employee e5 = queueEmployees.Dequeue();
            Console.WriteLine(e5.ID + " - " + e5.Name + " - " + e5.Gender + " - " + e5.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Console.WriteLine("------------------------------");

            // Now there will be no items left in the queue. 
            // So, let's Enqueue the five objects once again
            queueEmployees.Enqueue(emp1);
            queueEmployees.Enqueue(emp2);
            queueEmployees.Enqueue(emp3);
            queueEmployees.Enqueue(emp4);
            queueEmployees.Enqueue(emp5);

            // To retrieve an item that is present at the beginning of the queue,
            // without removing it, then use the Peek() method.

            Console.WriteLine("Retrive Using Peek Method");
            Employee e101 = queueEmployees.Peek();
            Console.WriteLine(e101.ID + " - " + e101.Name + " - " + e101.Gender + " - " + e101.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

            Employee e103 = queueEmployees.Peek();
            Console.WriteLine(e103.ID + " - " + e103.Name + " - " + e103.Gender + " - " + e103.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

            Console.WriteLine("------------------------------");

            // To check if an item exists in the stack, use Contains() method.
            if (queueEmployees.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in Queue");
            }
            else
            {
                Console.WriteLine("Emp3 is not in queue");
            }


        }
    }







    class Hashset
    {
        public void hashset()
        {
            //Creating HashSet
            HashSet<string> hashSetCountries = new HashSet<string>
            {
                //Adding Elements to HashSet using Add Method
                "INDIA",
                "USA",
                "UK",

                //Adding Duplicate Elements will not give compile time error
                //But duplicate elements are simply ignored and will not be added into the collection
                "UK",
                "INDIA"
            };

            Console.WriteLine($"Elements Count: {hashSetCountries.Count}");

            //Accessing HashSet collection using For Each Loop
            //Here, you can observe UK and INDIA are printed once
            Console.WriteLine($"Accessing HashSet Elements:");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Is INDIA Key Exists : " + hashSetCountries.Contains("INDIA"));
            Console.WriteLine("Is NZ Key Exists : " + hashSetCountries.Contains("NZ"));

            //Removing element Bangladesh from HashSet Using Remove() method
            hashSetCountries.Remove("Bangladesh");
            Console.WriteLine($"\nHashSet Elements Count After Removing Bangladesh: {hashSetCountries.Count}");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }

            //Remove Element from HashSet Using RemoveWhere() method where element length is > 3
            int NumberOfElementRemoved = hashSetCountries.RemoveWhere(x => x.Length > 3);
            Console.WriteLine($"\nHashSet Elements Count After Removeing {NumberOfElementRemoved} Elements : {hashSetCountries.Count}");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }

            //Remove All Elements Using Clear method
            hashSetCountries.Clear();
            Console.WriteLine($"\nHashSet Elements Count After Clear: {hashSetCountries.Count}");
            //Creating HashSet Collection1
            HashSet<string> hashSetCountries1 = new HashSet<string>();

            //Adding Elements to HashSet using Add Method
            hashSetCountries1.Add("IND");
            hashSetCountries1.Add("USA");
            hashSetCountries1.Add("UK");
            hashSetCountries1.Add("NZ");
            hashSetCountries1.Add("BAN");

            Console.WriteLine("HashSet 1 Elements");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }

            //Creating HashSet Collection2
            HashSet<string> hashSetCountries2 = new HashSet<string>();

            //Adding Elements to HashSet using Add Method
            hashSetCountries2.Add("IND");
            hashSetCountries2.Add("SA");
            hashSetCountries2.Add("SL");
            hashSetCountries2.Add("USA");
            hashSetCountries2.Add("ZIM");

            Console.WriteLine("\nHashSet 2 Elements");
            foreach (var item in hashSetCountries2)
            {
                Console.WriteLine(item);
            }

            // Using UnionWith method
            hashSetCountries1.UnionWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After UnionWith");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            //Using IntersectWith method
            hashSetCountries1.IntersectWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After IntersectWith");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            //Using ExceptWith method
            hashSetCountries1.ExceptWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After ExceptWith ");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            //Using SymmetricExceptWith  method
            hashSetCountries1.SymmetricExceptWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After SymmetricExceptWith  ");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            HashSet<Student> hashSetStudents = new HashSet<Student>()
            {
                new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
                //Adding Duplicate Element
                new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
                new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"},
                new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}
            };
            Console.WriteLine("HashSet Students List");
            foreach (var item in hashSetStudents)
            {
                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Branch: {item.Branch}");
            }
            HashSet<string>.Enumerator em = hashSetCountries1.GetEnumerator();
            while (em.MoveNext())
            {
                string val = em.Current;
                Console.WriteLine(val);
            }

        }
    }

    class GenericSortedList
    {
        public void GenericSorted()
        {
            //Creating Generic SortedList Collection
            SortedList<int, string> genericSortedListt = new SortedList<int, string>();

            //Adding Elements to SortedList Collection using Add Method in Random Order
            genericSortedListt.Add(1, "One");
            genericSortedListt.Add(5, "Five");
            genericSortedListt.Add(4, "Four");
            genericSortedListt.Add(2, "Two");
            genericSortedListt.Add(3, "Three");

            //You cannot pass null as a key
            //genericSortedList.Add(null, "Ten"); //Compile-Time Error

            //Duplicate Key not allowed
            //System.ArgumentException: 'An entry with the same key already exists.'
            //genericSortedList.Add(2, "Any Value");

            //Accessing Generic SortedList Collection using For loop
            Console.WriteLine("Accessing Generic SortedList using For loop");
            for (int i = 0; i < genericSortedListt.Count; i++)
            {
                Console.WriteLine("Keys : " + genericSortedListt.Keys[i] + "\tValues : " + genericSortedListt.Values[i]);
            }

            //Accessing Generic SortedList Collection using For Each loop
            Console.WriteLine("\nAccessing SortedList using For Each loop");
            foreach (KeyValuePair<int, string> item in genericSortedListt)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            //Accessing Generic SortedList Individual Elements using Keys
            Console.WriteLine("\nAccessing SortedList Individual Elements using Keys");
            Console.WriteLine($"Key: 1, Value: {genericSortedListt[1]}");
            Console.WriteLine($"Key: 2, Value: {genericSortedListt[2]}");
            Console.WriteLine($"Key: 3, Value: {genericSortedListt[3]}");
            //Creating Generic SortedList Collection using Collection Initializer
            SortedList<int, string> genericSortedList1 = new SortedList<int, string>
            {
                { 1, "One" },
                { 5, "Five" },
                { 4, "Four" },
                { 2, "Two" },
                { 3, "Three" }
            };

            //Accessing Generic SortedList Collection using For Each loop
            Console.WriteLine("Accessing SortedList using For Each loop");
            foreach (KeyValuePair<int, string> item in genericSortedList1)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            //Creating a Generic SortedList Collection Object
            //Here both the keys and values are of string type
            SortedList<string, string> genericSortedList = new SortedList<string, string>();

            //Adding Elements to Generic SortedList Collection using Add Method
            genericSortedList.Add("Ind", "India");
            genericSortedList.Add("USA", "United State of America");
            genericSortedList.Add("SA", "South Africa");
            genericSortedList.Add("PAK", "Pakistan");

            //Accessing Generic SortedList Collection using For Each loop
            Console.WriteLine($"SortedList Elements Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
            foreach (KeyValuePair<string, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //Accessing Generic SortedList Collection using For Each loop
            Console.WriteLine("Generic SortedList Elements");
            foreach (KeyValuePair<string, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            //Checking the key using the ContainsKey methid
            Console.WriteLine("\nIs Ind Key Exists : " + genericSortedList.ContainsKey("Ind"));
            Console.WriteLine("Is NZ Key Exists : " + genericSortedList.ContainsKey("NZ"));
            //Checking the value using the ContainsValue method
            Console.WriteLine("\nIs India value Exists : " + genericSortedList.ContainsValue("India"));
            Console.WriteLine("Is Bangladesh value Exists : " + genericSortedList.ContainsValue("Bangladesh"));


            // Remove value having key PAK Using Remove() method
            genericSortedList.Remove("PAK");
            Console.WriteLine($"\nSortedList Elements After Remove Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
            foreach (KeyValuePair<string, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.WriteLine($"Comparer Property : {genericSortedList.Comparer}");
            Console.WriteLine($"Capacity Property : {genericSortedList.Capacity}");

            Console.WriteLine("\nKeys Property");
            foreach (var item in genericSortedList.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nValues Property");
            foreach (var item in genericSortedList.Values)
            {
                Console.WriteLine(item);
            }
            // Remove element at index 1 Using RemoveAt() method
            genericSortedList.RemoveAt(1);
            Console.WriteLine($"\nSortedList Elements After RemoveAT Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
            foreach (KeyValuePair<string, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // Remove all key/value pairs Using Clear method
            genericSortedList.Clear();
            Console.WriteLine($"After Clear Method Count={genericSortedList.Count}, Capacity:{genericSortedList.Capacity}");
            //Here we are creating a sortedlist whose key is int and value is Student
            SortedList<int, Student> genericSortedList2 = new SortedList<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"}},
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}}
            };

            //The following Statement will give you Runtime Exception as the key is already exists
            //genericSortedList.Add(101, new Student() { ID = 101, Name = "Anurag", Branch = "CSE" });

            //Accessing Generic SortedList Collection using For Each loop
            Console.WriteLine("Generic SortedList Elements");
            foreach (KeyValuePair<int, Student> item in genericSortedList2)
            {
                Console.WriteLine($"Key: {item.Key}: ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
          
        }
    }

    class GenericSortedSet
    {
        public void GenSortedSet()
        {

            //Creating an Instance of SortedSet class to store Integer values
            SortedSet<int> sortedSetNumbers = new SortedSet<int>();

            //Adding Elements to SortedSet using Add Method
            sortedSetNumbers.Add(10);
            sortedSetNumbers.Add(5);
            sortedSetNumbers.Add(50);
            sortedSetNumbers.Add(37);
            sortedSetNumbers.Add(18);
            sortedSetNumbers.Add(37);

            //Accessing the SortedSet Elements using For Each Loop
            Console.WriteLine("SortedSet Elements");
            foreach (var item in sortedSetNumbers)
            {
                Console.WriteLine(item);
            }
            //Creating an Instance of SortedSet and Adding Elements using Collection Initializer
            SortedSet<int> sortedSetNumber = new SortedSet<int>
            {
                10,
                5,
                50,
                37,
                18,
                37
            };

            //Accessing the SortedSet Elements using Enumerator
            Console.WriteLine("SortedSet Elements");
            SortedSet<int>.Enumerator em = sortedSetNumber.GetEnumerator();
            while (em.MoveNext())
            {
                int val = em.Current;
                Console.WriteLine(val);
            }
            //Creating SortedSet and Adding Elements to SortedSet using Collection Initializer 
            SortedSet<string> sortedSetCountries = new SortedSet<string>()
            {
                "BANGLADESH",
                "NEPAL"
            };

            //Adding Elements to SortedSet using Add Method
            sortedSetCountries.Add("INDIA");
            sortedSetCountries.Add("USA");
            sortedSetCountries.Add("UK");

            Console.WriteLine($"SortedSet Elements Count Before Removing: {sortedSetCountries.Count}");
            foreach (var item in sortedSetCountries)
            {
                Console.WriteLine(item);
            }

            // Remove element Bangladesh from SortedSet Using Remove() method
            sortedSetCountries.Remove("Bangladesh");
            Console.WriteLine($"\nSortedSet Elements Count After Removing Bangladesh: {sortedSetCountries.Count}");
            foreach (var item in sortedSetCountries)
            {
                Console.WriteLine(item);
            }

            // Remove Element from SortedSet Using RemoveWhere() method where element length is > 3
            sortedSetCountries.RemoveWhere(x => x.Length > 3);
            Console.WriteLine($"\nSortedSet Elements Count After Removeing Elements whose Length > 3: {sortedSetCountries.Count}");
            foreach (var item in sortedSetCountries)
            {
                Console.WriteLine(item);
            }

            // Remove all Elements from SortedSet Using Clear method
            sortedSetCountries.Clear();
            Console.WriteLine($"\nSortedSet Elements Count After Clear: {sortedSetCountries.Count}");
            //Adding Elements to SortedSet using Add Method
            sortedSetCountries.Add("INDIA");
            sortedSetCountries.Add("USA");
            sortedSetCountries.Add("UK");
            //Checking the key using the Contains methid
            Console.WriteLine("Is INDIA Key Exists : " + sortedSetCountries.Contains("INDIA"));
            Console.WriteLine("Is NZ Key Exists : " + sortedSetCountries.Contains("NZ"));
            //Creating SortedSet 1
            SortedSet<string> sortedSetCountries1 = new SortedSet<string>();
            //Adding Elements to sortedSetCountries1 using Add Method
            sortedSetCountries1.Add("IND");
            sortedSetCountries1.Add("USA");
            sortedSetCountries1.Add("UK");
            sortedSetCountries1.Add("NZ");
            sortedSetCountries1.Add("BAN");

            Console.WriteLine("SortedSet 1 Elements");
            foreach (var item in sortedSetCountries1)
            {
                Console.WriteLine(item);
            }

            //Creating SortedSet 2
            SortedSet<string> sortedSetCountries2 = new SortedSet<string>();
            //Adding Elements to HashSet using Add Method
            sortedSetCountries2.Add("IND");
            sortedSetCountries2.Add("SA");
            sortedSetCountries2.Add("PAK");
            sortedSetCountries2.Add("USA");
            sortedSetCountries2.Add("ZIM");

            Console.WriteLine("\nSortedSet 2 Elements");
            foreach (var item in sortedSetCountries2)
            {
                Console.WriteLine(item);
            }

            // Using UnionWith method
            sortedSetCountries1.UnionWith(sortedSetCountries2);
            Console.WriteLine("\nSortedSet 1 Elements After UnionWith");
            foreach (var item in sortedSetCountries1)
            {
                Console.WriteLine(item);
            }
            // Using IntersectWith method
            sortedSetCountries1.IntersectWith(sortedSetCountries2);
            Console.WriteLine("\nSortedSet 1 Elements After IntersectWith");
            foreach (var item in sortedSetCountries1)
            {
                Console.WriteLine(item);
            }
            // Using ExceptWith method
            sortedSetCountries1.ExceptWith(sortedSetCountries2);
            Console.WriteLine("\nSortedSet 1 Elements After ExceptWith ");
            foreach (var item in sortedSetCountries1)
            {
                Console.WriteLine(item);
            }
            //Adding Elements to HashSet using Add Method
            sortedSetCountries2.Add("IND");
            sortedSetCountries2.Add("SA");
            sortedSetCountries2.Add("PAK");
            sortedSetCountries2.Add("USA");
            sortedSetCountries2.Add("ZIM");
            Console.WriteLine("\nSortedSet 2 Elements");
            foreach (var item in sortedSetCountries2)
            {
                Console.WriteLine(item);
            }
            // Using ExceptWith method
            sortedSetCountries1.SymmetricExceptWith(sortedSetCountries2);
            Console.WriteLine("\nSortedSet 1 Elements After SymmetricExceptWith");
            foreach (var item in sortedSetCountries1)
            {
                Console.WriteLine(item);
            }
            List<string> listCountries = new List<string>()
            {
                "INDIA",
                "USA",
                "UK"
            };
            SortedSet<string> sortedSetCountrs = new SortedSet<string>(listCountries);
            foreach (var item in sortedSetCountrs)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"Min Property : {sortedSetNumbers.Min}");
            Console.WriteLine($"Max Property : {sortedSetNumbers.Max}");
            Console.WriteLine($"Count Property : {sortedSetNumbers.Count}");
            Console.WriteLine($"Comparer Property : {sortedSetNumbers.Comparer}");

        }
    }
    class Linkedlist
    {
        public void LinkedLi() {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("India");
            linkedList.AddLast("USA");
            linkedList.AddLast("Srilanka");
            linkedList.AddLast("UK");
            linkedList.AddLast("Japan");
            Console.WriteLine("LinkedList Elements");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            linkedList.AddLast("India");
            LinkedListNode<string> USANode = linkedList.AddLast("USA");
            linkedList.AddLast("Srilanka");
            LinkedListNode<string> UKNode = linkedList.AddLast("UK");
            linkedList.AddLast("Japan");

            Console.WriteLine("Initial LinkedList Elements");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            //Checking the value using the ContainsValue method
            Console.WriteLine("\nIs India value Exists : " + linkedList.Contains("India"));
            Console.WriteLine("\nIs Bangladesh value Exists : " + linkedList.Contains("Bangladesh"));
            Console.WriteLine("\nAfter Adding a Node at First Position");
            linkedList.AddFirst("UK");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAfter Adding a Node at Last Position");
            linkedList.AddLast("UK");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAfter Adding a Node After USA Node");
            linkedList.AddAfter(USANode, "UK");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAfter Adding a Node Before USA Node");
            linkedList.AddBefore(USANode, "UK");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Removing Element using Remove(LinkedListNode) method
            // linkedList.Remove(linkedList.First); //Remove First Node
            // linkedList.Remove(linkedList.Last);  //Remove Second Node
            linkedList.Remove(USANode); //Remove Specific Node
            Console.WriteLine("\nLinkedList Elements After Remove(USANode)");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Removing Element using Remove(T) method
            linkedList.Remove("UK");
            Console.WriteLine("\nLinkedList Elements After Remove(UK)");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Removing Element using RemoveFirst() method
            linkedList.RemoveFirst();
            Console.WriteLine("\nLinkedList Elements After RemoveFirst()");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Removing Element using RemoveLast() method
            linkedList.RemoveLast();
            Console.WriteLine("\nLinkedList Elements After RemoveLast()");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Removing Element using Clear() method
            linkedList.Clear();
            Console.WriteLine($"\nLinkedList Count After Clear(): {linkedList.Count}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Class Example in C#");
             //Instantiate GenericClass, string is the type argument
             GenericClass<string> myGenericClass = new GenericClass<string>
             {
                 Message = "Welcome to DotNetTutorials"
             };
             myGenericClass.GenericMethod("Pranata Rout", "Bhubaneswar");
             
             ComplexSort sort=new ComplexSort();
            sort.Sort();
            ComparisonDelegate comparisonDelegate = new ComparisonDelegate();

            comparisonDelegate.comp();
            ListType li = new ListType();
            li.List1();
            Dict dict = new Dict();
            dict.Dicti();
            Stack stack = new Stack();
            stack.stack();
            Queue queue = new Queue();
            queue.Que();
            Hashset hashset = new Hashset();
            hashset.hashset();
            GenericSortedList genericSortedList = new GenericSortedList();
            genericSortedList.GenericSorted();
            GenericSortedSet genericSortedSet = new GenericSortedSet();
            genericSortedSet.GenSortedSet();
            Linkedlist linkedList = new Linkedlist();
            linkedList.LinkedLi();
        }
    }
}
