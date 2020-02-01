using System;

namespace OddIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            
            for(int i = 1; i <= 7; i++){

              if(i % 2 != 0){
                number *= i;
               
              }
            }

            Console.WriteLine(number);
        }
    }
}
