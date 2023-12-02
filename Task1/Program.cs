using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Task 1.1
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Name: " + name);

            ////Task 1.2
            //double myDouble = 5.5;
            //string myString = "Hazem Salameh";
            //char myChar = 'H';
            //bool myBool = true;
            //int myInt = 24;
            //const double myConst= 3.14;
            //Console.WriteLine("Double Variable: " + myDouble);
            //Console.WriteLine("String Variable: " + myString);
            //Console.WriteLine("Char Variable: " + myChar);
            //Console.WriteLine("Boolean Variable: " + myBool);
            //Console.WriteLine("Int Variable: " + myInt);
            //Console.WriteLine("Const Variable: " + myConst);


            //// Task 1.3
            //string[] cars = { "BMW", "GMC", "Mercedes", "Tesla" };
            //for(int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}
            //Console.WriteLine("Length Of Array: " + cars.Length);


            //// Task 1.4
            //string firstName, lastName;
            //int yearOfBirth;
            //Console.WriteLine("Input your first Name:");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Input your last Name:");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Input your year of birth:");
            //yearOfBirth = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");


            ////Task 1.5
            //int[] arr = new int[10];
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine($"Enter Eement - {i}: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write("Elements in array are: ");
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.Write(arr[i]+" ");
            //}


            //Task 1.6
            int[] array = new int[3];
            int sum=0;
            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine($"Enter Eement - {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine(""+sum);
            Console.WriteLine("Sum of all elements stored in the array is :" + sum);
            
            

        }
    }
}
