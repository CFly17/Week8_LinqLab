using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;

namespace Week8_LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            //Nums 1. - 6.
            int minNum = nums.Min();
            Console.WriteLine($"Here is the minimum number from the list: {minNum}");

            int maxNum = nums.Max();
            Console.WriteLine($"Here is the maximum number from the list: {maxNum}");

            List<int> numsUnder10k = nums.Where(n => n < 10000).ToList();
            int maxNumUnder10k = numsUnder10k.Max();
            Console.WriteLine($"Here is the maximum number from the list: {maxNumUnder10k}");

            List<int> nums10to100 = nums.Where(n => n < 100 && n > 10).ToList();
            Console.WriteLine($"\nHere are the numbers between 10 and 100: ");
            foreach (int num in nums10to100)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Uhhhh... there are none.");

            List<int> nums100kTo999999 = nums.Where(n => n <= 999999 && n >= 100000).ToList();
            Console.WriteLine($"\nHere are the numbers between 100,000 and 999,999: ");
            foreach (int num in nums100kTo999999)
            {
                Console.WriteLine(num);
            }

            List<int> evens = nums.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("\nHere are all the even numbers: ");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }

            List<Student> students = new List<Student>()
            {
                new Student("Jimmy", 13),
                new Student("Hannah Banana", 21),
                new Student("Justin", 30),
                new Student("Sarah", 53),
                new Student("Hannibal", 15),
                new Student("Phillip", 16),
                new Student("Maria", 63),
                new Student("Abe", 33),
                new Student("Curtis", 10)
            };

            //Students 1. - 6.
            List<Student> canDrink = students.Where(n => n.Age >= 21).ToList();
            Console.WriteLine("\n1. Here are all the students who can legally drink: ");
            foreach (Student student in canDrink)
            {
                Console.WriteLine($"\t--{ student.Name}");
            }



            //2.
            //get the max age of entire group
            int oldestInt = students.Max(n => n.Age);
            Student oldest = students.Where(x => x.Age == oldestInt).ToList().First();
            Console.WriteLine($"\n2. The oldest student is {oldest.Name}, who is {oldest.Age}.");

            //3. 
            int youngestInt = students.Min(n => n.Age);
            Student youngestStudent = students.Where(x => x.Age == youngestInt).ToList().First();
            Console.WriteLine($"\n3. The youngest student is {youngestStudent.Name}, who is {youngestStudent.Age}.");

            //4.
            List<Student> sub25List = students.Where(x => x.Age < 25).ToList();
            Console.WriteLine("\n4. Here's our list of students under 25:");
            foreach (Student student in sub25List)
            {
                Console.WriteLine($"\t--{student.Name}, {student.Age}");
            }
            sub25List.OrderBy(x => x.Age);
            Student youngestSub25 = sub25List.First();
            Console.WriteLine($"\nOf whom {youngestSub25.Name} is the oldest.");

            //5.
            List<Student> sub21AndEvenList = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            Console.WriteLine("\n5. The students over 21 and with even ages are: ");
            foreach (Student student in sub21AndEvenList)
            {
                Console.WriteLine($"\t--{student.Name}, {student.Age}");
            }

            //6. 
            List<Student> teensList = students.Where(x => x.Age > 12 && x.Age <= 19).ToList();
            Console.WriteLine("\n6. Our teenagers are: ");
            foreach (Student student in teensList)
            {
                Console.WriteLine($"\t--{student.Name}, {student.Age}");
            }

            //7.
            //define vowels
            //access first letter of student.Name
            List<Student> theVowelKids = students.Where(x => x.Name[0] == 'A' ||
                                                             x.Name[0] == 'O' ||
                                                             x.Name[0] == 'I' ||
                                                             x.Name[0] == 'U' ||
                                                             x.Name[0] == 'E').ToList();

            Console.WriteLine("\n7. Here are the vowel kids: ");
            foreach (Student student in theVowelKids)
            {
                Console.WriteLine($"\t--{student.Name}, {student.Age}");
            }
        }
    }
}
