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
            //int number1 = 20;
            //int number2 = 100;
            //var result2=Add4(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //ref keyword ile ayni mantik calisir tek fark degiskene basta default deger vermeye gerek yoktur
            //int number1;
            //int number2 = 100;
            //var result2=Add5(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //Console.WriteLine(Multiply(2,3));
            //Console.WriteLine(Multiply(2,3,4));

            Console.WriteLine(Add6(6, 7, 1, 55, 478));

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

        static int Add5(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //METHOD OVERLOADING

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        //PARAMS KEYWORD

        static int Add6(params int[] numbers) 
        {
            return numbers.Sum();
        }
    }
}