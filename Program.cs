using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton fromEmployee = new Singleton();
            //fromEmployee.PrintDetails("From Employee instance");
            //Singleton fromStudent = new Singleton();
            //fromStudent.PrintDetails("From Student instance");
            //Console.ReadLine();

            string[] employeeName = new string[3];
            employeeName[0] = "Mark";
            employeeName[1] = "Matt";
            employeeName[2] = "John";

            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];
            jaggedArray[0][0] = "Bachelor in Computer Science";
            jaggedArray[0][1] = "Master in Computer Science";
            jaggedArray[0][2] = "Doctorate in Computer Science";

            jaggedArray[1][0] = "Bachelor in Computer Science";

            jaggedArray[2][0] = "Bachelor in Computer Science";
            jaggedArray[2][1] = "Master in Computer Science";
            
            for(int i=0; i<jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                Console.WriteLine(employeeName[i]);
                Console.WriteLine("---------");
                for(int j=0; j<innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
