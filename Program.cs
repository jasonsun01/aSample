using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                int number = 0;
                {
                    // Assign the address of number to a pointer:
                    int* p = &number;

                    // Print the value of *p:
                    System.Console.WriteLine("Value at the location pointed to by p: {0:X}", *p);

                    // Print the address stored in p:
                    System.Console.WriteLine("The address stored in p: {0}", (int)p);
                }

                System.Console.ReadKey();
            






            //// to get the input string
            //Console.WriteLine("Please input servral number seperated by \'+\'");           
            //String inputString = Console.ReadLine();         
            //String[] inputSplit = inputString.Split('+');
            //int result = 0;
            //int paraMeter = 0;
            //for (int i = 0; i <= inputSplit.Length-1; i++) 
            //{
            //      if(Int32.TryParse(inputSplit[i], out paraMeter))
            //    {
            //        result = result + paraMeter;
            //    }

            //}
            //Console.WriteLine(string.Concat($"The result of the number sequence is:{result}"));
        }
    }
   
    }

}
