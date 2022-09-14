using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = null;

            //Test(student);

            string str = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("yeniden Daxil Et");
                str = Console.ReadLine();
            }

            //Console.WriteLine(string.IsNullOrEmpty(str));
            //Console.WriteLine(string.IsNullOrWhiteSpace(str));

            Console.WriteLine(str);
        }

        static void Test(Student student)
        {
            if (student != null)
            {
                Console.WriteLine(student.Age);
            }
            else
            {
                Console.WriteLine("Object Null Ola Bilmez");
            }
        }
    }
}
