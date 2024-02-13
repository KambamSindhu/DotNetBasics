using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace Assignment8
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                //Split the string by a space
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
    }
        internal class Program
    {
        /*=========================== ASYNCRONOUS PROGRAMMING ==============*/

        public async static void SomeMethod()
        {
           
                Console.WriteLine("Some Method Started......");
                //Thread.Sleep(TimeSpan.FromSeconds(10));
                await Task.Delay(TimeSpan.FromSeconds(10));
                Console.WriteLine("\n");
                Console.WriteLine("Some Method End");
            
            
            
        }
        static void Main(string[] args)
        {
            /*============================= EXTENSION METHOD ===================*/
            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("string : " + myWord);
            Console.WriteLine("Count : " + wordCount);


            /*=========================== ASYNCRONOUS PROGRAMMING ==============*/
            Console.WriteLine("Main Method Started......");
            SomeMethod();
            Console.WriteLine("Main Method End");


            /*=========================== FIle Stream class =================*/

            string FilePath = @"C:\Users\kambam.sindhu\Desktop\filehandling\myfile.txt";
            string data;

            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);

            using (StreamReader streamRead = new StreamReader(fileStream))
            {
                data = streamRead.ReadToEnd();
            }
            Console.WriteLine();
            Console.WriteLine(data);
            Console.WriteLine("File Stream class Implemented");


            /*==================================== Stream Writer ========================*/
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\kambam.sindhu\\Desktop\\filehandling\\myfile.txt");

            Console.WriteLine("Enter the Text that you want to write on File");
            string inputData = Console.ReadLine();

            streamWriter.Write(inputData);
            Console.WriteLine("Data Has Been Written to the File");

            streamWriter.Flush();

            streamWriter.Close();
            Console.WriteLine("Stream Writer Implemented");


            /*=============================== Stream Reader ========================*/
            string filePath = @"C:\Users\kambam.sindhu\Desktop\filehandling\myfile.txt";

           StreamReader streamReader = new StreamReader(filePath);

            Console.WriteLine("Content of the File");
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strData = streamReader.ReadLine();
            while (strData != null)
            {
                Console.WriteLine(strData);
                strData = streamReader.ReadLine();
            }
            Console.ReadLine();
            streamReader.Close();
            Console.WriteLine("Stream Reader Implemented");


            /*=========================== FILE INFO ===============================*/
            // Specifying file location  
            string loc = "C:\\Users\\kambam.sindhu\\Desktop\\filehandling\\abc.txt";
            // Creating FileInfo instance  
            FileInfo file = new FileInfo(loc);
            // Creating an empty file  
            file.Create();
            Console.WriteLine("File is created Successfuly");
            Console.WriteLine("FILE INFO");


            /*======================== Directory INFO==============================*/
            // Create Method  
            String filepath = @"C:\Users\kambam.sindhu\Desktop\filehandling\myfile.txt";
            DirectoryInfo fl = new DirectoryInfo(filePath);
             fl.Create();
             {
                 Console.WriteLine("Directory has been created");
             }
             // CreateSubdirectory Method  

             DirectoryInfo fl1 = new DirectoryInfo(filePath);
             DirectoryInfo dis = fl1.CreateSubdirectory("hellotest");
             {
                 Console.WriteLine("Directory has been created");
             }
             // MoveTo Method  

             string path1 = @"D:\NewFile1.txt";
             DirectoryInfo f1 = new DirectoryInfo(filePath);
             DirectoryInfo f2 = new DirectoryInfo(path1);
             f1.MoveTo(path1);
             {
                 Console.WriteLine("Directory has been Moved");
             }
        }
    }
}
