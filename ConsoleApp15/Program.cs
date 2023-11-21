using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = { 1, 2, 3, 4, 5 };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------");
            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.Write(arr[i] + "");
            //}

            Student student = new Student()
            {
                Name = "john",
                id = 1,
                GPA = 3.5
            };

            Student student1 = new Student()
            {
                Name = "jane",
                id = 2,
                GPA = 3.2
            };

            Hashtable hashtable = new Hashtable();

            hashtable.Add(student.id, student);
            hashtable.Add(student1.id, student1);

            int choice = Convert.ToInt32(Console.ReadLine());
            foreach(Student value in hashtable.Values)
            {
                if(choice == value.id)
                {
                    Console.WriteLine(value.Name);
                    Console.WriteLine(value.GPA);
                }
            }
        }
    }
}