namespace Metotlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();



            //var result = Add2(5);
            //Console.WriteLine(result); 

            //int number1 = 20;
            //int number2 = 100;
            //var result2=Add3(number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //ref keyword ile number1 degerini degistirdik
            int number1 = 20;
            int number2 = 100;
            var result2=Add4(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
        }

        static void Add() 
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2=30)//Default degerler metodun en sonunda yer almasi gerekiyor
        {
            var result = number1 + number2;
            return result;  
        }

        static int Add3(int number1, int number2) 
        {
            number1 = 30;
            return number1 + number2;   
        }

        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}