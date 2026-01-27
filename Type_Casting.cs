using System;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[]args)
        {
            Implicit_Casting();

            Explicit_Casting();

            Type_Conversion();
        }
        
        static void Implicit_Casting()
        {
            //Type Casting is when you assign a value of one data type to another
            //Implicit Casting 
            int myInt = 9;
            double myDouble= myInt; //Automatic casting: Int to Double

            Console.WriteLine("--Implicit Casting--");
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
        }

        static void Explicit_Casting()
        {
            //Explicit Casting
            double myDouble = 9.78;
            int myInt = (int) myDouble; //Manual Casting: Double to Int

            Console.WriteLine("--Explicit Casting--");
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
        }

        static void Type_Conversion()
        {
            //Type Conversion Methods
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            
            Console.WriteLine("--Type Conversion Method--");
            Console.WriteLine(Convert.ToString(myInt)); //convert int to string
            Console.WriteLine(Convert.ToDouble(myInt)); //convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble)); //convert double to int
            Console.WriteLine(Convert.ToString(myBool)); //convert bool to string
        }
    }
}